
using CSharpShape.Models;


class Program
{ 
    public static double TotalArea(object[] arrObjects)
    {
        double area = 0;
        Rectangle objRectangle;
        Circle objCircle;
        Triangle objTriangle;
        foreach(var obj in arrObjects)
        {
            if(obj is Rectangle) 
            {
                objRectangle = (Rectangle)obj;
                area += objRectangle.Height * objRectangle.Width;
            }
            else if(obj is Circle)
            {
                objCircle = (Circle)obj;
                area += objCircle.Radius * objCircle.Radius * Math.PI;
            }
            else 
            {
                objTriangle = (Triangle)obj;
                area += (objTriangle.Height * objTriangle.Width) / 2; 
            }
        }
        return area;
    }

    static void Main(string[] args)
    {
        Rectangle rect1 = new Rectangle(10, 5);
        Circle circle1 = new Circle(4);
        Triangle trian1 = new Triangle(10, 5);

        object[] arrObjects = { rect1, circle1, trian1 };

        double totalArea = TotalArea(arrObjects);

        Console.WriteLine("La somme des aires des objets est : " + totalArea);
    }
}