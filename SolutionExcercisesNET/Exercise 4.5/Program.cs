using System;
using System.Collections;
using System.Collections.Generic;

/*
5- Usando Arrays, crea un programa que nos pida cuantos elementos tendrá el array, 
dependiendo de ese numero de elementos, nos ira pidiendo valores, que introduciremos 
en el array. una vez introducidos, nos pedirá un nuevo valor a insertar y la posición 
donde queremos insertarla en el array
*/

namespace Exercise_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Array size? :");
            int arraySize = getNumber();

            List<string> varList = new List<string>();

            Console.WriteLine("Enter values");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Position " + i + ": ");
                varList.Add(Console.ReadLine());
            }
            
            int position = 0;
            do
            {
                Console.Write("Enter position: ");
                position = getNumber();
                if (position > varList.Count) Console.WriteLine("Wrong position! array size = " + varList.Count);
            } while (position > varList.Count);

            Console.Write("Enter value: ");
            string input = Console.ReadLine();

            varList[position] = input;

            foreach (var item in varList)
            {
                Console.WriteLine("Values: " + item);
            }
        }

        public static int getNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    return int.Parse(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong number!");                 
                }
            }
        }
    }
}
