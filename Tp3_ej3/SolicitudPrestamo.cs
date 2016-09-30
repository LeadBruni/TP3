using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class SolicitudPrestamos
    {
        private double iMonto;
        private int iCantidadCuotas;
        private Cliente iCliente;

        public double Monto { get { return this.iMonto; } }
        public int CantidadCuotas { get { return this.iCantidadCuotas; } }

        public SolicitudPrestamos(Cliente pCliente, double pMonto,int pCantidadCuotas)

    }
}

