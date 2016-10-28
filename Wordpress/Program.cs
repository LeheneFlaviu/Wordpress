using System;


namespace Wordpress
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello world!");
             Console.WriteLine("Press any key to stop...");
             Console.ReadKey();*/

            WordpressPage page = new WordpressPage("titlu_aaa","content_aaa sdags sdsgg");
            WordpressPage SecondPage = new WordpressPage("Al doilea", "si al 2-lea");           
            //Console.WriteLine(page);
            //Console.WriteLine();
           // Console.WriteLine(SecondPage);
            //Console.ReadKey();



            WordpressPage thirdPage = new WordpressPage("third", "blabla3");
            WordpressPage fourthPage = new WordpressPage("patru", "dfssdffdssfd");

            //thirdPage.status = WordpressPage.Status.PendingReview;
            //fourthPage.viewCount = 999999;

            //Console.WriteLine(thirdPage);
            //Console.WriteLine();
            //Console.WriteLine(fourthPage);
            //Console.ReadKey();

            //page.Publish();
            
            //Console.WriteLine(page);
            //Console.ReadKey();

            //page.PendingReview();
            //SecondPage.PendingReview();
            //foreach (var i in WordpressPage.lista)
            //{
            //    Console.WriteLine(i);
            //    Console.ReadKey();
            //}

            //thirdPage.Publish(5);
            //fourthPage.Publish(DateTime.Now.AddDays(1));
            //thirdPage.SetChild(SecondPage);
            //fourthPage.SetParent(page);

            //Console.WriteLine(page.GetWordCount());
            //Console.WriteLine(thirdPage);
            //Console.WriteLine(SecondPage);
            //Console.WriteLine(fourthPage);
            Console.WriteLine(page.isPublished);
            page.status = WordpressPage.Status.Published;
            try
            {
                page.Publish();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(page.isPublished);
            Console.ReadKey();

        }
    }
}
