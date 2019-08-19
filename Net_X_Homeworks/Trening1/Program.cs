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
            string valid = "";

            #region TASK 1
            Console.WriteLine("----------------------TASK 1-------------------");

            Console.Write("Input X coordinate of top left point: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out x1))
                doubleValidator(ref valid);

            Console.Write("Input Y coordinate of top left point: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out y1))
                doubleValidator(ref valid);

            Console.Write("Input X coordinate of bottom right point: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out x2))
                doubleValidator(ref valid);

            Console.Write("Input Y coordinate of bottom right point: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out y2))
                doubleValidator(ref valid);

            Rectangle myRectangle = new Rectangle(x1, y1, x2, y2);

            Console.WriteLine("Yours rectangle perimeter: " + myRectangle.getPerimeter().ToString());
            Console.WriteLine("Yours rectangle square: " + myRectangle.getSquare().ToString());

            #endregion

            #region TASK 2

            Console.WriteLine("----------------------TASK 2-------------------");

            Console.Write("Input X coordinate of top left point: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out x1))
                doubleValidator(ref valid);

            Console.Write("Input Y coordinate of top left point: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out y1))
                doubleValidator(ref valid);

            Console.Write("Input X coordinate of bottom right point: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out x2))
                doubleValidator(ref valid);

            Console.Write("Input Y coordinate of bottom right point: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out y2))
                doubleValidator(ref valid);

            RectangleWithAutoProps myRect = new RectangleWithAutoProps(x1, y1, x2, y2);

            Console.WriteLine("Yours rectangle perimeter: " + myRect.RectanglePerimeter.ToString());
            Console.WriteLine("Yours rectangle square: " + myRect.RectangleSquare.ToString());

            #endregion

            #region TASK 3

            Console.WriteLine("----------------------TASK 3-------------------");

            Console.Write("Input circle's radius: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out radius))
                doubleValidator(ref valid);

            Circle myCircle = new Circle(radius);

            Console.WriteLine("Circle's length: {0:F3}", myCircle.getLength(radius));
            Console.WriteLine("Circle's square: {0:F3}", myCircle.getSquare(radius));

            #endregion

            #region TASK 4

            Console.WriteLine("----------------------TASK 4-------------------");

            Console.Write("Input X coordinate of top left point: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out x1))
                doubleValidator(ref valid);

            Console.Write("Input Y coordinate of top left point: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out y1))
                doubleValidator(ref valid);

            Console.Write("Input X coordinate of bottom right point: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out x2))
                doubleValidator(ref valid);

            Console.Write("Input Y coordinate of bottom right point: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out y2))
                doubleValidator(ref valid);

            Console.WriteLine("Yours rectangle perimeter: " + Task4Rectangle.getPerimeter(new Point(x1, y1), new Point(x2, y2)).ToString());
            Console.WriteLine("Yours rectangle square: " + Task4Rectangle.getSquare(new Point(x1, y1), new Point(x2, y2)).ToString());

            Console.Write("Input the circle's radius: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out radius))
                doubleValidator(ref valid);

            Console.WriteLine("Yours circle length: {0:F3}", Task4Circle.getLength(radius));
            Console.WriteLine("Yours circle square: {0:F3}", Task4Circle.getSquare(radius));

            #endregion

            #region TASK 5

            Console.WriteLine("----------------------TASK 5-------------------");

            Console.Write("Input the real part of complex number: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out a))
                doubleValidator(ref valid);

            Console.Write("Input the virtual part of complex number: ");
            valid = Console.ReadLine();
            while (!Double.TryParse(valid, out b))
                doubleValidator(ref valid);

            ComplexNumber complexNumber = new ComplexNumber(a, b);

            Console.Write("Your complex number: ");
            complexNumber.Print();

            ComplexNumber numerator = new ComplexNumber(-2, 1);
            ComplexNumber denominator = new ComplexNumber(1, -1);

            Console.Write("Numerator: ");
            numerator.Print();
            Console.Write("Denominator: ");
            denominator.Print();

            ComplexNumber resultOfDivision = numerator / denominator;

            Console.Write("Result of division: ");
            resultOfDivision.Print();

            ComplexNumber complexNumberToMult = new ComplexNumber(3, -2);
            ComplexNumber multiplier = new ComplexNumber(2, 5);

            ComplexNumber resultOfMultiplication = complexNumberToMult * multiplier;

            Console.Write("Complex number: ");
            complexNumberToMult.Print();
            Console.Write("Multiplier: ");
            multiplier.Print();

            Console.Write("Result of multiplication: ");
            resultOfMultiplication.Print();

            #endregion

            Console.ReadLine();
        }

        static void doubleValidator(ref string valid)
        {
            Console.Write("Value is not in appropriate format please input again:");
            valid = Console.ReadLine();
        }
    }
}
