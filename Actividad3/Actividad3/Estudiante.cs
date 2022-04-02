using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3
{
    internal class Estudiante
    {

        protected int matricula;
        protected string nombre;
        protected int edad;
        protected string password;
        protected double CoutaEscolar;

        public Estudiante()
        {
            CoutaEscolar = 2000;
        }

        public Estudiante(int matricula, string nombre, int edad, double CoutaEscolar)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            asignarEdad(edad);
            asignarPassword();
            this.CoutaEscolar = CoutaEscolar;
            
        }

        public void asignarEdad(int edad)
        {
            
                if (edad >= 15 && edad <= 90)
                {
                    
                    this.edad = edad;
                }else
                {
                Console.WriteLine("La edad de los estudiantes debe estar entre 15 y 90\n");
                }
                
            
        }

        public void asignarPassword()
        {
            var characters = "abcdefghijklmnopqrstuvwxyz0123456789";
            var Charsarr = new char[8];
            var random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }

            var resultString = new String(Charsarr);
            this.password = resultString;
        }

        public virtual void mostrarDatos()
        {
            Console.WriteLine("Matrícula: " + this.matricula);
            Console.WriteLine( "Nombre: "+this.nombre);
            Console.WriteLine( "Edad: "+this.edad);
            Console.WriteLine( "Password: "+this.password);
            Console.WriteLine("Couta escolar: " + this.CoutaEscolar);
        }

        public virtual void asignarBeca(int porcentaje)
        {
            double aux = porcentaje;
           
            this.CoutaEscolar = this.CoutaEscolar - (this.CoutaEscolar * (aux / 100));
            
        }

    }
}
