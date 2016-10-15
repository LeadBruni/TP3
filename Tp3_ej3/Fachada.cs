using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
    class Fachada
    {
        Cliente fCliente;
        Empleo fEmpleo;
        SolicitudPrestamo fSolicitud;
        TipoCliente fTipoCliente;


        //Cliente Cliente = new Cliente;



        public Empleo IngresarEmpleo(double pSueldo, DateTime pFechaIngreso)
        {
            return new Empleo(pSueldo, pFechaIngreso);
        }
        //Por defecto el Cliente creado es del tipo NoCliente
        public Cliente IngresarCliente(string pNombre, string pApellido, DateTime pFechaNac, Empleo pEmpleo)
        {
            return new Cliente(pNombre, pApellido, pFechaNac, pEmpleo);
        }

        public SolicitudPrestamo IngresarSolicitudPrestamo(Cliente pCliente, double pMonto, int pCantidadCuotas)
        {
            return new SolicitudPrestamo(pCliente, pMonto, pCantidadCuotas);
        }

        public bool ControlarSolicitud(SolicitudPrestamo pSolicitudPrestamo)
        {
            return new GestorPrestamo().EsValida(pSolicitudPrestamo);

        }
        public bool ingresarDatosPorCliente(int pOpcionTipoCliente, string pNombre, string pApellido, DateTime pFechaNacimiento, double pSueldo, DateTime pFechaIngreso, double pMonto, int pCantidadCuotas)
        {
            Empleo pEmpleo = this.IngresarEmpleo(pSueldo, pFechaIngreso);
            bool mResultado = false;
            switch (pOpcionTipoCliente)
            {
                case 1:
                    {
                        Cliente pCliente = this.IngresarCliente(pNombre, pApellido, pFechaNacimiento, pEmpleo);
                        pCliente.TipoCliente = TipoCliente.NoCliente;
                        SolicitudPrestamo pSolicitud = this.IngresarSolicitudPrestamo(pCliente, pMonto, pCantidadCuotas);
                         mResultado = this.ControlarSolicitud(pSolicitud);
                        break;
                    }
                case 2:
                    {
                        Cliente pCliente = this.IngresarCliente(pNombre, pApellido, pFechaNacimiento, pEmpleo);
                        pCliente.TipoCliente = TipoCliente.Cliente;
                        SolicitudPrestamo pSolicitud = this.IngresarSolicitudPrestamo(pCliente, pMonto, pCantidadCuotas);
                        mResultado = this.ControlarSolicitud(pSolicitud);
                        break;
                    }

                case 3:
                    {
                        Cliente pCliente = this.IngresarCliente(pNombre, pApellido, pFechaNacimiento, pEmpleo);
                        pCliente.TipoCliente = TipoCliente.ClienteGold;
                        SolicitudPrestamo pSolicitud = this.IngresarSolicitudPrestamo(pCliente, pMonto, pCantidadCuotas);
                        mResultado = this.ControlarSolicitud(pSolicitud);
                        break;
                    }
                case 4:
                    {
                        Cliente pCliente = this.IngresarCliente(pNombre, pApellido, pFechaNacimiento, pEmpleo);
                        pCliente.TipoCliente = TipoCliente.ClientePlatinum;
                        SolicitudPrestamo pSolicitud = this.IngresarSolicitudPrestamo(pCliente, pMonto, pCantidadCuotas);
                        mResultado = this.ControlarSolicitud(pSolicitud);
                        break;
                    }
            }
            return mResultado;
        }
    }
}