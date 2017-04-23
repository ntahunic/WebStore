using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Web.Security;

namespace Store.Web.Controllers
{
    public class DemoController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [CustomAuthorize(Roles="admin")]
        public ActionResult work1()
        {
            return View();
        }
    }
}