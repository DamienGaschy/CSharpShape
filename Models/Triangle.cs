﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShape.Models
{
    public class Triangle : Shape
    {
        public Triangle(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            Console.WriteLine("L'aire du Triangle est de " + (Height * Width) / 2);
            return (Height * Width) / 2;
        }
    }
}

