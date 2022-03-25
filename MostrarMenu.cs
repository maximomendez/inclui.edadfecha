using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclui.edadfecha
{
    class MostrarMenu
    {
        public static void Menu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("         Seleccione tecla               ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1-Introducir Fechas");
            Console.WriteLine("2-Calcular la edad de la primera fecha, frente a la fecha actual en años");
            Console.WriteLine("3-Calcular la edad de la primera fecha, frente a la fecha actual en días");
            Console.WriteLine("4-Calcular la edad de la segunda fecha, frente a la fecha actual en años");
            Console.WriteLine("5-Calcular la edad de la segunda fecha, frente a la fecha actual en dias");
            Console.WriteLine("6-Calcular la diferencia entre las dos fechas, en años");
            Console.WriteLine("7-Calcular la diferencia entre las dos fechas, en dias");
            Console.WriteLine("8-Salir");
        }
    }
}
