using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, radius, a, b;

            Console.Write("Input X coordinate of top left point: ");
            x1 = Double.Parse(Console.ReadLine());
            Console.Write("Input Y coordinate of top left point: ");
            y1= Double.Parse(Console.ReadLine());
            Console.Write("Input X coordinate of bottom right point: ");
            x2 = Double.Parse(Console.ReadLine());
            Console.Write("Input Y coordinate of bottom right point: ");
            y2 = Double.Parse(Console.ReadLine());

            Rectangle myRectangle = new Rectangle(x1,y1,x2,y2);

            Console.WriteLine("Yours rectangle perimeter: " + myRectangle.getPerimeter().ToString());
            Console.WriteLine("Yours rectangle square: " + myRectangle.getSquare().ToString());

            Console.WriteLine("----------------------TASK 2-------------------");

            Console.Write("Input X coordinate of top left point: ");
            x1 = Double.Parse(Console.ReadLine());
            Console.Write("Input Y coordinate of top left point: ");
            y1 = Double.Parse(Console.ReadLine());
            Console.Write("Input X coordinate of bottom right point: ");
            x2 = Double.Parse(Console.ReadLine());
            Console.Write("Input Y coordinate of bottom right point: ");
            y2 = Double.Parse(Console.ReadLine());

            var myRect = new RectangleWithAutoProps { TopLeftPoint = new Point(x1, y1), BottomRightPoint = new Point(x2, y2) };

            Console.WriteLine("Yours rectangle perimeter: " + myRect.getPerimeter().ToString());
            Console.WriteLine("Yours rectangle square: " + myRect.getSquare().ToString());

            Console.WriteLine("----------------------TASK 3-------------------");

            Console.Write("Input circle's radius: ");
            radius = Double.Parse(Console.ReadLine());

            Circle myCircle= new Circle(radius);

            Console.WriteLine("Circle's length: {0:F3}" , myCircle.getLength(radius));
            Console.WriteLine("Circle's square: {0:F3}" , myCircle.getSquare(radius));

            Console.WriteLine("----------------------TASK 4-------------------");

            Console.Write("Input X coordinate of top left point: ");
            x1 = Double.Parse(Console.ReadLine());
            Console.Write("Input Y coordinate of top left point: ");
            y1 = Double.Parse(Console.ReadLine());
            Console.Write("Input X coordinate of bottom right point: ");
            x2 = Double.Parse(Console.ReadLine());
            Console.Write("Input Y coordinate of bottom right point: ");
            y2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Yours rectangle perimeter: " + Task4Rectangle.getPerimeter(new Point(x1,y1),new Point(x2,y2)).ToString());
            Console.WriteLine("Yours rectangle square: " + Task4Rectangle.getSquare(new Point(x1, y1), new Point(x2, y2)).ToString());

            Console.Write("Input circle's radius: ");
            radius = Double.Parse(Console.ReadLine());

            Console.WriteLine("Yours circle length: " + Task4Circle.getLength(radius).ToString());
            Console.WriteLine("Yours circle square: " + Task4Circle.getSquare(radius).ToString());

            Console.WriteLine("----------------------TASK 5-------------------");
            
            Console.Write("Input real part of complex number: ");
            a = Double.Parse(Console.ReadLine());

            Console.Write("Input virtual part of complex number: ");
            b = Double.Parse(Console.ReadLine());

            ComplexNumber complexNumber = new ComplexNumber(a,b);
            complexNumber.Print();

            Console.ReadLine();
        }
    }
}
