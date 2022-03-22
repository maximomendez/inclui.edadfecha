using System;

namespace inclui.edadfecha
{
    class CSComprobaciones
    {
        public static DatosAnio.InformacionAnio SolicitarFecha(string mensaje)
        {
            DatosAnio.InformacionAnio fechaAnio = new DatosAnio.InformacionAnio();

            DateTime fecha = FechaCorrecta(mensaje);
            bool antesCristo = SolicitarAntesDespuesCristo();

            fechaAnio.fechaPrimera = fecha;
            fechaAnio.antesCristo = antesCristo;

            return fechaAnio;

        }
        private static DateTime FechaCorrecta(string mensaje)
        {
            bool fechaBien = false;
            DateTime fechaValida;
            do
            {
                Console.WriteLine(mensaje);
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

                Continuar();

            } while (!fechaBien);

            return fechaValida;
        }

        private static bool SolicitarAntesDespuesCristo()
        {
            bool antesCristo = false;

            char Fecha = OpcionesMenu.LeerOpcionFecha();

            if (Fecha == 's')
            {
                antesCristo = true;
            }

            return antesCristo;

        }

        public static int ComprobarEdadFechas(DateTime primeraFecha, DateTime segundaFecha)
        {
            int anioPrimeraFecha = primeraFecha.Year;
            int anioSegundaFecha = segundaFecha.Year;
            int anioDiferencia = anioSegundaFecha - anioPrimeraFecha;

            string puedafecha = segundaFecha.Day + "/" + segundaFecha.Month + "/" + anioPrimeraFecha;

            DateTime prueba = DateTime.Parse(puedafecha);

            return 0;
        }

        //public static int DevolverDias(DateTime fechaComprobar)
        //{
        //    int numeroDiasTotales = (int)(DateTime.Today - fechaComprobar).TotalDays;
        //    return numeroDiasTotales;
        //}

        public static void Continuar()
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

