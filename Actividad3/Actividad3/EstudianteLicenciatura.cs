using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3
{
    internal class EstudianteLicenciatura: Estudiante
    {
        private bool RealizaServicio;

        public EstudianteLicenciatura(): base()
        {
            RealizaServicio = false;
        }

        public EstudianteLicenciatura(int matricula, string nombre, int edad, double CoutaEscolar, bool RealizaServicio): base(matricula, nombre, edad, CoutaEscolar)
        {
            this.RealizaServicio = RealizaServicio;
        }

        public override void asignarBeca(int porcentaje)
        {
            base.asignarBeca(porcentaje);
          
            if(RealizaServicio)
            {
                
                this.CoutaEscolar = this.CoutaEscolar - (this.CoutaEscolar * (0.15));
               
            }
        }

        public override void mostrarDatos()
        {
            base.mostrarDatos();
            if(RealizaServicio)
            {
                Console.WriteLine("Realiza servicio social: si");
            }
            else
            {
                Console.WriteLine("Realiza servcio social: no");
            }
            
        }

    }
}
