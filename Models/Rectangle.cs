﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShape.Models
{
    public class Rectangle : Shape
    {
        public Rectangle(double Height, double Width)
        {
            this.Height= Height;
            this.Width= Width;
        }
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            Console.WriteLine("L'aire du Rectangle est de " + Height * Width);
            return Height * Width;
        }
    }
}
