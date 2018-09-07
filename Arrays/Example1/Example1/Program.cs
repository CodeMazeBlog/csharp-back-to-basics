using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        //array is a reference type so every action in this method will affect original array
        public static void PopulateArray(int[] numbers)
        {
            Random r = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(1, 101);
                Console.WriteLine($"The {i+1}. element is {numbers[i]}");
            }
        }

        public static void CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of all the elements is {sum}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array capacity: ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[capacity];

            PopulateArray(numbers);
            Console.WriteLine();
            CalculateSum(numbers);

            Console.ReadKey();
        }
    }
}
