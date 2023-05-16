using Objetos.Clases;
using System;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Persona 1
            Person person = new Person();
            person.Name = "David";
            person.LastName = "Peña";
            person.Age = 22;
            person.Total = 9999.99;

            person.Print();
            #endregion
            Console.WriteLine("---------------");
            #region Persona 2
            Person person2 = new Person();
            person2.Request();
            Console.Clear();
            Console.Write("Persona 1");
            person.Print();
            Console.WriteLine("---------------");
            Console.Write("Persona 2");
            person2.Print();
            #endregion
        }
    }
}
