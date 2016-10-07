using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
    public class EvaluadorSueldo : IEvaluador
    {
        private double iSueldoMinimo;
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return iSueldoMinimo <= pSolicitud.Cliente.Empleo.Sueldo;
            /*bool pResultado = false;
            if (iSueldoMinimo <= pSolicitud.Cliente.Empleo.Sueldo) { pResultado = true; }
            return pResultado;*/
            
        }
        public EvaluadorSueldo(double pSueldoMinimo)
        {
            this.iSueldoMinimo = pSueldoMinimo;
        }
    }
}
