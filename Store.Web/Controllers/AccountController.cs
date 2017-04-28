using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Data.DB;
using Store.Data.Models;
using Store.Web.Helper;
using Store.Web.Models;
using Store.Web.Security;
using Store.Web.ViewModels;

namespace Store.Web.Controllers
{
    public class AccountController : Controller
    {
        private MyContext _ctx = new MyContext();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TryLogin(AccountVM avm)
        {
            AccountModel am = new AccountModel();
            if (string.IsNullOrEmpty(avm.Account.Username) || string.IsNullOrEmpty(avm.Account.Password) ||
                am.Login(avm.Account.Username, avm.Account.Password) == null)
            {
                ViewBag.Error = "Account is invalid";
                return View("Login");
            }
            SessionPersister.username = avm.Account.Username;
            return RedirectToAction("Index", "Home");

        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        public ActionResult Logout()
        {
            SessionPersister.username = string.Empty;
            return RedirectToAction("Index","Home");
        }

        public ActionResult Register(AccountVM acc)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Login");

            Customer c = new Customer()
            {
                IsDeleted = false,
                Username = acc.Register.Username,
                Email = acc.Register.Email,
                PasswordHash = StringHelper.GetMd5Hash(acc.Register.Password), 
                RegistrationDate = DateTime.Now,
                Status = true,
                Fname = acc.Register.Fname,
                Lname = acc.Register.Lname
            };
            _ctx.Customers.Add(c);
            _ctx.SaveChanges();

            Account a = new Account(){ Username = acc.Register.Username, Password = acc.Register.Password };
            AccountVM avm = new AccountVM() { Account = a};
           
            return TryLogin(avm);
        }
    }
}