using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress
{
    class WordpressPost:WordpressPage
    {
        public enum Format
        {   Standard,
            Aside,
            Image,
            Video,
            Quote,
            Link,
            Gallery,
            Status,
            Audio,
            Chat
        };
        public Format format;
        public List<String> Categories;
        public List<String> Tags;
        string featuredImage;




    }
}
