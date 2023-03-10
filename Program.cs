
using CSharpShape.Models;


class Program
{ 
    public static double TotalArea(Shape[] arrObjects)
    {
        double area = 0;
        //double areaR = 0;
        //double areaC = 0;
        //double areaT = 0;
        //Rectangle objRectangle;
        //Circle objCircle;
        //Triangle objTriangle;
        foreach(var obj in arrObjects)
        {
            area += obj.Area();
            //if(obj is Rectangle) 
            //{
            //    objRectangle = (Rectangle)obj;
            //    areaR = objRectangle.Height * objRectangle.Width;
            //    Console.WriteLine("L'aire du rectangle est : " + areaR);
            //    area += objRectangle.Height * objRectangle.Width;
            //}
            //else if(obj is Circle)
            //{
            //    objCircle = (Circle)obj;
            //    areaC = objCircle.Radius * objCircle.Radius * Math.PI;
            //    Console.WriteLine("L'aire du cercle est : " + areaC);
            //    area += objCircle.Radius * objCircle.Radius * Math.PI;
            //}
            //else 
            //{
            //    objTriangle = (Triangle)obj;
            //    areaT = (objTriangle.Height * objTriangle.Width) / 2;
            //    Console.WriteLine("L'aire du triangle est : " + areaT);
            //    area += (objTriangle.Height * objTriangle.Width) / 2; 
            //}
        }
        return area ;
    }

    static void Main(string[] args)
    {
        Rectangle rect1 = new Rectangle(10, 5);
        Circle circle1 = new Circle(4);
        Triangle trian1 = new Triangle(10, 5);
        Square carre1 = new Square(5);

        Shape[] arrObjects = { rect1, circle1, trian1, carre1 };

        double totalArea = TotalArea(arrObjects);

        Console.WriteLine("La somme des aires des objets est : " + totalArea);
    }
}