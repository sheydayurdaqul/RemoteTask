using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Web.Framework.Filters;

namespace Task.Web.Controllers
{
    [CustomAuthorizeFilter]
    public class BaseController : Controller
    {
        // GET: Base
        
    }
}