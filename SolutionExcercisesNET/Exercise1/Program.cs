using System;
using System.Collections;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new ArrayList();

            for (int i = 1; i <= 1000000; i++)
            {
                array.Add(i);
            }

            long sum = 0;
            for (int i = 0; i < array.Count; i++)
            {
                sum += (int)array[i];
                Console.WriteLine("Position: " + i + " Value: " + (int)array[i] + " Sum: " + sum);
            }

            //Console.WriteLine(sum);
        }
    }
}
