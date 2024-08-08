using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07_08_2024
{
    public class Persona1
    {
        protected string nombre;
        /*Portected: Solo se puede adceder desde la clase que lo declara, en este caso, la clase Persona1*/
        protected int edad;
        public string definicion = "con el modificador de acceso publico puedo acceder desde cualquier parte del codigo";


        public Persona1(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public string Nombre
        {
            //get para recuperar un valor
            get { return nombre; }

            //ser para establecer un valor
            set { nombre = value; }

            //crear 2 atributos
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public void imprimirDatos()
        {
            Console.WriteLine($"Nombre_ {nombre} edad: {edad}");
        }

        public bool CalcularEdad()
        {
            if (edad >= 18)
            {
                return true;
            } return false;
        }
    }
}
