using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;
            int x = 0;
            do
            {
                Console.WriteLine("Ingrese la altura de la piramide: ");
                int altura = int.Parse(Console.ReadLine());
                if(altura<=25 && altura>=0)
                {
                    x = 1;
                    for(int i = 0; i< altura; i++)
                    {
                        int j = 0;
                
                        while(j < altura)
                        {
                            if(j >= altura-1-aux)
                            {
                                Console.Write("#");
                            }

                            if(j < altura-1)
                            {
                                Console.Write(" ");

                            }
                            j++;
                    
                        }
                        aux++;
                        Console.WriteLine("\n");
                    }
                }
                
            }while(x==0);
            
            Console.ReadLine();
        }
    }
}
