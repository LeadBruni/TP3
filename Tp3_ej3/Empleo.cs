using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
    public class Empleo
    {
        private double iSueldo;
        private DateTime iFechaIngreso;


        public Empleo (double pSueldo, DateTime pFechaIngreso)
        { iSueldo = pSueldo;
            pFechaIngreso = iFechaIngreso;
        }


        public double Sueldo
        {
            get { return this.iSueldo; }
            set { this.iSueldo = value; }
        }

        public DateTime FechaIngreso
        { 
            get { return this.iFechaIngreso; }
            
        }







    }
}
