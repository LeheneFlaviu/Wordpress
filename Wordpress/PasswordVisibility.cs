using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress
{
    class PasswordVisibility : PrivateVisibility
    {
        public string _password = "pass";
        public override bool CanView(string password)
        {
            return password == this._password;
        }       
    }
}
