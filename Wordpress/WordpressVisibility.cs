using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress
{
    public abstract class WordpressVisibility
    {
        public enum AccesLevel {
            Other, //sunt disjuncte!
            Editor,
            Administrator }

        public abstract bool isVisibleBy(AccesLevel level);

        public abstract bool canView(string password);

        public bool IsInFeed()
        {
            return isVisibleBy(AccesLevel.Other);
        }

        public bool CanBeSearched()
        {
            return isVisibleBy(AccesLevel.Other);
        }
    }
}
