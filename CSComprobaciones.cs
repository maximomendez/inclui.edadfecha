using System;

namespace inclui.edadfecha
{
    public class CSComprobaciones
    {
        /// <summary>
        /// Funcion que solicitara fecha y si el año es a.C o d.C
        /// </summary>
        /// <param name="mensaje">Se le pasara que fecha tiene que introducir (Primera o Segunda)</param>
        /// <returns>Devolvera un struct con la fecha y un bool si es a.C o d.C</returns>
        public static DatosAnio.InformacionAnio SolicitarFecha(string mensaje)
        {
            DatosAnio.InformacionAnio fechaAnio = new DatosAnio.InformacionAnio();

            DateTime fecha = FechaCorrecta(mensaje);
            bool antesCristo = SolicitarAntesDespuesCristo();

            fechaAnio.fecha = fecha;
            fechaAnio.antesCristo = antesCristo;

            return fechaAnio;

        }
        /// <summary>
        /// Funcion que solicitara una fecha al usuario (No dejara de pedir hasta que no sea una fecha valida)
        /// <param name="mensaje">Se le pasara que fecha tiene que introducir (Primera o Segunda)</param>
        /// <returns>Devolera la fecha introducida por el usuario</returns>
        private static DateTime FechaCorrecta(string mensaje)
        {
            bool fechaBien = false;
            DateTime fechaValida = DateTime.Now;
            do
            {
                Console.WriteLine(mensaje);
                Console.Write("Introduzca una fecha válida (dd/mm/aaaa): ");
                string fecha = Console.ReadLine();

                if (fecha.Contains("/"))
                {
                    string[] fechaPosiciones = fecha.Split('/');

                    if (fechaPosiciones.Length == 3)
                    {
                        if (fechaPosiciones[2].Length == 4)
                        {
                            if (DateTime.TryParse(fecha, out fechaValida))
                            {
                                fechaBien = true;
                            }
                            else
                            {
                                Console.WriteLine("La fecha introducida no es correcta.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("El año tiene que tener 4 numeros o menos");
                        }

                    }
                    else
                    {
                        Console.WriteLine("La fecha tiene que tener tres campos");
                    }

                }
                else
                {
                    Console.WriteLine("La fecha tiene que estar dividida por /");
                }

                Continuar();

            } while (!fechaBien);

            return fechaValida;
        }

        /// <summary>
        /// Funcion que se encargara de pedir al usuario si la fecha es a.C o d.C
        /// </summary>
        /// <returns>Devolvera un bool true si es a.C o false si es d.C</returns>
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

            Continuar();

            return antesCristo;

        }

        /// <summary>
        /// Funcion que devolvera los años de diferencia entre las dos fechas
        /// (Depende de la opción elegida en el switch, la segunda fecha sera la actual)
        /// </summary>
        /// <param name="primeraFecha">Se le pasara la primera fecha puesta por el usuario</param>
        /// <param name="segundaFecha">Se le pasara la segunda fecha puesta por el usuario</param>
        /// <returns>Devolvera los años de diferencia</returns>
        public static int DevolverDiferenciaAnios(DatosAnio.InformacionAnio primeraFecha, DatosAnio.InformacionAnio segundaFecha)
        {


            /*
             * Si alguno de los dos años es antes de Cristo, 
             * se encargara de cacular los años desde el año antes de cristo 
             * hasta ese año despues de cristo, luego le sumara el resto de años normales
             * despues de cristo entre esos dos años
            */

            int anioPrimeraFecha = primeraFecha.fecha.Year;
            int anioSegundaFecha = segundaFecha.fecha.Year;
            int anioDiferencia = Math.Abs(anioSegundaFecha - anioPrimeraFecha);
            if (primeraFecha.antesCristo != segundaFecha.antesCristo)
            {
                if (primeraFecha.antesCristo)
                {
                    anioDiferencia += primeraFecha.fecha.Year * 2;
                }
                else
                {
                    anioDiferencia += segundaFecha.fecha.Year * 2;
                }
            }

            DateTime fechaNueva;
            int fechaDia;
            int fechaMes;
            int fechaAnio;

            /* Revisa si el primer o el segundo año es 29 de febrero
             * si es así, se le resta un día, por lo que la gente del 29
             * siempre va a cumplir el 28. Se revisa que las dos fechas no sean bisiestos
             * a la vez. Si no lo son, Se revisa si la primera o la segunda es anterior. Se comparan
             * ambas fechas y si el resultado es > 0 se resta un año. COMENTARIO PARA MAXI
             */
            if (segundaFecha.fecha.Month == 2 && segundaFecha.fecha.Day == 29)
            {
                 segundaFecha.fecha = segundaFecha.fecha.AddDays(-1);
            }

            if (primeraFecha.fecha.Month == 2 && primeraFecha.fecha.Day == 29)
            {
                primeraFecha.fecha = primeraFecha.fecha.AddDays(-1);
            }

            if (primeraFecha.fecha.Year != segundaFecha.fecha.Year)
            {
                if (primeraFecha.fecha.CompareTo(segundaFecha.fecha) < 0)
                {

                    fechaDia = segundaFecha.fecha.Day;
                    fechaMes = segundaFecha.fecha.Month;
                    fechaAnio = primeraFecha.fecha.Year;

                    fechaNueva = DateTime.Parse(fechaDia + "/" + fechaMes + "/" + fechaAnio);
                    if (primeraFecha.fecha.CompareTo(fechaNueva) > 0)
                    {
                        anioDiferencia--;
                    }
                }
                else
                {

                    fechaDia = primeraFecha.fecha.Day;
                    fechaMes = primeraFecha.fecha.Month;
                    fechaAnio = segundaFecha.fecha.Year;

                    fechaNueva = DateTime.Parse(fechaDia + "/" + fechaMes + "/" + fechaAnio);

                    if (segundaFecha.fecha.CompareTo(fechaNueva) > 0)
                    {
                        anioDiferencia--;
                    }
                }
            }

            return anioDiferencia;

        }

        /// <summary>
        /// Funcion que devolvera los dias de diferencia entre las dos fechas 
        /// (Depende de la opción elegida en el switch, la segunda fecha sera la actual)
        /// </summary>
        /// <param name="primeraFecha">Se le pasara la primera fecha puesta por el usuario</param>
        /// <param name="segundaFecha">Se le pasara la segunda fecha puesta por el usuario</param>
        /// <returns>Devolvera los dias de diferencia</returns>
        public static int DevolverDiferenciaDias(DatosAnio.InformacionAnio primeraFecha, DatosAnio.InformacionAnio segundaFecha)
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


        /// <summary>
        /// Fucion la cual usaremos para cada vez que hagamos un paso limpiar pantalla
        /// </summary>
        public static void Continuar()
        {
            Console.WriteLine("Introduzca una tecla para continuar.");
            Console.ReadKey(true);
            Console.Clear();
        }

    }
}

