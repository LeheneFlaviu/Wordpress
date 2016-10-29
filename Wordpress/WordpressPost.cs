using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress
{
    public class WordpressPost : WordpressPage
    {
        public enum Format
        {
            Standard,
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
        public List<string> Categories;
        public List<string> Tags;
        public string featuredImage;
        public static int postCount = 0;       

        public WordpressPost(string title, string content) : base(title, content)
        {
            --pageCount;
            this.id = ++postCount;
        }
    }
}

