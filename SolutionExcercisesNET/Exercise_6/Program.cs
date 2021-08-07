/*
6- Crea un programa que este preguntando números por consola, hasta que se pulse el numero 0. 
Una vez pulsado el 0 se mostrara la siguiente información:

    numero mas alto, numero mas bajo, la diferencia entre el mayor y el menor, cantidad de números introducidos

Usa métodos y funciones y el bucle While para controlar que se introduce el numero 0.
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = -1;
            List<int> listNumbers = new List<int>();

            Console.WriteLine("Enter a number (0 for exit):");
            while (number != 0)
            {
                try 
                {
                    int typedNumber = int.Parse(Console.ReadLine());
                    number = typedNumber;
                    if (number != 0)
                    {
                        listNumbers.Add(number);
                    }
                } catch (Exception e)
                {
                    continue;
                }               
            }

            if (listNumbers.Count!=0) Calculate(listNumbers);

        }

        public static void Calculate (List<int> listNumbers)
        {
            Console.WriteLine("The numbers entered were :");
            foreach (int number in listNumbers)
            {
                Console.Write(number + ",");
            }

            //listNumbers.Sort();
            var min = listNumbers.Min();
            var max = listNumbers.Max();
            var count = listNumbers.Count();
            var diference = max - min;

            Console.WriteLine("\nTotal values: " + count);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Diference: " + diference);
        }
    }
}
