using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
   public class GestorPrestamo
    {
        private Dictionary<TipoCliente, EvaluadorCompuesto> iEvaluadoresPorCliente;

        public GestorPrestamo()
        {
            iEvaluadoresPorCliente[TipoCliente.NoCliente] = this.CrearEvaluadorNoCliente(pEdad, pAntiguedad, pCuotas, pMonto, pSueldo);
            iEvaluadoresPorCliente[TipoCliente.Cliente] = this.CrearEvaluadorCliente(pEdad, pAntiguedad, pCuotas, pMonto, pSueldo);
            iEvaluadoresPorCliente[TipoCliente.ClienteGold] = this.CrearEvaluadorClienteGold(pEdad, pAntiguedad, pCuotas, pMonto, pSueldo);
            iEvaluadoresPorCliente[TipoCliente.ClientePlatinum] = this.CrearEvaluadorClientePlatinum(pEdad, pAntiguedad, pCuotas, pMonto, pSueldo);

        }

        public EvaluadorCompuesto CrearEvaluadorNoCliente()
    }
}
