using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress
{
    public abstract class WordpressVisibility
    {
        public enum AccessLevel
        {
            Other,
            Editor,
            Administrator
        }

        public abstract bool IsVisibleBy(AccessLevel level);

        public abstract bool CanView(string password);

        public bool IsFeed()
        {
            return IsVisibleBy(AccessLevel.Other);
        }
        public bool CanBeSearched()
        {
            return IsVisibleBy(AccessLevel.Other);
        }
    }
}
