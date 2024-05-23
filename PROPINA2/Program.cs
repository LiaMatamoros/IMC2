using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPINA2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...........................................................................");
            Console.WriteLine("|             *-*-*  Ingrese su total a pagar.  *-*-*                     |");
            Console.WriteLine("...........................................................................");

            double pago = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("====================================================");
            Console.WriteLine("|   //           Desea dejar propina            // |");
            Console.WriteLine("====================================================");
            Console.WriteLine("*                                                  *");
            Console.WriteLine("|   1. siii  :)                                    |");
            Console.WriteLine("*                                                  *");
            Console.WriteLine("|   2. Nouu  :(                                    |");
            Console.WriteLine("*                                                  *");
            Console.WriteLine("====================================================");


            byte siono = Convert.ToByte(Console.ReadLine());
            switch (siono)
            {
                case 1:
                    Console.WriteLine("...........................................................................");
                    Console.WriteLine("|           Cuanto porcentaje de propina quiere dejarnos?                 |");
                    Console.WriteLine("...........................................................................");

                    double propina = Convert.ToDouble(Console.ReadLine());
                    double totalpropina = pago * (propina / 100); Console.WriteLine();
                    double totalpagar = totalpropina + pago;


                    Console.WriteLine("Su total es de " + pago + " con una propina de " + totalpropina + ".");
                    Console.WriteLine("====================================================");
                    Console.WriteLine("TOTAL>>" + totalpagar); break;
                    Console.WriteLine("====================================================");
                case 2:
                    Console.WriteLine("====================================================");
                    Console.WriteLine("TOTAL>>" + pago);
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Gracias por venir, lo esperamos de nuevo!");
                    break;
                    Console.WriteLine("====================================================");
                default:
                    Console.WriteLine("Opcion no valida"); 
                    break;

            }
            Console.ReadLine();
        }
    }
}



        