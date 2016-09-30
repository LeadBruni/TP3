using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
    class SolicitudPrestamo
    {
        //Constructores
        private double iMonto;
        private int iCantidadCuotas;
        private Cliente iCliente;

        //Properties
        public double Monto { get { return this.iMonto; } }
        public int CantidadCuotas { get { return this.iCantidadCuotas; } }


        public SolicitudPrestamo(Cliente pCliente, double pMonto,int pCantidadCuotas)
            {
            this.iCliente = pCliente;
            this.iMonto = pMonto;
            this.iCantidadCuotas = pCantidadCuotas;
            }


    }
}

