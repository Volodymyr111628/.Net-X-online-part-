using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TASK 1

            Console.WriteLine("---------------TASK 1----------------");

            Task1.Rectangle myRectangleTask1 = new Task1.Rectangle();
            Task1.Square mySquareTask1 = new Task1.Square();

            myRectangleTask1.Draw();
            mySquareTask1.Draw();

            #endregion

            #region TASK 2

            Console.WriteLine("---------------TASK 2----------------");

            double x = 10;
            double y = 15;

            Task2.Rectangle myRectangleTask2 = new Task2.Rectangle(x, y);
            Task2.Square mySquareTask2 = new Task2.Square(y, x);

            Console.WriteLine("Rectangle's X property: {0}", myRectangleTask2.X);
            Console.WriteLine("Rectangle's Y property: {0}", myRectangleTask2.Y);

            Console.WriteLine("Square's X property: {0}", mySquareTask2.X);
            Console.WriteLine("Square's Y property: {0}", mySquareTask2.Y);

            #endregion

            #region TASK 3

            Console.WriteLine("---------------TASK 3----------------");

            Task3.Figure myFigureTask3 = new Task3.Figure();
            Task3.Rectangle myRectangleTask3 = new Task3.Rectangle();
            Task3.Square mySquareTask3 = new Task3.Square();

            Console.Write("Figure's Draw function's output: ");
            myFigureTask3.Draw();
            Console.Write("Rectangle's Draw function's output: ");
            myRectangleTask3.Draw();
            Console.Write("Square's Draw function's output: ");
            mySquareTask3.Draw();

            #endregion

            #region TASK 4

            Console.WriteLine("---------------TASK 4----------------");

            Task4.Figure myFigureTask4 = new Task4.Figure();
            Task4.Rectangle myRectangleTask4 = new Task4.Rectangle();
            Task4.Square mySquareTask4 = new Task4.Square();

            DrawAll(myRectangleTask4, mySquareTask4, myFigureTask4);

            #endregion

            Console.ReadLine();
        }
        static void DrawAll(params Task4.IDrawable[] array)
        {
            foreach (var item in array)
            {
                item.Draw();
            }
        }
    }
}
