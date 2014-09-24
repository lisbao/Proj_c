using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ResourceManagement
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


    }
}
