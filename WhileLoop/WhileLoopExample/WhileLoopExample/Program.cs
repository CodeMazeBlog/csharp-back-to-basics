using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopExample
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

            while(n <= m)
            {
                sum += n;
                n++;
            }

            Console.WriteLine($"Sum from n to me is {sum}");
            Console.ReadKey();
        }
    }
}
