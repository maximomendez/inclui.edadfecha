using inclui.edadfecha;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Inclui.EdadFechaTest
{
    /// <summary>
    /// Clase inicial, en la cual tendremos las pruebas que se haran 
    /// a las funciones de comprobación
    /// </summary>

    [TestClass]
    public class EdadFechaTest
    {
        /// <summary>
        /// Prueba para comprobar la diferencia en años
        /// entre dos fechas indicadas
        /// </summary>

        [TestMethod]
        public void HallarDiferenciaEnAnioFechasDC()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/02/2010"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("02/12/2011"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 1;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        /// <summary>
        /// Prueba para comprobar la diferencia en dias
        /// entre dos fechas indicadas
        /// </summary>

        [TestMethod]
        public void HallarDiferenciaEnDiasFechasDC()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/02/2010"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/04/2021"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaDias(primeraFecha, segundaFecha);
            int resultadoEsperado = 4077;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }


        /// <summary>
        /// Prueba para comprobar la diferencia en años
        /// entre unas fecha antes de cristo
        /// </summary>
        [TestMethod]
        public void HallarDiferenciaEnAnioFechasAC()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/07/2013"),
                antesCristo = true
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("02/03/2015"),
                antesCristo = true
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 1;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        /// <summary>
        /// Prueba para comprobar la diferencia en dias
        /// entre unas fecha antes de cristo
        /// </summary>

        [TestMethod]
        public void HallarDiferenciaEnDiasFechasAC()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/03/2011"),
                antesCristo = true
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/02/2001"),
                antesCristo = true
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaDias(primeraFecha, segundaFecha);
            int resultadoEsperado = 3680;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        /// <summary>
        /// Prueba para comprobar la diferencia en años
        /// entre unas fechas que no tengan años de diferencia
        /// entre si
        /// </summary>

        [TestMethod]
        public void HallarDiferenciaEnAnioFechasSinAnios()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("02/02/2001"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/2/2002"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 0;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }


        /// <summary>
        /// Prueba para comprobar la diferencia en dias
        /// entre unas fechas que no tengan dias de diferencia
        /// entre si
        /// </summary>


        [TestMethod]
        public void HallarDiferenciaEnDiasFechasSinDias()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("02/02/2001"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("02/2/2001"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaDias(primeraFecha, segundaFecha);
            int resultadoEsperado = 0;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        /// <summary>
        /// Prueba para comprobar la diferencia en años
        /// entre una fecha antes de cristo y una fecha despues de cristo
        /// </summary>

        [TestMethod]
        public void HallarDiferenciaEnAnioFechaACyFechaDC()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/02/2001"),
                antesCristo = true
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("02/12/2023"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 4024;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        /// <summary>
        /// Prueba para comprobar la diferencia en dias
        /// entre una fecha antes de cristo y una fecha despues de cristo
        /// </summary>

        [TestMethod]
        public void HallarDiferenciaEnDiasFechaACyFechaDC()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("01/02/2001"),
                antesCristo = true
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("02/12/2023"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaDias(primeraFecha, segundaFecha);
            int resultadoEsperado = 1469371;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        /// <summary>
        /// Prueba para comprobar la diferencia en años
        /// con un año bisiesto
        /// </summary>


        [TestMethod]
        public void DiferenciasAnioBisiesto()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("29/2/2000"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("28/2/2001"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 1;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        /// <summary>
        /// Prueba para comprobar la diferencia en años
        /// con un año bisiesto
        /// </summary>

        [TestMethod]
        public void DiferenciasFebreroMarzoBisiesto()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("29/2/2000"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("1/3/2003"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 3;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        /// <summary>
        /// Prueba para comprobar la diferencia en años
        /// con dos años bisiestos
        /// </summary>

        [TestMethod]
        public void DiferenciasAnioBisiesto2()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("29/2/2000"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("29/2/2004"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 4;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        /// <summary>
        /// Prueba para comprobar la diferencia en años
        /// con un año bisiesto
        /// </summary>

        [TestMethod]
        public void DiferenciasAnioBisiesto3()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("28/2/2001"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("29/2/2004"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 3;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }


        /// <summary>
        /// Prueba para comprobar la diferencia en años
        /// con un año bisiesto
        /// </summary>

        [TestMethod]
        public void DiferenciasAnioBisiesto4()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("29/2/2000"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("28/2/2003"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 3;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }


        /// <summary>
        /// Prueba para comprobar la diferencia en años
        /// con año bisiesto antes de cristo y un año
        /// no bisiesto despues de cristo 
        /// </summary>

        [TestMethod]
        public void DiferenciasAnioBisiestoAntesDeCristo()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("1/5/2000"),
                antesCristo = true
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("12/4/2003"),
                antesCristo = false
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 4002;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }
    }
}
