using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress
{
    public class WordpressComment : IPublish
    {
        public bool isPublished { get; private set; }
        public void Publish()
        {
            isPublished = true;
        }

        public void UnPublish()
        {
            isPublished = false;
        }
    }
}
