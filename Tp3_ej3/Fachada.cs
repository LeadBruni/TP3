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
            return new SolicitudPrestamo(pCliente, pMonto, pCantidadCuotas );
        }

        public bool ControlarSolicitud(SolicitudPrestamo pSolicitudPrestamo)
        {
            return new GestorPrestamo().EsValida(pSolicitudPrestamo);

        }
    }
}
