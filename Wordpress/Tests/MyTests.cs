using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Wordpress
{
    [TestFixture]
    public class MyTests
    {
        [Test]
        public void TestSortList()
        {
            WordpressPage myPage1 = new WordpressPage("page1", "content1");
            WordpressPage myPage2 = new WordpressPage("page2", "content2");
            WordpressPage myPage3 = new WordpressPage("abcd", "content bla");
            WordpressPage myPage4 = new WordpressPage("yyz", "");

            List<WordpressPage> testList = new List<WordpressPage>();
            testList.Add(myPage1);
            testList.Add(myPage2);
            testList.Add(myPage3);
            testList.Add(myPage4);

            List<WordpressPage> sortedList = new List<WordpressPage>();
            sortedList.Add(myPage3);
            sortedList.Add(myPage1);
            sortedList.Add(myPage2);
            sortedList.Add(myPage4);

            testList = WordpressPage.SortList(testList);

            Assert.IsTrue(testList[0] == sortedList[0]);
            Assert.IsTrue(testList[1] == sortedList[1]);
            Assert.IsTrue(testList[2] == sortedList[2]);
            Assert.IsTrue(testList[3] == sortedList[3]);


            //Assert.IsTrue(testList[0] == testList[0]);
            //Assert.IsTrue(testList[1] == testList[1]);
            //Assert.IsTrue(testList[2] == testList[2]);
            //Assert.IsTrue(testList[3] == testList[3]);
        }


        [Test]
        public void IndependentAndUniqueIDs()
        {
            WordpressPage page1 = new WordpressPage(string.Empty, string.Empty);
            WordpressPage page2 = new WordpressPage(string.Empty, string.Empty);
            WordpressPost post1 = new WordpressPost(string.Empty, string.Empty);
            WordpressPost post2 = new WordpressPost(string.Empty, string.Empty);

            //occam's razor: se poate folosi un caz simplu (ex: 4 elemente, nu 100)

            //unique
            Assert.IsTrue(page1.id != page2.id);
            Assert.IsTrue(post1.id != post2.id);

            //independent
            Assert.IsTrue(page1.id == post1.id);
            Assert.IsTrue(page2.id == post2.id);


        }

        //[Test]
        //public void TestIPublish() 
        //    //presupunem ca orice clasa care implementeaza interfata va modifica valoarea isPublished prin cele 2 metode ale sale 
        //{
        //    IPublish page = new WordpressPage(string.Empty, string.Empty);

        //    page.Publish();
        //    Assert.IsTrue(page.isPublished);
        //    page.UnPublish();
        //    Assert.IsFalse(page.isPublished);

        //    IPublish comment = new WordpressComment();

        //    comment.Publish();
        //    Assert.IsTrue(comment.isPublished);
        //    comment.UnPublish();
        //    Assert.IsFalse(comment.isPublished);

        //}

        public void TestIPublish(IPublish element)
        {
            element.Publish();
            Assert.IsTrue(element.isPublished);
            element.UnPublish();
            Assert.IsFalse(element.isPublished);
        }

        [Test]
        public void TestIPublishPage()
        {
            TestIPublish(new WordpressPage(string.Empty, string.Empty));
        }

        [Test]
        public void TestIPublishComment()
        {
            TestIPublish(new WordpressComment());
        }

        [Test]
        public void TestIPublishPost()
        {
            TestIPublish(new WordpressPost(string.Empty, string.Empty));
        }


        [Test]
        public void TestIsInFeed()
        {
            Assert.IsTrue(new PublicVisibility().IsInFeed());
            Assert.IsFalse(new PrivateVisibility().IsInFeed());
        }

        [Test]
        public void TestCanBeSearched()
        {
            Assert.IsTrue(new PublicVisibility().CanBeSearched());
            Assert.IsFalse(new PrivateVisibility().CanBeSearched());
        }


        [Test]
        public void TestPublicVisibility()
        {
            PublicVisibility pub = new PublicVisibility();
            Assert.IsTrue(pub.isVisibleBy(WordpressVisibility.AccesLevel.Other));
            Assert.IsTrue(pub.isVisibleBy(WordpressVisibility.AccesLevel.Editor));
            Assert.IsTrue(pub.isVisibleBy(WordpressVisibility.AccesLevel.Administrator));
            Assert.IsTrue(pub.canView(string.Empty));
        }

        [Test]
        public void TestPrivateVisibility()
        {
            PrivateVisibility priv = new PrivateVisibility();
            Assert.IsFalse(priv.isVisibleBy(WordpressVisibility.AccesLevel.Other));
            Assert.IsTrue(priv.isVisibleBy(WordpressVisibility.AccesLevel.Editor));
            Assert.IsTrue(priv.isVisibleBy(WordpressVisibility.AccesLevel.Administrator));
            Assert.IsTrue(priv.canView(string.Empty));
        }

        [Test]
        public void TestPasswordVisibility()
        {
            PasswordVisibility pass = new PasswordVisibility();
            Assert.IsFalse(pass.isVisibleBy(WordpressVisibility.AccesLevel.Other));
            Assert.IsTrue(pass.isVisibleBy(WordpressVisibility.AccesLevel.Editor));
            Assert.IsTrue(pass.isVisibleBy(WordpressVisibility.AccesLevel.Administrator));
            Assert.IsTrue(pass.canView("parola"));
            Assert.IsFalse(pass.canView("parolax"));
        }

    }
}
