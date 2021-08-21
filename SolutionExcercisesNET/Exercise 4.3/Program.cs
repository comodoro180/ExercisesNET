using System;
using System.Collections.Generic;
/*
Pedir por pantalla 10 números, que iremos almacenando en un Listado (o 2 como prefiramos). 
Al terminar de introducir los números, tendremos que recorrer el/los listados, diciéndonos 
cuanto suman los pares y cuando los impares.
*/

namespace Exercise_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNumbers = 0;
            List<int> numberList = new List<int>();

            Console.WriteLine("Enter 10 numbers: ");
            while (true)
            {
                if (quantityNumbers == 10) break;
                try
                {
                    quantityNumbers++;
                    string input = Console.ReadLine();                    
                    numberList.Add(Convert.ToInt32(input));                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong number! ");
                    if (quantityNumbers != 0) quantityNumbers--;                    
                }
            }

            int oddSum = 0;
            int evenSum = 0;

            foreach (var number in numberList)
            {
                if (number%2 == 0) oddSum += number;
                else evenSum += number;
            }
            
            if (numberList.Count > 0)
            {
                Console.WriteLine("Sum of pairs: " + evenSum);
                Console.WriteLine("Sum of odds : " + oddSum);
            }
        }
    }
}
