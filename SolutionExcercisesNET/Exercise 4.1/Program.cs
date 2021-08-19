using System;
using System.Collections;
/*
Crear un programa, que recorra con un bucle for del 1 al 1000, 
insertando en cada iteración el valor del numero en un ArrayList. 
Una vez acabe el proceso , recorreremos ese ArrayList mostrando en 
consola la suma de los números  , ejemplo: 1, 3, 6, 10.
*/

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new ArrayList();

            for (int i = 1; i <= 1000; i++)
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
