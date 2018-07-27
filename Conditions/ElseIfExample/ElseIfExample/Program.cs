using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseIfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your random string: ");
            string sentence = Console.ReadLine();

            Console.WriteLine("Choose your color: r for Red, g for Green, o for Other");
            char color = Convert.ToChar(Console.ReadLine());

            if(color == 'r')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sentence);
            }
            else if(color == 'g')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(sentence);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(sentence);
            }

            Console.ReadKey();
        }
    }
}
