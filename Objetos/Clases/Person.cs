using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Clases
{
    //clase es una plantilla que contiene objetos y metodos
    public class Person
    {
        //estas son propiedades y atributos
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Total { get; set; }

        public void Print()
        {
            Console.WriteLine("Tu numbre es: " + this.Name);
            Console.WriteLine("Tu numbre es: " + this.LastName);
            Console.WriteLine("Tu numbre es: " + this.Age);
            Console.WriteLine("Tu numbre es: " + this.Total);
        }
        public void Request()
        {
            Console.Write("Ingresa tu nombre: ");
            Name = Console.ReadLine();
            Console.Write("Ingresa tu Apellido: ");
            LastName = Console.ReadLine();
            Console.Write("Ingresa tu Edad: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Ingresa tu Salario: ");
            Total = double.Parse(Console.ReadLine());
        }
    }
}
