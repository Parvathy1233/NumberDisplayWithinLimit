using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDisplayWithinLimit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Enter The Limit:");
                int limit = Convert.ToInt32(Console.ReadLine());
                Console.Write("Skip:");
                string skipped = Console.ReadLine();
                Console.WriteLine("Output");
                string[] skippedArray = skipped.Split(',');
                int[] skip = new int[skippedArray.Length];
                for (int i = 0; i < skippedArray.Length; i++)
                {
                    skip[i] = int.Parse(skippedArray[i]);
                }
                for (int i = 1; i <= limit; i++)
                {
                    if (Array.IndexOf(skip, i) == -1)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
