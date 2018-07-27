using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer n number:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the integer m number");
            int m = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            do
            {
                sum += n;
                n++;
            } while (n <= m);

            Console.WriteLine($"The sum from n to m is {sum}");
            Console.ReadKey();
        }
    }
}
