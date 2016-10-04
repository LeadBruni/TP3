using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp3_ej3;

namespace SolicitudesPrestamos.Test
{
    [TestClass]
    public class Eje3Test
    {
        [TestMethod]
        public void EAntiguiedadLaboralTest()
        {
            DateTime nuevaFecha = new DateTime (2010 , 10 , 05);
            EvaluadorAntiguedadLaboral evaluador = new EvaluadorAntiguedadLaboral(10);
            int mResultadoEsperado = 5;
            int mResultado = evaluador.calculoAntiguedad(nuevaFecha);

            Assert.AreEqual(mResultadoEsperado, mResultado);
        }
    }
}
