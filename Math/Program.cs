using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    class Program
    {
       /* static void Main(string[] args)
        {
            double a = 4.0;
            double b = 5.0;
            double c = a+b;

            Console.WriteLine("Hellow World!");
            //Console.WriteLine(Math.Round(c*1.0,2));
            //Console.WriteLine(Math.Round(5.46,4));
            Console.WriteLine("{0:0.00}", c);
            Console.ReadLine();
        }*/
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            double num = 64354.00;
            int fibonacciSeq = 10;
            int checkPrime = 5;
            int printPrime = 4;
            int factor = 6;
            double radius = 10;

            //NumSwap variables
            int a, b, c, d;
            a = c = 5;
            b = d = 10;

            Console.WriteLine("Default format: " + num);

            Console.WriteLine("Value with two decimal places: {0:#.##}", num.ToString());

            Console.WriteLine(Fibonacci(fibonacciSeq));

            Console.WriteLine("Is input value prime: "+IsPrime(checkPrime));

            Console.WriteLine("Print prime values: "+PrimePrint(printPrime));

            Console.WriteLine("Area of Circle = "+Shapes.Circle(radius));

            Console.WriteLine("Factorial of " + factor + ": " + Factorial(factor));

            //NumSwap using value parameters
            Console.WriteLine("\nInitial A = " + a + ", Initial B = " + b);
            NumSwapValueParam(a, b);
            Console.WriteLine("Modified A = " + a + ", Modified B = " + b);

            //NumSwap using reference parameters
            Console.WriteLine("\nInitial C = " + c + ", Initial D = " + d);
            NumSwapRefParam(ref c, ref d);
            Console.WriteLine("Modified C = " + c + ", Modified D = " + d);

            //NumSwap using output parameters
            int x = 3;
            int y = 2048;
            Console.WriteLine("\nOld Value: " + x);
            NumSwapOutParam(y, out x);
            Console.WriteLine("New Value: " + x);

            //Nullable types
            int? z1 = null; //Declaration and initialization of nullable type
            Console.WriteLine("\n"+CheckNullInt(z1));

            string z2 = null;
            Console.WriteLine(CheckNullString(z2));

            Console.ReadKey();
        }

        public static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
        public static string Fibonacci(int val)
        {
            int i = 0;
            int j = 1;
            string strFib = "";

            for (int x=0;x<val;x++)
            {
                int k = i + j;
                strFib += k + " ";
                i = j;
                j = k;
            }
            return strFib;
        }
        public static string PrimePrint(int num)
        {
            string strPrime = "";

            int i = 1;
            int j = 1;
            while (j <= num)
            {
                if (j == num)
                {
                    strPrime += "skip";
                    j++;
                }
                else if (IsPrime(i))
                {
                    strPrime += "skip, ";
                    j++;
                } else
                {
                    strPrime += Convert.ToString(i) + ", ";
                }
                
                i++;
            }
            return strPrime;

        }
        public static int Factorial(int factor)
        {
            int result;
            if (factor == 1)
            {
                return 1;
            }
            else
            {
                //Recursion shown below
                result = Factorial(factor - 1) * factor;
                return result;
            }
        }
        public static void NumSwapValueParam(int x, int y)
        {
            int temp;

            temp = x; /* save the value of x */
            x = y;    /* put y into x */
            y = temp; /* put temp into y */
        }
        public static void NumSwapRefParam(ref int x, ref int y)
        {
            int temp;

            temp = x; /* save the value of x */
            x = y;    /* put y into x */
            y = temp; /* put temp into y */
        }
        public static void NumSwapOutParam(int y, out int x)
        {
            x = y;
        }
        public static int CheckNullInt(int? z)
        {
            //Checks if int is null or not. If it is, assign value 2048.
            int val = z ?? 2048;
            return val;
        }
        public static string CheckNullString(string z)
        {
            //Checks if string is null or not.
            string val = z ?? "String is null";
            return val;
        }
    }
    class Shapes
    {
        private const double PI = Math.PI; //Initializing constant value

        public static double Circle(double r)
        {
            double area = PI * Math.Pow(r,2);
            return area;
        }
    }
}
