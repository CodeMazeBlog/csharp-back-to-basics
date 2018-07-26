using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "this is some string to use it for our example.";

            //Substring
            string partWithoutLength = testString.Substring(13);
            string partWithLength = testString.Substring(5, 14);

            Console.WriteLine(partWithoutLength);
            Console.WriteLine(partWithLength);

            //IndexOf
            int charPosition = testString.IndexOf('i');
            int stringPosition = testString.IndexOf("some");
            int charPosWithStartIndex = testString.IndexOf('s', 10);
            int stringPosWithStartIndex = testString.IndexOf("some", 10);

            Console.WriteLine(charPosition);
            Console.WriteLine(stringPosition);
            Console.WriteLine(charPosWithStartIndex);
            Console.WriteLine(stringPosWithStartIndex);

            //LastIndexOf
            int lastPosition = testString.LastIndexOf('o');
            int stringLastPosition = testString.LastIndexOf("is");

            Console.WriteLine(lastPosition);
            Console.WriteLine(stringLastPosition);

            //Contains
            bool containsResult = testString.Contains("for");

            Console.WriteLine(containsResult);

            //StartsWith and EndsWith
            bool startsWithResult = testString.StartsWith("bad");
            bool endsWithResult = testString.EndsWith("example");

            Console.WriteLine(startsWithResult);
            Console.WriteLine(endsWithResult);

            //Remove
            string loweredString = testString.Remove(10);
            string loweredStringWithCount = testString.Remove(10, 9);

            Console.WriteLine(loweredString);
            Console.WriteLine(loweredStringWithCount);

            string stringWithInsert = testString.Insert(13, "UPDATED ");

            Console.WriteLine(stringWithInsert);

            string lowerCaseString = testString.ToLower();

            Console.WriteLine(lowerCaseString);

            string upperCaseString = testString.ToUpper();

            Console.WriteLine(upperCaseString);

            Console.ReadKey();
        }
    }
}
