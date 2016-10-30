using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress
{
    public class PrivateVisibility : WordpressVisibility
    {
        public override bool isVisibleBy(AccesLevel level)
        {
            return (level != AccesLevel.Other);
        }

        public override bool canView(string password)
        {
            return canView();
        }

        public bool canView()
        {
            return true;
        }
    }
}
