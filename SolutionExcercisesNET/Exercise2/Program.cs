/*
2- Escribir un programa que pida una palabra, y la escriba a su inversa , 
por ejemplo si se introduce Paris, devolverá "Sirap".
*/
using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word :");
            var word = Console.ReadLine();
            string inverseWord = "";
            for (int i = word.Length; i > 0 ; i--)
            {
                inverseWord += word.Substring(i-1,1);
            }
            Console.WriteLine("The inverse word is:" + inverseWord);
        }
    }
}
