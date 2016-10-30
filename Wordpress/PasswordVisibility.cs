using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress
{
    public class PasswordVisibility : PrivateVisibility
    {
        public string password = "parola";

        public override bool canView(string password)
        {
            return (this.password == password);
        }

    }
}
