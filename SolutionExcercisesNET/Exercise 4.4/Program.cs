using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNumbers = 0;
            List<int> numberList = new List<int>();

            Console.WriteLine("Enter 10 numbers :");

            while (true)
            {
                if (quantityNumbers == 10) break;

                try
                {
                    var input = Console.ReadLine();
                    numberList.Add(Convert.ToInt32(input));
                    quantityNumbers++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong number!");
                    //if (quantityNumbers > 0) quantityNumbers--;
                    //throw;
                }
            }

            Console.WriteLine("Max number: " + numberList.Max());
            Console.WriteLine("Min number: " + numberList.Min());
        }
    }
}
