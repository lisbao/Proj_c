using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ConsoleApplication1
{
    [TestFixture]
    class TestSlot 
    {
        [Test]
        public void Duration()
        {
           DateTime start = DateTime.Today;
           DateTime finish = start.AddHours(8);
           Slot slot1 = new Work(start, finish, "trabalhou muito!");

           Assert.AreEqual(8, slot1.Duration().Hours);
        }

    }
}
