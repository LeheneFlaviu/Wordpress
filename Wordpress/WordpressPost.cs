using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress
{
    class WordpressPost : WordpressPage
    {
        List<string> categories = new List<string>();
        List<string> tags = new List<string>();
        enum Formats  {Standard, Aside, Image, Video, Quote, Link };
        Formats format;
        public WordpressPost(string title, string content) : base(title, content)
        {
        }
    }
}
