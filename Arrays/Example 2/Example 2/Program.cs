using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Program
    {
        public static void PrintMin(params int[] numbers)
        {
            int min = numbers[0];
            for(int i=1; i < numbers.Length; i++)
            {
                if(min > numbers[i])
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine(min);
        }
        static void Main(string[] args)
        {
            PrintMin(49, 58, 12, 98, 47, 13);

            Console.ReadKey();
        }
    }
}
