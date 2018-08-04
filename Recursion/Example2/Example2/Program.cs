using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        public static int CountDivisions(double number)
        {
            int count = 0;

            if(number % 2 == 0)
            {
                count++;
                number /= 2;

                return count += CountDivisions(number);
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            int count = CountDivisions(number);
            Console.WriteLine($"Total number of divisions: {count}");

            Console.ReadKey();
        }
    }
}
