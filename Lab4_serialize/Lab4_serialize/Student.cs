﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_serialize
{
    [Serializable]
    class Student
    {
        public string name;
        public int age;

        public void setInfo()
        {
            name = "Student 1";
            age = 19;
        
        }

        public override string ToString()
        {
            return name + "\n" + age;
             
        }
    }
}