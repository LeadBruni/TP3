using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp3_ej3;

namespace SolicitudesPrestamos.Test
{
    [TestClass]
    public class Eje3Test
    {
        [TestMethod]
        public void NoClienteEvaluarCuotasExitoTest()
        {
            DateTime fIngreso = new DateTime(2010, 03, 17);
            DateTime fNacimiento = new DateTime(1995, 03, 17);
            Empleo mEmpleo = new Empleo(6000, fIngreso);
            TipoCliente tipo = TipoCliente.NoCliente;
            Cliente mCliente = new Cliente("Emanuel", "Bidal", fNacimiento,mEmpleo);
            mCliente.TipoCliente = tipo;
            SolicitudPrestamo mSolicitud = new SolicitudPrestamo(mCliente, 0, 8);
            GestorPrestamo gPrestamo = new GestorPrestamo();
            bool mResultado;
            mResultado = gPrestamo.EsValida(mSolicitud);
            bool mResultadoEsperado = true;
            Assert.AreEqual(mResultadoEsperado, mResultado);
        }

        [TestMethod]
        public void NoClienteEvaluarCuotasErrorTest()
        {
            DateTime fIngreso = new DateTime(2010, 03, 17);
            DateTime fNacimiento = new DateTime(1995, 03, 17);
            Empleo mEmpleo = new Empleo(6000, fIngreso);
            TipoCliente tipo = TipoCliente.NoCliente;
            Cliente mCliente = new Cliente("Emanuel", "Bidal", fNacimiento, mEmpleo);
            mCliente.TipoCliente = tipo;
            SolicitudPrestamo mSolicitud = new SolicitudPrestamo(mCliente, 0, 13);
            GestorPrestamo gPrestamo = new GestorPrestamo();
            bool mResultado;
            mResultado = gPrestamo.EsValida(mSolicitud);
            bool mResultadoEsperado = false;
            Assert.AreEqual(mResultadoEsperado, mResultado);
        }

        [TestMethod]
        public void ClienteEvaluarSuldoExitoTest()
        {
            DateTime fIngreso = new DateTime(2010, 03, 17);
            DateTime fNacimiento = new DateTime(1995, 03, 17);
            Empleo mEmpleo = new Empleo(10000, fIngreso);
            TipoCliente tipo = TipoCliente.Cliente;
            Cliente mCliente = new Cliente("Emanuel", "Bidal", fNacimiento, mEmpleo);
            mCliente.TipoCliente = tipo;
            SolicitudPrestamo mSolicitud = new SolicitudPrestamo(mCliente, 0, 21);
            GestorPrestamo gPrestamo = new GestorPrestamo();
            bool mResultado;
            mResultado = gPrestamo.EsValida(mSolicitud);
            bool mResultadoEsperado = true;
            Assert.AreEqual(mResultadoEsperado, mResultado);
        }

        [TestMethod]
        public void ClienteEvaluarSuldoErrorTest()
        {
            DateTime fIngreso = new DateTime(2010, 03, 17);
            DateTime fNacimiento = new DateTime(1995, 03, 17);
            Empleo mEmpleo = new Empleo(4999, fIngreso);
            TipoCliente tipo = TipoCliente.Cliente;
            Cliente mCliente = new Cliente("Emanuel", "Bidal", fNacimiento, mEmpleo);
            mCliente.TipoCliente = tipo;
            SolicitudPrestamo mSolicitud = new SolicitudPrestamo(mCliente, 0, 21);
            GestorPrestamo gPrestamo = new GestorPrestamo();
            bool mResultado;
            mResultado = gPrestamo.EsValida(mSolicitud);
            bool mResultadoEsperado = false;
            Assert.AreEqual(mResultadoEsperado, mResultado);
        }

        [TestMethod]
        public void ClienteGoldEvaluarEdadExitoTest()
        {
            DateTime fIngreso = new DateTime(2010, 03, 17);
            DateTime fNacimiento = new DateTime(1995, 03, 17);
            Empleo mEmpleo = new Empleo(10000, fIngreso);
            TipoCliente tipo = TipoCliente.ClienteGold;
            Cliente mCliente = new Cliente("Emanuel", "Bidal", fNacimiento, mEmpleo);
            mCliente.TipoCliente = tipo;
            SolicitudPrestamo mSolicitud = new SolicitudPrestamo(mCliente, 0, 21);
            GestorPrestamo gPrestamo = new GestorPrestamo();
            bool mResultado;
            mResultado = gPrestamo.EsValida(mSolicitud);
            bool mResultadoEsperado = true;
            Assert.AreEqual(mResultadoEsperado, mResultado);
        }

