using System;

namespace inclui.edadfecha
{
    class CSComprobaciones
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


            /*
             * Se encargara de comprobar los dias que han pasado entre la primera fecha
             * y el final de esa fecha, y los dias que han pasado desde el principio
             * de la segunda fecha y el la fecha puesta, si la resta no da 365, no ha 
             * pasado un año
            */

            if (anioPrimeraFecha != anioSegundaFecha)
            {
                string fechaNueva = "";
                DateTime primerFechaDia;
                DateTime segundoFechaDia;

                if (anioPrimeraFecha < anioSegundaFecha)
                {
                    fechaNueva = "31/12/" + anioPrimeraFecha;
                    primerFechaDia = DateTime.Parse(fechaNueva);
                    fechaNueva = "1/1/" + anioSegundaFecha;
                    segundoFechaDia = DateTime.Parse(fechaNueva);
                }
                else
                {
                    fechaNueva = "31/12/" + anioSegundaFecha;
                    primerFechaDia = DateTime.Parse(fechaNueva);
                    fechaNueva = "1/1/" + anioPrimeraFecha;
                    segundoFechaDia = DateTime.Parse(fechaNueva);
                }
                int numDiasTotales = Math.Abs((int)(primeraFecha.fecha - primerFechaDia).TotalDays) + 1;
                numDiasTotales += Math.Abs((int)(segundaFecha.fecha - segundoFechaDia).TotalDays);


                /*
                 * Se encargara de restarle un año a los años de diferencia, si alguno de 
                 * de los años son bisiesto
                 * Si los dias totales son menor o igual a 365, ya que si el año es bisiesto 
                 * tiene que tener 366, para ser un año
                */



                //if (DateTime.IsLeapYear(anioPrimeraFecha) || DateTime.IsLeapYear(anioSegundaFecha))
                //{
                //    if (numDiasTotales<=365)
                //    {
                //        anioDiferencia--;
                //    }        
                //}
                //else
                //{
                if (numDiasTotales < 365)
                {
                    anioDiferencia--;
                }
                //}


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

