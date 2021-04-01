using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PleaseWork
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            List<string> badge = new List<string>();
            badge.Add("A-2");
            badge.Add("A-3");
            badge.Add("A-4");
            dict.Add("12353", badge);

            Console.WriteLine(dict);
        }
    }
}
