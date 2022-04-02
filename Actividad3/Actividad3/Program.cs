using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante[] estudiantes;
            int numEst=0;

            int matricula=0;
            string nombre;
            int edad=0;
            double CoutaEstudiante=0;
            bool RealizaServicio=false;
            bool error = true;

            int i, tipoEst, servicio,pbeca=0,nivel=0;
            char beca;

            while (error)
            {
                try
                {
                    Console.WriteLine("Ingresar la cantidad de estudiantes: ");
                    numEst= int.Parse(Console.ReadLine());
                    error = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            error = true;

            estudiantes = new Estudiante[numEst];

            for(i=0;i<estudiantes.Length;i++)
            {
                while (error)
                {
                    try
                    {
                        Console.WriteLine("Ingrese matricula del estudiante " + (i + 1)+":");
                        matricula = int.Parse(Console.ReadLine());
                        error = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                error = true;

                Console.WriteLine("Ingresa nombre del estudiante "+(i+1)+":");
                nombre = Console.ReadLine();

                
                while (error)
                {
                    try
                    {
                        Console.WriteLine("Ingresa la edad del estudiante " + (i + 1) + ":");
                        edad= int.Parse(Console.ReadLine());
                        error= false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                error = true;

                
                while (error)
                {
                    try
                    {
                        Console.WriteLine("Ingresa la cuota escolar del estudiante "+(i+1)+":");
                        CoutaEstudiante = double.Parse(Console.ReadLine());
                        error = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                error = true;

                Console.WriteLine("El estudiante es de LICENCIATURA (0) o POSGRADO (1): ");
                tipoEst = int.Parse(Console.ReadLine());

                if(tipoEst==0)
                {
                    Console.WriteLine("Es estudiante realiza servicio social ( 1. para si, 2. para no): ");
                    servicio = int.Parse(Console.ReadLine());

                    if(servicio==1)
                    {
                        RealizaServicio = true;
                    }
                    
                    if(servicio==2)
                    {
                        RealizaServicio = false;
                    }

                    Console.WriteLine("Cuenta con beca (s/n): ");
                    beca = char.Parse(Console.ReadLine());
                    if(beca=='s' || beca=='S')
                    {
                        while (error)
                        {
                            try
                            {
                                Console.WriteLine("Ingrese el porcentaje de la beca (numero entero): ");
                                pbeca = int.Parse(Console.ReadLine());
                                error = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        error = true;
                        
                    }

                    EstudianteLicenciatura est1 = new EstudianteLicenciatura(matricula, nombre, edad, CoutaEstudiante, RealizaServicio);
                    estudiantes[i] = est1;
                    estudiantes[i].asignarBeca(pbeca);
                }

                if(tipoEst==1)
                {
                    while (error)
                    {
                        try
                        {
                            Console.WriteLine("Ingresa Nivel SNI del estudiante: ");
                            nivel = int.Parse(Console.ReadLine());
                            error=false;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    error = true;
                    

                    Console.WriteLine("Cuenta con beca (s/n): ");
                    beca = char.Parse(Console.ReadLine());
                    if (beca == 's' || beca == 'S')
                    {
                        while (error)
                        {
                            try
                            {
                                Console.WriteLine("Ingrese el porcentaje de la beca (numero entero): ");
                                pbeca = int.Parse(Console.ReadLine());
                                error = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        error = true;
                        
                    }

                    EstudiantePosgrado est2 = new EstudiantePosgrado(matricula, nombre, edad, CoutaEstudiante, nivel);
                    estudiantes[i] = est2;
                    estudiantes[i].asignarBeca(pbeca);
                }

                Console.WriteLine("\n");
            }

            for(i=0; i<estudiantes.Length; i++)
            {
                Console.WriteLine("Estudiante " + (i + 1));
                estudiantes[i].mostrarDatos();
                Console.WriteLine("\n");

            }

            Console.ReadLine();
        }
    }
}
