using System;
using System.Collections.Generic;

namespace FizzBuzzSimple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var outputList = new SortedDictionary<int, string[]>();

            var array = new string[2];
            array[0] = "fizz";
            array[1] = "";
            outputList.Add(3, array);
            var array2 = new string[2];
            array2[0] = "buzz";
            array2[1] = "";
            outputList.Add(5, array2);

            var array3 = new string[2];
            array3[0] = "";

            Console.Write("Enter a number (type a letter to stop): ");
            var n = Console.ReadLine();
            Console.WriteLine();
            array3[1] = n;

            var modSum = 0;
            foreach (var output in outputList)
            {
                var parsed = int.Parse(n);
                var f = parsed % output.Key;
                var ft = (int)Math.Ceiling(((decimal)f) / (f + 1));
                Console.Write(output.Value[ft]);
                modSum += ft;
            }

            var t = modSum / outputList.Count;
            Console.Write(array3[t]);

            n = Console.ReadLine();
        }
    }
}
