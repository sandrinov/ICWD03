﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this Int32 i, int value)
        {
            return i > value;
        }
    }
}
