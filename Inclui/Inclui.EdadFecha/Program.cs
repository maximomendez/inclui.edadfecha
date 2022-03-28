using System;

namespace inclui.edadfecha
{
    /// <summary>
    /// Clase inicial en la cual tendremos el menu y 
    /// las llamadas a las funciones del programa
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio();
            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio();
            DatosAnio.InformacionAnio fechaActual = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Today,
                antesCristo = false
            };

            int opcion;
            int diferenciaAnio;
            int diferenciaDias;
            bool leido = false;
            do
            {
                if (leido)
                {
                    MostrarMenu.Menu();
                    opcion = OpcionesMenu.LeerOpciones();
                }
                else
                {
                    opcion = 1;
                }
                switch (opcion)
                {
                    case 1:

                        try
                        {
                            primeraFecha = new DatosAnio.InformacionAnio
                            {
                                fecha = DateTime.Parse("2/4/5"),
                                antesCristo = false
                            };

                            primeraFecha = new DatosAnio.InformacionAnio
                            {
                                fecha = DateTime.Parse("2/3/20005"),
                                antesCristo = false
                            };
                            leido = true;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            opcion = 8;
                        }

                        //primeraFecha = CSComprobaciones.SolicitarFecha("Introduzca la primera fecha");
                        //segundaFecha = CSComprobaciones.SolicitarFecha("Introduzca la segunda fecha");
                        //leido = true;
                        break;
                    case 2:
                        diferenciaAnio = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, fechaActual);
                        if (diferenciaAnio != -1)
                        {
                            Console.WriteLine("La diferencia de años entre {0} y {1} es de {2} años", primeraFecha.fecha, fechaActual.fecha, diferenciaAnio);
                        }
                        else
                        {
                            opcion = 8;
                        }
                        break;
                    case 3:
                        diferenciaDias = CSComprobaciones.DevolverDiferenciaDias(primeraFecha, fechaActual);
                        if (diferenciaDias != -1)
                        {
                            Console.WriteLine("La diferencia de días entre {0} y {1} es de {2} días", primeraFecha.fecha, fechaActual.fecha, diferenciaDias);
                        }
                        else
                        {
                            opcion = 8;
                        }
                        break;
                    case 4:
                        diferenciaAnio = CSComprobaciones.DevolverDiferenciaAnios(segundaFecha, fechaActual);
                        if (diferenciaAnio != -1)
                        {
                            Console.WriteLine("La diferencia de años entre {0} y {1} es de {2} años", segundaFecha.fecha, fechaActual.fecha, diferenciaAnio);
                        }
                        else
                        {
                            opcion = 8;
                        }
                        break;
                    case 5:
                        diferenciaDias = CSComprobaciones.DevolverDiferenciaDias(segundaFecha, fechaActual);
                        if (diferenciaDias != -1)
                        {
                            Console.WriteLine("La diferencia de días entre {0} y {1} es de {2} días", segundaFecha.fecha, fechaActual.fecha, diferenciaDias);
                        }
                        else
                        {
                            opcion = 8;
                        }
                        break;
                    case 6:
                        diferenciaAnio = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
                        if (diferenciaAnio != -1)
                        {
                            Console.WriteLine("La diferencia de años entre {0} y {1} es de {2} años", primeraFecha.fecha, segundaFecha.fecha, diferenciaAnio);
                        }
                        else
                        {
                            opcion = 8;
                        }
                        break;
                    case 7:
                        diferenciaDias = CSComprobaciones.DevolverDiferenciaDias(primeraFecha, segundaFecha);
                        if (diferenciaDias != -1)
                        {
                            Console.WriteLine("La diferencia de días entre {0} y {1} es de {2} días", primeraFecha.fecha, segundaFecha.fecha, diferenciaDias);
                        }
                        else
                        {
                            opcion = 8;
                        }
                        break;
                }

                CSComprobaciones.Continuar();

            } while (opcion != 8);
        }
    }
}
