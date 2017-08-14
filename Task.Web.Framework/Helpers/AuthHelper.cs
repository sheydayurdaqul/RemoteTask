using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Task.Service;



namespace Task.Web.Framework.Helpers
{
   public class AuthHelper
    {
        UnitofWork db = new UnitofWork();
      public  bool isAuth(string actionName,string pageName)
       {
      
         if(CookieHelper.GetCookie("loginTicket")==string.Empty)
            {

         
                return false;
            }
          else
            {
                var user = db.Users.findUserbyTickedId(CookieHelper.GetCookie("loginTicket"));
               if ( user==null)
                {
                    return false;
                }
               else
                {
                    return true;
                }
            
            }


       }



       
     

    }
    
}
