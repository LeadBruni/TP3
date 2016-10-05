using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
    public class EvaluadorCantidadCuotas:IEvaluador
    {
        private int iCantidadMaximaCuotas;
        public EvaluadorCantidadCuotas(int pCantidadMaxima)
        {
            this.iCantidadMaximaCuotas = pCantidadMaxima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {

            bool pResultado = false;
            if (iCantidadMaximaCuotas >= pSolicitud.CantidadCuotas) { pResultado = true; }
            return pResultado;

        }
    }
}
