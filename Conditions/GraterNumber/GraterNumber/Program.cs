using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            if(first > second)
            {
                Console.WriteLine($"The greater number is {first}");
            }
            else
            {
                Console.WriteLine($"The greater number is {second}");
            }

            Console.ReadKey();
        }
    }
}
