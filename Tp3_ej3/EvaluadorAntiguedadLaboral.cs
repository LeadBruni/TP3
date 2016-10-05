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
            DateTime mFecha = pSolicitud.Cliente.Empleo.FechaIngreso;
            DateTime fechaHoy = DateTime.Now;
             //Obtengo la diferencia en años.
            int años = fechaHoy.Year - mFecha.Year;
            //Comparo los meses de las fechas
            if (fechaHoy.Month - mFecha.Month <= 0)
            {
                //comparo los dias de las fechas
                if (fechaHoy.Day - mFecha.Day < 0)
                {
                    años--;
                }
            }     
          if (iAntiguedadMinima<= años) { pResultado = true; }
            return pResultado;
        }

       /* public int calculoAntiguedad(DateTime pFecha)
        {
            DateTime fechaHoy = DateTime.Now;
            int fechaParametro = pFecha.Year;
            //Obtengo la diferencia en años.
            int años = fechaHoy.Year - pFecha.Year;
            //Comparo los meses de las fechas
            if (fechaHoy.Month -pFecha.Month <= 0) 
            {
                if (fechaHoy.Day - pFecha.Day < 0)
                {
                    años--;
                }
            }
            return años;
        }*/
    }
}
