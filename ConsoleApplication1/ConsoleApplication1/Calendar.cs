using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
   public class Calendar
    {

      public  SortedSet<Slot> slots = new SortedSet<Slot>(new DateComparer());

        public IEnumerable<Slot> FilterBy(Func<Slot,bool> Query)
        {
            return slots.Where(Query);
        
        }

        public IEnumerable<Slot> FilterByType(string type)
        {
            return FilterBy((t) => t.GetType().Name == type);
        }

        public IEnumerable<Slot> FilterByDateAndType(DateTime date_start, DateTime date_finish, string type)
        {
            return FilterBy((t) => t.Allocated_Start.Date >= date_start.Date &&
                            t.Allocated_Finish.Date <= date_finish.Date &&
                            t.GetType().Name == type);
        }

        public IEnumerable<Absence> FilterAbsences(DateTime date_start, DateTime date_finish)
        {
            IEnumerable<Absence> a = (IEnumerable<Absence>)FilterBy((t) => t.Allocated_Start.Date >= date_start.Date &&
                            t.Allocated_Finish.Date <= date_finish.Date &&
                            t.GetType().Name == "Absence");

            return a;
        }

        public IEnumerable<Absence> FilterAbsenceByType(Absence.AbsenceType type, DateTime date_start, DateTime date_finish)
        {
            IEnumerable<Absence> a = FilterAbsences(date_start, date_finish);
            return a.Where((t) => t._type == type);
        }

        public int GetMinutesByType(DateTime date_start, DateTime date_finish, string type)
        {
            return FilterByDateAndType(date_start, date_finish, type).Sum((t) => t.Duration().Minutes);
        }

        public int GetHoursByType(DateTime date_start, DateTime date_finish, string type)
        {

            return FilterByDateAndType(date_start, date_finish, type).Sum((t) => t.Duration().Hours);
        }

        public int GetDaysByType(DateTime date_start, DateTime date_finish, string type)
        {

            return FilterByDateAndType(date_start, date_finish, type).Sum((t) => t.Duration().Days);
        }

       

      }


}
