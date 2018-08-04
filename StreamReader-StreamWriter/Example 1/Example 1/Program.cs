using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Example_1
{
    class Program
    {
        public static void WriteToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            Random r = new Random(); //class to generate random numbers
            for(int i = 1; i <= 5; i++)
            {
                sw.WriteLine(r.Next(1,101));
            }

            sw.Close();
        }

        public static void PrintNumbersAndMax(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
                int max = Convert.ToInt32(line);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);

                    int temp = Convert.ToInt32(line);
                    if (temp > max)
                    {
                        max = temp;
                    }
                }

                Console.WriteLine($"Max number is: {max}");
            }
        }

        static void Main(string[] args)
        {
            WriteToFile("numbers.txt");

            PrintNumbersAndMax("numbers.txt");

            Console.ReadLine();
        }
    }
}
