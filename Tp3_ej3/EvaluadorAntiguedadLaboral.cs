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
            DateTime fechaHoy = DateTime.Today;
            Math.Abs( fechaHoy.Month- pSolicitud.iCliente.iEmpleo.fechaIngreso.Month)
            { pResultado = true; }
            return pResultado;
        }
    }
}
