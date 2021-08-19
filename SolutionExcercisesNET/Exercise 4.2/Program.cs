using System;
using System.Collections.Generic;
/*
Pedir por pantalla 5 nombres, e insertarlo en una Lista (List) una vez insertados, 
se pedirá que introduzcamos un nombre, el programa tendrá que decirnos, si ese 
nombre esta contenido en la lista.
*/

namespace Exercise_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = new List<string>();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter a name: ");
                namesList.Add(Console.ReadLine());
            }

            Console.WriteLine("Enter a word for search:");
            string nameToFind = Console.ReadLine();
            if (namesList.Contains(nameToFind)) Console.WriteLine("Name found!");
            else Console.WriteLine("Name not found!");
        }
    }
}
