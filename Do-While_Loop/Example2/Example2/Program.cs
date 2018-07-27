using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the upper border number n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 2;
            int startingNumber = 4;

            do
            {
                sum += startingNumber;
                startingNumber += 2;
            }while (startingNumber <= n);

            Console.WriteLine($"Sum of all the even number to n is {sum}");
            Console.ReadKey();
        }
    }
}
