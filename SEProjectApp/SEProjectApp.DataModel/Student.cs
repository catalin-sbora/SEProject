﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProjectApp.DataModel
{
    public class Student : EntityClass
    {       
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
