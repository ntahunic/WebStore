using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Store.Data.DB;
using Store.Web.Helper;

namespace Store.Web.Models
{
    public class AccountModel
    {
        private MyContext _ctx = new MyContext();
        private List<Account> _accounts = new List<Account>();

        public AccountModel()
        {
            foreach (var user in _ctx.Users.Where(user => !user.IsDeleted))
            {
                _accounts.Add(new Account()
                {
                    Username = user.Username,
                    Password = user.PasswordHash,
                    Roles = _ctx.UserRoles.Where(x => x.UserId == user.Id).Select(y => y.Role.Name).ToArray()
                });
            }
            foreach (var customer in _ctx.Customers.Where(customer => !customer.IsDeleted))
            {
                _accounts.Add(new Account()
                {
                    Username = customer.Username,
                    Password = customer.PasswordHash
                });
            }
        }

        public Account Find(string username)
        {
            return _accounts.FirstOrDefault(x => x.Username.Equals(username));
        }

        public Account Login(string username, string password)
        {
            return
                _accounts.FirstOrDefault(
                    x => x.Username.Equals(username) && StringHelper.VerifyMd5Hash(password, x.Password));
        }
    }
}