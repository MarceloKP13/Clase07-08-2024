using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07_08_2024
{
    internal class Estudiante:Persona1
    {
        /*La clases estudiante es la clase hija o subclase
         Persona1 es la clase base o superclase o calse padre*/
        public int creditos;
        public int nivelSemestre;

        public Estudiante (int creditos, int nivelSemestre, string nombre, int edad) : base (nombre, edad)
        {
            this.creditos = creditos;
            this.nivelSemestre = nivelSemestre;
        }
        public void imprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre} edad: {edad}");
            Console.WriteLine($"Creditos: {creditos} Nivel de Semestre {nivelSemestre}");
        }
        public void saludar()
        {
            switch (nivelSemestre)
            {
                case 1:
                    Console.WriteLine($"Hola {nombre}, bienvenido a primer semestre.");
                    break;
                case 2:
                    Console.WriteLine($"Hola {nombre}, bienvenido a segundo semestre.");
                    break;
                case 3:
                    Console.WriteLine($"Hola {nombre}, bienvenido a tercer semestre.");
                    break;
                case 4:
                    Console.WriteLine($"Hola {nombre}, bienvenido a cuarto semestre.");
                    break;
                    default : Console.WriteLine($"Nivel de Semestre invalido");
                    break;
            }
        }
      

    }
}
