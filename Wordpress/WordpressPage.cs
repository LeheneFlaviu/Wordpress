using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordpress
{
    public class WordpressPage
    {
        public int id = 99;
        public string title = "testtitle";
        public string content = "abcdefg";
        public enum Status
        {
            Draft,
            Published,
            PendingReview
        };
        public Status status  { get; set ; } = Status.PendingReview;
        public Boolean isVisible = true;
        public DateTime publishDate;        
        public int parent =1;
        public int order = 2;
        public int viewCount = 3;
        public static int pageCount = 0;
        public static List<WordpressPage> lista = new List<WordpressPage>();
        public bool isPublished
        {
            get
            {             
                return (this.status == Status.Published);
            }
        }
       
        public WordpressPage(string title, string content)
        {
            this.title = title;
            this.content = content;
            this.id = ++pageCount;
        }

        public void Publish()
        {
                if (this.isPublished)
                {
                    throw new Exception("Pagina este deja publicata!");                    
                }
            
            this.publishDate = DateTime.Now;
            this.status = Status.Published;

        }

        public void Publish(int hours)
        {

                if (this.isPublished)
                {
                    throw new Exception();
                }

            this.publishDate = DateTime.Now.AddHours(hours);
            this.status = Status.Published;
        }

        public void Publish(DateTime dateTime)
        {

                if (this.isPublished)
                {
                    throw new Exception();
                }

            this.publishDate = dateTime;
            this.status = Status.Published;
        }

        public void SetChild(WordpressPage page) //instanta curenta primeste copil page == page primeste parinte instanta curenta
        {
            page.parent = this.id;
        }
        public void SetParent(WordpressPage page)
        {
            this.parent = page.id;
        }

        public int GetWordCount()
        {
            string [] split = this.content.Split(' ');
            return split.Length;
        }

        public void PendingReview()
        {        
            this.status = Status.PendingReview;
            lista.Add(this);
        }

        public override string ToString()
        {

            return "ID: " + id + "\nTitle: " + title + "\nContent: " + content + "\nStatus:" + status + "\nisVisible: " 
                + isVisible + "\npublishdate: " + publishDate + "\nParent: " + parent + "\nOrder: " + order + "\nviewCount: " + viewCount + "\n";
            //return Convert.ToString(id);
            
        }
    }
}
