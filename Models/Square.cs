using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShape.Models
{
    public class Square : Shape
    {
        public Square(double Height)
        {
            this.Height = Height;
        }
        public double Height { get; set; }
        public override double Area()
        {
            Console.WriteLine("L'aire du Carré est de " + Height * Height);
            return Height * Height;
        }
    }
}
