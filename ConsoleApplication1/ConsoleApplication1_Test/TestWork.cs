using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using ConsoleApplication1;

namespace ConsoleApplication1_Test
{
    [TestClass]
    public class TestWork
    {
        [TestMethod]
        public void Duration()
        {
            DateTime start = DateTime.Now;
            DateTime finish = DateTime.Now.AddHours(8);
            Work slot1 = new Work(start, finish, "trabalhou muito!");
            slot1.SetDoneTime(start, finish);

            Assert.AreEqual(8, slot1.Duration().Hours);
        }

        [TestMethod]
        public void CompareTimes()
        {
            DateTime start = DateTime.Now;
            DateTime finish = DateTime.Now.AddHours(8);
            Work slot2 = new Work(start, finish, "trabalhou muito!");
            slot2.SetDoneTime(start, finish);

            Assert.AreEqual(0, slot2.CompareTimes().Hours);
        
        }
    }
}
