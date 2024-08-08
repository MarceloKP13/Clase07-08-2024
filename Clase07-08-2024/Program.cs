using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07_08_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona1 persona1 = new Persona1("Marcelo", 22);

            persona1.Nombre = "Marcelo";
            string nombre = persona1.Nombre;
            Console.WriteLine(persona1.Nombre);

            Estudiante student = new Estudiante(8,3, "Marcelo", 20);

            student.saludar();
            student.imprimirDatos();

            Console.ReadKey();
        }
    }
}
