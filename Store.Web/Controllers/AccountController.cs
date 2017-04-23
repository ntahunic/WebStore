using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Web.Models;
using Store.Web.Security;
using Store.Web.ViewModels;

namespace Store.Web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AccountVM avm)
        {
            AccountModel am = new AccountModel();
            if (string.IsNullOrEmpty(avm.Account.Username) || string.IsNullOrEmpty(avm.Account.Password) ||
                am.Login(avm.Account.Username, avm.Account.Password) == null)
            {
                ViewBag.Error = "Account is invalid";
                return View("Index");
            }
            SessionPersister.username = avm.Account.Username;
            return View("Success");

        }

        public ActionResult Logout()
        {
            SessionPersister.username = string.Empty;
            return RedirectToAction("Index");
        }
    }
}