using inclui.edadfecha;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace inclui.pruebasEdadFecha
{
    [TestClass]
    public class PruebasEdadFecha
    {
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
        [TestMethod]
        public void DiferenciasAnioBisiestoAntesDeCristo()
        {
            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("1/5/2000"),
                antesCristo = false
            };

            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Parse("12/4/2003"),
                antesCristo = true
            };

            int resultadoReal = CSComprobaciones.DevolverDiferenciaAnios(primeraFecha, segundaFecha);
            int resultadoEsperado = 4008;

            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }
    }
}
