using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
   abstract class Resource
    {
        public int Id_Resource;
        public string Name;
        public int NumHours;
       
        public Calendar Calendar { get; set; }

        public Resource(int _IdResource, string _Name, int _NumHours) 
        {
            Id_Resource = _IdResource;
            Name = _Name;
            NumHours = _NumHours;
            Calendar = new Calendar();
            
        }

        
      

        
    }
}