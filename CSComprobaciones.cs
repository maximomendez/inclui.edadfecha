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

            fechaAnio.fecha = fecha;
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

            } while (!fechaBien);

            return fechaValida;
        }

        private static bool SolicitarAntesDespuesCristo()
        {
            bool antesCristo = false;

            Console.WriteLine("Indique si el año es antes de cristo o despues");
            Console.WriteLine("Pulse 's' para a.C o 'n' para d.C");
            char Fecha = OpcionesMenu.LeerOpcionFecha();

            if (Fecha == 's')
            {
                antesCristo = true;
            }

            return antesCristo;

        }

        public static int ComprobarEdadFechas(DatosAnio.InformacionAnio primeraFecha, DatosAnio.InformacionAnio segundaFecha)
        {
            int anioPrimeraFecha = primeraFecha.fecha.Year;
            int anioSegundaFecha = segundaFecha.fecha.Year;
            int anioDiferencia = Math.Abs(anioSegundaFecha - anioPrimeraFecha);
            if (primeraFecha.antesCristo != segundaFecha.antesCristo)
            {
                if (primeraFecha.antesCristo)
                {
                    anioDiferencia += primeraFecha.fecha.Year*2;
                }
                else
                {
                    anioDiferencia += segundaFecha.fecha.Year*2;
                }
            }
            return anioDiferencia;
        }

        public static int DevolverDias(DatosAnio.InformacionAnio primeraFecha, DatosAnio.InformacionAnio segundaFecha)
        {
            int numeroDiasTotales = Math.Abs((int)(segundaFecha.fecha - primeraFecha.fecha).TotalDays);
            if (primeraFecha.antesCristo != segundaFecha.antesCristo)
            {
                DateTime primerAnio = new DateTime();
                if (primeraFecha.antesCristo)
                {
                    numeroDiasTotales += (int)((primeraFecha.fecha - primerAnio).TotalDays) * 2;
                }
                else
                {
                    numeroDiasTotales += (int)((segundaFecha.fecha - primerAnio).TotalDays) * 2;
                }
            }
            return numeroDiasTotales;
        }

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

