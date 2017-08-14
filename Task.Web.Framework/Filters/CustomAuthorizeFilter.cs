using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Task.Web.Framework.Helpers;
using System.Web.Routing;


namespace Task.Web.Framework.Filters
{
  public class CustomAuthorizeFilter: AuthorizeAttribute
    {

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            AuthHelper authhelper = new AuthHelper();
            //  base.OnAuthorization(filterContext)
            try
            {
                if (authhelper.isAuth(filterContext.ActionDescriptor.ActionName.ToString(),""))
                {   
                    return;
                }
                if (filterContext == null)
                    return;

                if(filterContext.IsChildAction)
                {
                    return;
                }
                if (SkipAuth(filterContext))
                    return;
            
              
               string refererUrl= filterContext.HttpContext.Request.Url.ToString();         
              if(!refererUrl.Contains("Login"))                       
              filterContext.Result = new RedirectResult("~/Login/Index");
               


                // filterContext.Result = new RedirectResult(loginUrl);
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected  bool SkipAuth(AuthorizationContext filterContext)
        {
            if(filterContext==null)
            {
                return false;
            }

            var actions = filterContext.ActionDescriptor.GetCustomAttributes(typeof(AllowAnonymousAttribute),true);
            var controllers= filterContext.Controller.GetType().GetCustomAttributes(typeof(AllowAnonymousAttribute), true);
            return actions.Length>0 ||controllers.Length>0;          
      }
}
}
