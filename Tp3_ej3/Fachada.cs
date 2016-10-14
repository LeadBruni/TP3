using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
    class Fachada
    {
        Cliente fCliente;
        Empleo fEmpleo;
        SolicitudPrestamo fSolicitud;
        TipoCliente fTipoCliente;
        IEvaluador fIEvaluador;

        //Cliente Cliente = new Cliente;

        public bool EsValida(SolicitudPrestamo fSolicitud)
        {
            fIEvaluador.EsValida(fSolicitud);
            return false;
        }

    }
}
