using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
    class Empleo
    {
        private double iSueldo;
        private DateTime iFechaIngreso;


        public Empleo (double pSueldo, DateTime pFechaIngreso)
        { iSueldo = pSueldo;
            pFechaIngreso = iFechaIngreso;
        }


        public double Sueldo()
        { return iSueldo; }


        public DateTime FechaIngreso()
        { return iFechaIngreso; }







    }
}
