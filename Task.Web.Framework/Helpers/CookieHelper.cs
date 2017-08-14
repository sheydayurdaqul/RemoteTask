using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
//using HttpCookieEncryption;
namespace Task.Web.Framework.Helpers
{
   public class CookieHelper
    {
     
        public  static void SetCookie(string key, string value, TimeSpan expires)
        {

            HttpCookie encodedCookie =new HttpCookie(key, value);

            if (HttpContext.Current.Request.Cookies[key] != null)
            {
                var cookieOld = HttpContext.Current.Request.Cookies[key];
                cookieOld.Expires = DateTime.Now.Add(expires);
                cookieOld.Value = encodedCookie.Value;
                HttpContext.Current.Response.Cookies.Add(cookieOld);
            }
            else
            {
                encodedCookie.Expires = DateTime.Now.Add(expires);
                HttpContext.Current.Response.Cookies.Add(encodedCookie);
            }
        }
        public  static string GetCookie(string key)
        {
            string value = string.Empty;
            HttpCookie cookie = HttpContext.Current.Request.Cookies[key];

            if (cookie != null)
            {
                HttpCookie decodedCookie = cookie;
                value = decodedCookie.Value;
            }
            return value;
        }
    

}
}
