using System;

namespace Exercise_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNumbers = 0;
            Console.WriteLine("Enter 10 numbers: ");
            while (true)
            {
                try
                {
                    var input = Console.ReadLine();
                    quantityNumbers++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong number! ");                    
                    //throw;
                }
            }
        }
    }
}
