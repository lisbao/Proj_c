using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public  class ResourceManagement
    {
        int IdCount {get; set;}
        Dictionary<int,Resource> Resources {get; set;}

        public ResourceManagement()
        {
            Resources = new Dictionary<int,Resource>();
        
        }

        private void AddResource(Resource R)
        {
            Resources.Add(IdCount, R);
        }

        public int Increment()
        {

            return ++IdCount;
        
        }

        public IEnumerable<Tuple<Resource, int>> GetWorkingTimeByMinutes(DateTime date)
        {
            foreach (var resource in Resources)
            {
               int time = resource.Value.Calendar
                    .FilterBy((t) => t.Allocated_Start.Date == date.Date && 
                     t.GetType().Name == "Work")
                    .Sum((t) => t.Duration().Minutes);

               yield return new Tuple<Resource, int>(resource.Value,time);
            }      
        }
        

    }
}
