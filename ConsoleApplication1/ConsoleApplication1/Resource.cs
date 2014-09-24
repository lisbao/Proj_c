using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
   abstract class Resource
    {
        public int _id_Resource;
        public string _name;
        public int _numHours;
       
        public Calendar Calendar { get; set; }

        public Resource(int idResource, string name, int numHours) 
        {
            _id_Resource = idResource;
            _name = name;
            _numHours = numHours;
            Calendar = new Calendar();
            
        }

        public int GetWorkingTime(DateTime date_start, DateTime date_finish)
        {
           
                return Calendar.FilterBy((t) => t.Allocated_Start.Date >= date_start.Date && 
                            t.Allocated_Finish.Date <= date_finish.Date &&
                            t.GetType().Name == "Work")
                            .Sum((t) => t.Duration());

        }
         
      

        
    }
}