using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string input;
            Console.WriteLine("Enter 1st Number :");
            input = Console.ReadLine();  //waits for user to hit return
            num1 = Convert.ToInt32(input);
            Console.WriteLine("Enter 2nd Number :");
            input = Console.ReadLine();
            num2 = Convert.ToInt32(input);
            Console.WriteLine("Sum is : {0}", Sum(num1, num2));
            //{0} takes 1st argument and substitutes into string
            Console.WriteLine("Power of : {0}", Power(num1, num2));
            Console.ReadKey();  //waits for a key to press before ending
        }

        static int Sum(int x, int y)
        {
            return x + y;

        }
        static double Power(int x, int y)
        {
            return Math.Pow(x, y);
        }
    }
}
