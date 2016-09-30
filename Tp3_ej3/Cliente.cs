using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
    class Cliente
    {
        private string iNombre;
        private string iApellido;
        private DateTime iFechaNacimiento;
        private Empleo iEmpleo;
        private TipoCliente iTipoCliente;

   


        public Cliente(string pNombre, string pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
        {
            iNombre = pNombre;
            pApellido = iApellido;
            pFechaNacimiento = iFechaNacimiento;
            iEmpleo = pEmpleo;   
        }


        public string Nombre()
        { return iNombre;
        }

        public string Apellido()
        { return iApellido; }

        public DateTime FechaNacimiento()
        { return iFechaNacimiento; }

        public Empleo Empleo()
        { return iEmpleo; }
         
        public TipoCliente TipoCliente()
        { return iTipoCliente; }
    }
}
