﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShape.Models
{
    public class Circle
    {
        public Circle(double Radius)
        {
            this.Radius= Radius;
        }
        public double Radius { get; set; }
    }
}
