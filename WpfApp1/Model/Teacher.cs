﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Teacher : BaseEntity
    {
   
        public string firstName { get; set; }
        public string LastName { get; set; }
        public int DepID { get; set; }
    }

}
