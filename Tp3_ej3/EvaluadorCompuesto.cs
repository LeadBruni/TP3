using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
    public class EvaluadorCompuesto : IEvaluador
    {

        private readonly List<IEvaluador> iEvaluadores;

        public EvaluadorCompuesto()
        { this.iEvaluadores = new List<IEvaluador>(); }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            this.iEvaluadores.Add(pEvaluador);
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            bool esValida = true;

            IEnumerator<IEvaluador> enumerador = this.iEvaluadores.GetEnumerator();

            while (esValida && enumerador.MoveNext())
            {
                esValida = enumerador.Current.EsValida(pSolicitud);
            }

            return esValida;
        }






































    }
}
