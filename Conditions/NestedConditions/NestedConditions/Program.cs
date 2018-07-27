using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 50)
            {
                if(number % 2 == 0) //reminder in division with even numbers is always a zero.
                {
                    Console.WriteLine(number * 2);
                }
                else
                {
                    Console.WriteLine(number * 3);
                }
            }
            else
            {
                Console.WriteLine(number * 5);
            }

            Console.ReadKey();
        }
    }
}
