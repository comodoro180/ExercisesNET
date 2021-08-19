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
                    quantityNumbers++;
                    var input = Console.ReadLine();
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong number! ");
                    if (quantityNumbers != 0) quantityNumbers--;
                    //throw;
                }
            }
        }
    }
}
