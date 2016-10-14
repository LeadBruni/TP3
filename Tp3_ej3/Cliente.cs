using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
    public class Cliente
    {
        private string iNombre;
        private string iApellido;
        private DateTime iFechaNacimiento;
        private Empleo iEmpleo;
        private TipoCliente iTipoCliente;




        public Cliente(string pNombre, string pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
        {
            iNombre = pNombre;
            iApellido = pApellido;
            iFechaNacimiento = pFechaNacimiento;
            iEmpleo = pEmpleo;
            
        }


        public string Nombre
        {
            get { return this.iNombre; }
        }

        public string Apellido
        { get { return this.iApellido; } }

        public DateTime FechaNacimiento
        { get { return this.iFechaNacimiento; } }

        
        public TipoCliente TipoCliente
        {
            get { return this.iTipoCliente; }
            set { this.iTipoCliente = value; }

        }

        public Empleo Empleo
        {
            get { return this.iEmpleo; }
            set { this.iEmpleo = value; }
        }

    }
}
