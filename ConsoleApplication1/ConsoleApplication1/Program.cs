using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            IOStreamReader sr = new IOStreamReader("dbinitial.xml");
            sr.createDB();
            sr.Load();
           
            
            Console.WriteLine("Criou a DB");

            ResourceManagement res = new ResourceManagement();
        }
    }
}
