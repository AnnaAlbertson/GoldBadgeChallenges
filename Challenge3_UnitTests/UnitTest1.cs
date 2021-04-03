using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge3_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private Dictionary<int, List<string>> badgesDictionary = new Dictionary<int, List<string>>();
        [TestMethod]
        public void TestMethod1()
        {
            int badgeID = 1;

            foreach (KeyValuePair<int, List<string>> badgePair in badgesDictionary)
            {
                if (badgePair.Key == badgeID)
                {
                    Console.WriteLine(badgePair);
                }
                else
                {
                    Console.WriteLine("Badge pair not found");
                }
            }
        }
    }
}
