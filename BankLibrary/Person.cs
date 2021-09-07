﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Person 
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }

        public Person()
        {
            FirstName = "No Name";
            LastName = "No Last Name";
            Address = "No Address";
        }
    }
}
