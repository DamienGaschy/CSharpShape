using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShape.Models
{
    public class Circle : Shape
    {
        public Circle(double Radius)
        {
            this.Radius= Radius;
        }
        public double Radius { get; set; }
        public override double Area()
        {
            Console.WriteLine("L'aire du Cercle est de " + Radius * Radius * Math.PI);
            return Radius * Radius * Math.PI;
        }
    }
}
