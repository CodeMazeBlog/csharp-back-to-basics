using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        public static void ChangeAndWrite(int number)
        {
            number = 10;
            Console.WriteLine($"Inside ChangeAndWrite method, number value is: {number}");
        }
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine($"Value of the number prior to ChangeAndWrite call is: {number}");

            ChangeAndWrite(number);
            Console.WriteLine($"Value of the number after the ChangeAndWrite call is: {number}");

            Console.ReadKey();
        }
    }
}
