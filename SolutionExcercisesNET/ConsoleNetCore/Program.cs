using System;
using System.Collections.Generic;

namespace ConsoleNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Net Core");
            Console.Read();

            var listaPersonas = new List<Persona>();

            var persona1 = new Persona()
            {
                Apellido = "Hoyos",
                Nombre = "Carlos"
            };

            listaPersonas.Add(persona1);

            foreach (var persona in listaPersonas)
            {
                Console.WriteLine("Nombre: " + persona.Nombre);
                Console.WriteLine("Apellido: " + persona.Apellido);
            };

            Console.Read();
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
    }
}
