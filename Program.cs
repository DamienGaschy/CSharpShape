
using CSharpShape.Models;


class Program
{ 
    public double TotalArea(object[] arrObjects)
    {
        double area = 0;
        Rectangle objRectangle;
        Circle objCircle;
        foreach(var obj in arrObjects)
        {
            if(obj is Rectangle) 
            {
                objRectangle = (Rectangle)obj;
                area += objRectangle.Height * objRectangle.Width;
            }
            else
            {
                objCircle = (Circle)obj;
                area += objCircle.Radius * objCircle.Radius * Math.PI;
            }
        }
        return area;
    }

    void Main(string[] args)
    {
        Rectangle rect1 = new Rectangle(10, 5);
        Circle circle1 = new Circle(4);

        object[] arrObjects = { rect1, circle1 };

        double totalArea = TotalArea(arrObjects);

        Console.WriteLine("La somme des aires des objets est : " + totalArea);
    }
}