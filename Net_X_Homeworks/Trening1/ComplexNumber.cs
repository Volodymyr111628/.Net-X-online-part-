using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening1
{
    public class ComplexNumber
    {
        #region Fields

        private double a;
        private double b;

        #endregion

        #region Constructors

        public ComplexNumber()
        {
            a = 0;
            b = 0;
        }

        public ComplexNumber(double _a, double _b)
        {
            a = _a;
            b = _b;
        }

        #endregion

        #region Methods

        public static ComplexNumber getReversal(ComplexNumber number)
        {
            ComplexNumber result = new ComplexNumber(number.getA(), number.getB() * (-1));
            return result;
        }

        public void Print()
        {
            if (b == 0)
                Console.WriteLine("Your nuumber is real: " + a.ToString());
            else
                Console.WriteLine("Your complex number is: " + a.ToString() + " + " + b.ToString() + "*i");
        }

        public double getA()
        {
            return a;
        }

        public void setA(double _a)
        {
            this.a = _a;
        }

        public double getB()
        {
            return b;
        }

        public void setB(double _b)
        {
            this.b = _b;
        }

        #endregion

        #region Operator's overloads

        public static ComplexNumber operator *(ComplexNumber first, ComplexNumber second)
        {
            ComplexNumber number = new ComplexNumber();

            number.setA(first.getA() * second.getA() - first.getB() * second.getB());
            number.setB(first.getA() * second.getB() + second.getA() * first.getB());

            return number;
        }

        public static ComplexNumber operator /(ComplexNumber numerator, ComplexNumber denominator)
        {
            ComplexNumber number = new ComplexNumber();

            double divider = (denominator * getReversal(denominator)).getA();
            number = numerator * getReversal(denominator);
            number.setA(number.getA() / divider);
            number.setB(number.getB() / divider);

            return number;
        }

        #endregion
    }
}
