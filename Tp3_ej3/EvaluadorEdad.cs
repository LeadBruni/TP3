using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
    class EvaluadorEdad: IEvaluador
    {
        private int iEdadMinima;
        private int iEdadMaxima;

        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMinima = pEdadMinima;
            this.iEdadMaxima = pEdadMaxima;
        }
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            bool pResultado = false;
            DateTime fechaHoy = DateTime.Now;
            DateTime fechaEdad = pSolicitud.Cliente.FechaNacimiento;
            //Obtengo la diferencia en años.
            int edad = fechaHoy.Year - fechaEdad.Year;
            //Comparo los meses de las fechas
            if (fechaHoy.Month - fechaEdad.Month <= 0)
            {
                //comparo los dias de las fechas
                if (fechaHoy.Day - fechaEdad.Day < 0)
                {
                    edad--;
                }
            }
            if (iEdadMinima <= edad && iEdadMaxima<=edad) { pResultado = true; }
            return pResultado;
        }
    }
}
