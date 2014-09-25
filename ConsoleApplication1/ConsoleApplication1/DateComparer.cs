using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class DateComparer : IComparer<Slot>
    {
        public int Compare(Slot x, Slot y)
        {
            return x.Allocated_Start.CompareTo(y.Allocated_Start);
            
        }
    }
}
