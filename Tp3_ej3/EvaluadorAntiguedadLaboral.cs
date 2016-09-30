using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
    public class EvaluadorAntiguedadLaboral: IEvaluador
    {
        private int iAntiguedadMinima;
        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            bool pResultado = false;
            if (DateTime.Today - pSolicitud.Cliente)
            { pResultado = true; }
            return pResultado;
        }
    }
}
