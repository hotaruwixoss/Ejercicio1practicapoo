using System;

namespace Practica_de_herencias_y_constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona person1 = new Persona();

            person1.Nombre = "";
            person1.Apellido = "";
            person1.Edad = 19;
            person1.Cedula = 123456;
            person1.responsabilidad();

            Profesor Profe1 = new Profesor();

            Profe1.Sueldo = 34456;
            Profe1.imprimir();

        
        }
    }


    class Persona
    {
        private double cedula;
        private string nombre;
        private string apellido;
        private int edad;

        public double Cedula
        {
            set
            { cedula = value; }
            
            get { return cedula; }
        }
        
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }

        public int Edad
        {
            set { edad = value; }
            get { return edad; }
        }

        public void responsabilidad()
        {
            
            Console.WriteLine(Cedula);
            Console.WriteLine(Nombre);
            Console.WriteLine(Apellido);
            Console.WriteLine(Edad);
            
        }

    }

    class Profesor: Persona
    {
        double sueldo;

        public double Sueldo
        {
            set { sueldo = value; }
            get { return sueldo; }
        }
        public void imprimir()
        {
            Console.WriteLine(Sueldo);
        }
    }
}