        [TestMethod]
        public void ClienteGoldEvaluarEdadErrorTest()
        {
            DateTime fIngreso = new DateTime(2010, 03, 17);
            DateTime fNacimiento = new DateTime(2000, 03, 17);
            Empleo mEmpleo = new Empleo(10000, fIngreso);
            TipoCliente tipo = TipoCliente.ClienteGold;
            Cliente mCliente = new Cliente("Emanuel", "Bidal", fNacimiento, mEmpleo);
            mCliente.TipoCliente = tipo;
            SolicitudPrestamo mSolicitud = new SolicitudPrestamo(mCliente, 0, 21);
            GestorPrestamo gPrestamo = new GestorPrestamo();
            bool mResultado;
            mResultado = gPrestamo.EsValida(mSolicitud);
            bool mResultadoEsperado = false;
            Assert.AreEqual(mResultadoEsperado, mResultado);
        }

        [TestMethod]
        public void ClientePlatinumEvaluarMontoExitoTest()
        {
            DateTime fIngreso = new DateTime(2010, 03, 17);
            DateTime fNacimiento = new DateTime(1995, 03, 17);
            Empleo mEmpleo = new Empleo(10000, fIngreso);
            TipoCliente tipo = TipoCliente.ClientePlatinum;
            Cliente mCliente = new Cliente("Emanuel", "Bidal", fNacimiento, mEmpleo);
            mCliente.TipoCliente = tipo;
            SolicitudPrestamo mSolicitud = new SolicitudPrestamo(mCliente, 150000, 21);
            GestorPrestamo gPrestamo = new GestorPrestamo();
            bool mResultado;
            mResultado = gPrestamo.EsValida(mSolicitud);
            bool mResultadoEsperado = true;
            Assert.AreEqual(mResultadoEsperado, mResultado);
        }

        [TestMethod]
        public void ClientePlatinumEvaluarMontoErrorTest()
        {
            DateTime fIngreso = new DateTime(2010, 03, 17);
            DateTime fNacimiento = new DateTime(1995, 03, 17);
            Empleo mEmpleo = new Empleo(10000, fIngreso);
            TipoCliente tipo = TipoCliente.ClientePlatinum;
            Cliente mCliente = new Cliente("Emanuel", "Bidal", fNacimiento, mEmpleo);
            mCliente.TipoCliente = tipo;
            SolicitudPrestamo mSolicitud = new SolicitudPrestamo(mCliente, 200001, 21);
            GestorPrestamo gPrestamo = new GestorPrestamo();
            bool mResultado;
            mResultado = gPrestamo.EsValida(mSolicitud);
            bool mResultadoEsperado = false;
            Assert.AreEqual(mResultadoEsperado, mResultado);
        }

        [TestMethod]
        public void ClientePlatinumEvaluarAntiguedadErrorTest()
        {
            DateTime fIngreso = new DateTime(2016, 06, 17);
            DateTime fNacimiento = new DateTime(1995, 03, 17);
            Empleo mEmpleo = new Empleo(10000, fIngreso);
            TipoCliente tipo = TipoCliente.ClientePlatinum;
            Cliente mCliente = new Cliente("Emanuel", "Bidal", fNacimiento, mEmpleo);
            mCliente.TipoCliente = tipo;
            SolicitudPrestamo mSolicitud = new SolicitudPrestamo(mCliente, 150000, 21);
            GestorPrestamo gPrestamo = new GestorPrestamo();
            bool mResultado;
            mResultado = gPrestamo.EsValida(mSolicitud);
            bool mResultadoEsperado = false;
            Assert.AreEqual(mResultadoEsperado, mResultado);
        }
        [TestMethod]
        public void clienteGoldExitoTest()
        {
            DateTime fIngreso = new DateTime(2001, 06, 17);
            DateTime fNacimiento = new DateTime(1970, 03, 17);
            Empleo mEmpleo = new Empleo(10000, fIngreso);
            TipoCliente tipo = TipoCliente.ClienteGold;
            Cliente mCliente = new Cliente("Emanuel", "Bidal", fNacimiento, mEmpleo);
            mCliente.TipoCliente = tipo;
            SolicitudPrestamo mSolicitud = new SolicitudPrestamo(mCliente, 150000, 60);
            GestorPrestamo gPrestamo = new GestorPrestamo();
            bool mResultado;
            mResultado = gPrestamo.EsValida(mSolicitud);
            bool mResultadoEsperado = false;
            Assert.AreEqual(mResultadoEsperado, mResultado);
        }

    }

}
