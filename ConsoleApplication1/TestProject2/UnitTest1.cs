using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class TestSlot
    {
        [TestMethod]
        public void Duration()
        {
           DateTime start = DateTime.Today;
           DateTime finish = start.AddHours(8);
           Slot slot1 = new Work(start, finish, "trabalhou muito!");

           Assert.AreEqual(8, slot1.Duration().Hours);
        }
        
    }
}
