using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Wordpress
{
    [TestFixture]
    public class MyFirstTest
    {
        [Test]
        public void myTest()
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
    }
}
