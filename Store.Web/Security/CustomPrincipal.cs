using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using Store.Web.Models;

namespace Store.Web.Security
{
    public class CustomPrincipal: IPrincipal
    {
        private Account _account;

        public CustomPrincipal(Account account)
        {
            this._account = account;
            this.Identity = new GenericIdentity(account.Username);
        }

        public bool IsInRole(string role)
        {
            var roles = role.Split(new char[] {','});
            return roles.Any(x => this._account.Roles.Contains(x));
        }

        public IIdentity Identity { get; set; }
    }
}