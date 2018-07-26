using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameLastNameSeparation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name, blank space separated");
            string fullName = Console.ReadLine();

            int blankPosition = fullName.IndexOf(' ');
            string name = fullName.Substring(0, blankPosition);
            string lastName = fullName.Substring(blankPosition + 1);

            Console.WriteLine(name);
            Console.WriteLine(lastName);

            Console.ReadKey();
        }
    }
}
