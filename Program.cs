using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.Write("Escriba un numero del 1 al 7:");
            numero = Convert.ToInt32(Console.ReadLine());

            switch(numero)
            {
                case 1:
                    Console.WriteLine("Usted a seleccionado el Lunes");
                    break;
                case 2:
                    Console.WriteLine("Usted a seleccionado el Martes");
                    break;
                case 3:
                    Console.WriteLine("Usted a seleccionado el Miercoles");
                    break;

                case 4:
                    Console.WriteLine("Usted a seleccionado el Jueves");
                    break;
                case 5:
                    Console.WriteLine("Usted a seleccionado el Viernes");
                    break;
                case 6:
                    Console.WriteLine("Usted a seleccionado el Sabado");
                    break;
                case 7:
                    Console.WriteLine("Usted a seleccionado el Domingo");
                    break;
                default:
                    Console.WriteLine("El numero que escribio no es valido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
