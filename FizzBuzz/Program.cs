using System;
using System.Collections.Generic;

namespace FizzBuzz
{
   public class Program
    {
        public static void Main(string[] args)
        {
            var outputList = new SortedDictionary<int, string[]>();

            Console.Write("Enter a divisor (type a letter to stop): ");
            var d = Console.ReadLine();
            while (int.TryParse(d, out int div))
            {
                Console.Write("What should be the output for that divisor? ");
                var o = Console.ReadLine();

                var array = new string[2];
                array[0] = o;
                array[1] = "";
                outputList.Add(div, array);

                Console.Write("Enter a divisor (type 'n' to stop): ");
                d = Console.ReadLine();
            }
            Console.Write("What should be the default output (type 's' for the number typed in)? ");
            var def = Console.ReadLine();

            var array3 = new string[2];
            array3[0] = "";
            if (def != "s")
            {
                array3[1] = def;
            }

            Console.Write("Enter a number (type a letter to stop): ");
            var n = Console.ReadLine();
            while (int.TryParse(n, out int parsed))
            {
                Console.WriteLine();
                if (def == "s")
                {
                    array3[1] = n;
                }

                var modSum = 0;

                foreach(var output in outputList)
                {
                    // TODO
                    var f = parsed % output.Key;
                    var ft = (int)Math.Ceiling(((decimal)f) / (f + 1));
                    Console.Write(output.Value[ft]);

                    modSum += ft;
                }

                var t = modSum / outputList.Count;
                Console.Write(array3[t]);

                Console.WriteLine("\n\nEnter a number (type a letter to stop): ");
                n = Console.ReadLine();
            }
        }
    }
}
