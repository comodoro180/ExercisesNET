/*
    12- Crea un programa que pida por consola un numero del 1 al 1000 (validara que el numero introducido es correcto) 
    y sume todos los números del 1 al numero introducido, mostrando por consola el numero de la suma y la media.
*/
using System;
using System.Text.RegularExpressions;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex regex = new Regex(@"^[0-9]+$");
            
            while (true)
            {
                //string numero = Console.ReadLine();
                //if (numero == "exit") break;

                //Match match = regex.Match(numero);
                //if (numero.Length == 0 || !match.Success )
                //{
                //    Console.WriteLine("Not a number");
                //    continue;
                //}
                //else
                //{
                //}
                Console.WriteLine("Please type a number between 1 and 1000");
                Console.WriteLine("(Type \"exit\" to finish)");
                string entrada = Console.ReadLine();
                if (entrada == "exit") break;

                try
                {
                    var numero = UInt16.Parse(entrada);
                    if (numero == 0 || numero > 1000)
                    {
                        Console.WriteLine("The number must be between 1 and 1000");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Correct number!");
                        long sum = 0;
                        for (int i = 1; i <= numero; i++)
                        {
                            sum += i;
                        }
                        var mean = sum / numero;
                        Console.WriteLine("Sum: " + sum + " Mean: " + mean);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }
    }
}
