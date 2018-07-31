using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3ReferentType
{
    class Program
    {
        public static void ChangeColor(Pen pen)
        {
            pen.Color = Color.Green;
            Console.WriteLine($"Inside the ChangeColor method the color is {pen.Color}");
        }

        public static void CreateNewObjectWithoutRef(Pen pen)
        {
            pen = new Pen(Color.Red);
            Console.WriteLine($"Inside the CreateNewObjectWithoutRef method the color of new pen object is {pen.Color}");
        }

        public static void CreateNewObjectWithRef(ref Pen pen)
        {
            pen = new Pen(Color.Yellow);
            Console.WriteLine($"Inside the CreateNewObjectWithRef method the color of new pen object is {pen.Color}");
        }

        static void Main(string[] args)
        {
            Pen pen = new Pen(Color.Blue);

            Console.WriteLine($"Before ChangeColor method: {pen.Color}");
            ChangeColor(pen);
            Console.WriteLine($"After the ChangeColor method: {pen.Color}");

            Console.WriteLine();

            Console.WriteLine($"Before CreateNewObjectWithoutRef method: {pen.Color}");
            CreateNewObjectWithoutRef(pen);
            Console.WriteLine($"After CreateNewObjectWithoutRef method: {pen.Color}");

            Console.WriteLine();

            Console.WriteLine($"Before CreateNewObjectWithRef method: {pen.Color}");
            CreateNewObjectWithRef(ref pen);
            Console.WriteLine($"After CreateNewObjectWithRef method: {pen.Color}");

            Console.ReadKey();
        }
    }
}
