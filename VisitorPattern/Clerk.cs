﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    // Three employee types

    class Clerk : Employee
    {
        // Constructor
        public Clerk()
            : base("Hank", 25000.0, 14)
        {
        }
    }
}
