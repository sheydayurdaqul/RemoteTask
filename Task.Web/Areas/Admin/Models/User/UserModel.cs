using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task.Data.Model;

namespace Task.Web.Areas.Admin.Models
{
    public class UserModel
    {
       public User user { get; set; }
       public List<Role> roles { get; set; }                                                                                                                 
    }
}