﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Employee : Resource
    {
        public Employee(int idEmployee, string name, int numHours) : base(idEmployee, name, numHours)
        {

        }

        public Employee() { }

    }
}