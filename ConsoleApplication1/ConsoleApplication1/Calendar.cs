using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class Calendar
    {

        SortedSet<Slot> slots = new SortedSet<Slot>(new DateComparer());

        public IEnumerable<Slot> FilterBy(Func<Slot,bool> Query)
        {
            return slots.Where(Query);
        
        }


        public int GetTime(Func<Slot, bool> query)
        {
            IEnumerable slotsSet = FilterBy(query);
            int count = 0;
            foreach (Slot e in slotsSet)
            {
                count += e.Allocated_Finish.Subtract(e.Allocated_Start).Hours;
            }
            return count;
        }

      }


}
