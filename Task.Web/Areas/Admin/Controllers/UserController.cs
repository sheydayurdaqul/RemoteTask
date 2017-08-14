using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Service;
using Task.Data.Model;
using Task.Web.Framework.Helpers;
using Task.Web.Areas.Admin.Models;

namespace Task.Web.Areas.Admin
{
    public class UserController : Controller
    {
        UnitofWork db = new UnitofWork();
      
        // GET: Admin/User
        public ActionResult Index()
        {
            var users = db.Users.GetUsers();
            IndexModel index = new IndexModel();
            index.users = users;
            return View(index);
        }
        public ActionResult AddRoles()
        {
           
            Role role = new Role();
            role.Type = "admin";
          //role.CreatedDate = DateTime.Now; 
          //  db.Users.AddRole(role);
         
            return View();
        }
        public ActionResult AddUser()
        {
            
            PasswordHelper passwordHelper = new PasswordHelper();
            UserModel model = new UserModel();
            //User user = new User();
            //user.Alias = "syurdakul";
            //user.Email = "sheydayurdakul@hotmail.com";
            //user.FirstName = "seyda";
            //user.LastName = "yurdakul";
            //user.PassWord = passwordHelper.Encrypt("293kayzer");
            //user.Schedule = EnumUser.UserSchedule.hour;
            //user.LastLoginDate = DateTime.Now;
            //user.WorkingTime = 8;
            //Role role = db.Users.GetRoleById(15);
            //user.Roles.Add(role);
            //db.Users.AddUser(user);
            // User user = db.Users.GetUserByMail("sheydayurdakul@hotmail.com");
            //string password= passwordHelper.Decrypt(user.PassWord);
            var role = db.Users.getRoles();
            model.roles = role;
            return View(model);
        }
    }
}