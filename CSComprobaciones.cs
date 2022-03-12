using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclui.edadfecha
{
    class CSComprobaciones
    {
        public static DateTime FechaCorrecta()
        {
            bool fechaBien = false;
            DateTime fechaValida;
            do
            {
                Console.Write("Introduzca una fecha válida (dd/mm/aaaa): ");
                if (DateTime.TryParse(Console.ReadLine(), out fechaValida))
                {
                    if (fechaValida < DateTime.Today)
                    {
                        fechaBien = true;
                    }
                    else
                    {
                        Console.WriteLine("Introduzca una fecha menor a la fecha actual.");
                    }

                }
                else
                {
                    Console.WriteLine("La fecha introducida no es correcta.");
                }

                continuar();

            } while (!fechaBien);

            return fechaValida;
        }

        //public static int DevolverDias(DateTime fechaComprobar)
        //{
        //    int numeroDiasTotales = (int)(DateTime.Today - fechaComprobar).TotalDays;
        //    return numeroDiasTotales;
        //}

        public static bool AnoBisiesto(int anio)
        {
            bool bisiesto = false;

            if (anio % 400 == 0)
            {
                bisiesto = true;
            }
            else
            {
                if (anio % 4 == 0)
                {
                    if (anio % 100 != 0)
                    {
                        bisiesto = true;
                    }
                }
            }

            return bisiesto;
        }


        public static void continuar()
        {
            Console.WriteLine("Introduzca una tecla para continuar.");
            Console.ReadKey(true);
            Console.Clear();
        }

        /*public static int DiferenciaFechas()
        {
        int numDiferencia = 0;
        if (DateTime.Compare(datoPrueba1, datoPrueba2) == 1)
        {
            Console.WriteLine((datoPrueba1 - datoPrueba2).TotalDays);
        }
        else
        {
            Console.WriteLine((datoPrueba2 - datoPrueba1).TotalDays);
        }
        return numDiferencia;
        }*/
    }
}

