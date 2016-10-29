using NUnit.Framework;
using System;
using System.Collections.Generic;

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
            testList.Add(myPage3);
            testList.Add(myPage1);
            testList.Add(myPage2);
            testList.Add(myPage4);

            try
            {
                Assert.IsTrue(SortList(testList) == sortedList);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceptie: " + e.Message);
                //Console.ReadKey;
            }
        }
    }
}
