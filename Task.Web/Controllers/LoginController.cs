using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Web.Framework.Helpers;
using Task.Web.Model;
using Task.Web.Validators;
using Task.Service;
using Task.Data.Model;

namespace Task.Web.Controllers
{

    public class LoginController : BaseController
    {
        UnitofWork db = new UnitofWork();
        PasswordHelper passwordHelper = new PasswordHelper();
        [AllowAnonymous]
        public ActionResult Index()
        {

            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Index(UserCreditModel userLogin)
        {
            UserValidator validator = new UserValidator();
            string userName = userLogin.UserName;
            string passWord = userLogin.Password;
            ValidationResult result = validator.Validate(userLogin);

            if (result.IsValid)
            {
                string ticketId = userName + "-" + DateTime.Now.ToString("yyyyMMdd");
                if (db.Users.GetUserByMail(userName) == null)
                {
                    User user = new User();
                    user.Email = userLogin.UserName;
                    user.PassWord = passwordHelper.Encrypt(userLogin.Password);
                    user.Alias = user.Email;
                    user.LastLoginDate = DateTime.Now;
                    user.CreatedDate = DateTime.Now;
                    user.TicketId = ticketId;
                    db.Users.AddUser(user);
                }
                else
                {

                    if (passwordHelper.Decrypt(db.Users.GetUserPassword(userName)) == passWord)
                    {
                        //kayıtlı
                    }
                    else
                    {

                    }
                }
                CookieHelper.SetCookie("loginTicket", ticketId, TimeSpan.FromDays(1));
            }


            //guid ve time 



            return View();

        }

    }
}