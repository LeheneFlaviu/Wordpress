using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress
{
    public class WordpressComment : IPublish
    {
        public bool result { get; set; }

        bool IPublish.isPublished
        {
            get
            {
                return result = true;
            }
        }
        public void Publish()
        {
            result = true;
        }

        public void Unpublished()
        {
            result = true;
        }
    }
}
