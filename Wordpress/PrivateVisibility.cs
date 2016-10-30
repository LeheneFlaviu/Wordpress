using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress
{
    class PrivateVisibility : WordpressVisibility
    {
        public override bool CanView(string password)
        {
            return true;
        }

        public override bool IsVisibleBy(AccessLevel level)
        {
                return false;
        }
    }
}
