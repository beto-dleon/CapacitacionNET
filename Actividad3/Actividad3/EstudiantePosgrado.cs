using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3
{
    internal class EstudiantePosgrado: Estudiante
    {
        private int NivelSNI;

        public EstudiantePosgrado(): base()
        {
            NivelSNI = 0;
        }

        public EstudiantePosgrado(int matricula, string nombre, int edad, double CoutaEscolar, int NivelSNI): base(matricula, nombre, edad, CoutaEscolar)
        {
            comprobarNivelSNI(NivelSNI);
        }

        public void comprobarNivelSNI(int nivel)
        {
            if(nivel<= 3 && nivel>=0)
            {
                this.NivelSNI = nivel;
            }
            else
            {
                Console.WriteLine("El nivel de SNI de los estudiantes debe estar entre 0 y 3\n");
            }
        }

        public override void asignarBeca(int porcentaje)
        {
            base.asignarBeca(porcentaje);
            if((NivelSNI == 1) || (NivelSNI==2))
            {
                this.CoutaEscolar -= this.CoutaEscolar * (0.15);
            }

            if(NivelSNI==3)
            {
                this.CoutaEscolar -= this.CoutaEscolar * (0.30);
            }
        }

        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.WriteLine("Nivel SNI: " + this.NivelSNI);
        }


    }
}
