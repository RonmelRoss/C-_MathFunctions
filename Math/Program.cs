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

            Console.WriteLine("Default format: " + num);

            Console.WriteLine("Value with two decimal places: " + "{0:#.##}", num);

            Console.WriteLine(Fibonacci(10));

            Console.WriteLine(IsPrime(1));

            Console.WriteLine(PrimePrint(7));

            Console.ReadLine();
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
            string strPrime = "1 ";

            int i = 1;
            int j = 1;
            while (j != num)
            {
                if (IsPrime(i))
                {
                    strPrime += Convert.ToString(i) + " ";
                    j++;
                }
                //strPrime += Convert.ToString(i)+" ";
                i++;
            }
            return strPrime;

        }
    }
}
