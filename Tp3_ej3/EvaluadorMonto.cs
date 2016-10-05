using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
   public class EvaluadorMonto :IEvaluador 
    { private double iMontoMaximo;


        public EvaluadorMonto(double pMontoMaximo)
        {
            this.iMontoMaximo = pMontoMaximo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return pSolicitud.Monto <= this.iMontoMaximo;
        //    bool pResultado = false;
        //    if (MontoPorCliente(SolicitudPrestamo pSolicitud.Cliente.TipoCliente) = true) { pResultado = true; }   }



        //public bool MontoPorCliente(TipoCliente pTipoCliente) { if (pTipoCliente == TipoCliente.NoCliente && iMontoMaximo <= 20000) return true; ||
        //            if(pTipoCliente == TipoCliente.Cliente&&iMontoMaximo <=100000) return true;||if }



    }

