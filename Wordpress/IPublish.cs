using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress
{
    public interface IPublish
    {
        bool isPublished { get; }
        void Publish();
        void Unpublished();
    }
}
