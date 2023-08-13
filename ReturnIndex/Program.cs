using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 25, 5, 30, 15 };
            int target = 30;
            int foundIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex != -1)
            {
                Console.WriteLine("Target value found at index: " + foundIndex);
            }
            else
            {
                Console.WriteLine("Target value not found in the array.");
            }
            Console.ReadLine();
        }
    }
}
