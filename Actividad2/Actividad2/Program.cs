using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            bool opc1 = false;

            int aux;
            int aux1=0;
            
            int[] retirosLista = new int[10];
            int[] billetesLista = new int[10];
            int[] monedasLista = new int[10];

            int retiros = 0;
            
            int i;
            

            do
            {
                Console.Clear();
                Console.WriteLine("************************** BANCO CDIS ***********************\n\n");
                Console.WriteLine("1. Ingresar la cantidad de retiros hechos por los usuarios.");
                Console.WriteLine("2. Revisar la cantidad entregada de billetes y monedas.");
                Console.WriteLine("\nIngresa la opción: ");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        opc1=true;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("¿Cuántos retiros se hicieron (máximo 10): ");
                            retiros = int.Parse(Console.ReadLine());
                            
                            if(retiros <= 10 && retiros >0)
                            {
                                aux1 = 1;
                            }
                        }while(aux1 == 0);
                        
                        for(i = 0; i < retiros; i++)
                        {
                            do
                            {
                                aux = 0;
                                Console.WriteLine("Ingresa la cantidad del retiro " + (i + 1));
                                int retiroIng = int.Parse(Console.ReadLine());
                                if(retiroIng <= 50000 && retiroIng >0 )
                                {
                                    aux = 1;
                                    retirosLista[i] = retiroIng;
                                }
                                else
                                {
                                    Console.WriteLine("La cantidad del retiro debe ser mayor a 0 y menor a 50,000");
                                }
                            }while(aux == 0);
                            
                        }

                        int billetes, monedas;

                        for (i = 0; i < retirosLista.Length; i++)
                        {
                            int dinero = retirosLista[i];
                            billetes = 0;
                            monedas = 0;

                            while (dinero >= 500)
                            {
                                dinero = dinero - 500;
                                billetes++;
                            }
                            while (dinero >= 200)
                            {
                                dinero = dinero - 200;
                                billetes++;
                            }
                            while (dinero >= 100)
                            {
                                dinero = dinero - 100;
                                billetes++;
                            }
                            while (dinero >= 50)
                            {
                                dinero = dinero - 50;
                                billetes++;
                            }
                            while (dinero >= 20)
                            {
                                dinero = dinero - 20;
                                billetes++;
                            }
                            while (dinero >= 10)
                            {
                                dinero = dinero - 10;
                                monedas++;
                            }
                            while (dinero >= 5)
                            {
                                dinero = dinero - 5;
                                monedas++;
                            }
                            while (dinero >= 1)
                            {
                                dinero = dinero - 1;
                                monedas++;
                            }

                            billetesLista[i] = billetes;
                            monedasLista[i] = monedas;

                        }

                        break;

                    case 2:
                        Console.Clear();
                        if(!opc1)
                        {
                            Console.WriteLine("Se debe primero completar la opción 1");
                            Console.WriteLine("\nPresione 'enter' para continuar ...");
                            Console.ReadLine();
                            break;
                        }
                        for(i = 0;i < retiros;i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Retiro #" + (i + 1) + ": "+ retirosLista[i]+"$");
                            Console.WriteLine("Billetes entregados: " + billetesLista[i]);
                            Console.WriteLine("Mondeas entregadas: " + monedasLista[i]);
                        }

                        Console.WriteLine("\nPresione 'enter' para continuar ...");
                        Console.ReadLine();
                        break;
                }
            }while (x);
            


            Console.ReadLine();
        }
    }
}
