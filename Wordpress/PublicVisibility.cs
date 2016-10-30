using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress
{
    public class PublicVisibility : WordpressVisibility
    {
        public override bool isVisibleBy(AccesLevel level)
        {
            return true;
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
