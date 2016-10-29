using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Wordpress
{
    [TestFixture]
    public class WordpressPageTests
    {
        [Test]
        public void MyTest()
        {       
            WordpressPage page2 = new WordpressPage("AecondPageForTest", "Content of the Second pageTest");
            WordpressPage page3 = new WordpressPage("BhirdPageForTest", "Content of the Third pageTest");
            WordpressPage page1 = new WordpressPage("CageForTest", "Content of the pageTest");
            List<WordpressPage> listaPagini = new List<WordpressPage>();
            listaPagini.Add(page1);
            listaPagini.Add(page2);
            listaPagini.Add(page3);
            var pages = WordpressPage.SortIds(listaPagini);
            for (int i = 0; i < pages.Count-1; i++)
            {
                Assert.LessOrEqual(pages[i].id, pages[i+1].id);                
            }
        }

        [Test]

        public void TestForUniqueIds()
        {
            WordpressPage InitialPage = new WordpressPage("Page's Title", "Page's content");
            WordpressPost InitialPost = new WordpressPost("Post's title", "Post's Content");
            WordpressPage SecondPage = new WordpressPage("Second Page's Title", "Second Page's content");
            WordpressPost SecondPost = new WordpressPost("Second Post's title", "Second Post's Content");

            Assert.AreEqual(InitialPage.id, InitialPost.id);
            Assert.AreNotEqual(InitialPost.id, SecondPost.id);
            Assert.AreNotEqual(InitialPage.id, SecondPage.id);
        }

        [Test]
        public void TestInterfaceMethods()
        {
            IPublish interfacePublish = new WordpressPage("InterfaceTitle", "Ceva Content");
            interfacePublish.Publish();
            Assert.IsTrue(interfacePublish.isPublished);
        }
        
        public void TestPublish(IPublish element)
        {
            element.Publish();
            Assert.IsTrue(element.isPublished);
        }

        [Test]
        public void PublishTest()
        {
            TestPublish((IPublish)new WordpressPage("AboutPage","Content for About page"));
        }
        [Test]
        public void PublishTest2()
        {
            TestPublish((IPublish)new WordpressComment());
        }

    }
    
}

