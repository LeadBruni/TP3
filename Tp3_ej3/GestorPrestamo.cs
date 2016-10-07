using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
   public class GestorPrestamo
    {
        private Dictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente;

        public GestorPrestamo()

        {
            EvaluadorAntiguedadLaboral evalAntiguedad = new EvaluadorAntiguedadLaboral(6);
            EvaluadorSueldo evalSueldo = new EvaluadorSueldo(5000);
            EvaluadorEdad evalEdad = new EvaluadorEdad(18, 75);
            
            iEvaluadoresPorCliente[TipoCliente.NoCliente] = this.CrearEvaluadorNoCliente(evalAntiguedad, evalEdad, evalSueldo);
            iEvaluadoresPorCliente[TipoCliente.Cliente] = this.CrearEvaluadorCliente(evalAntiguedad, evalEdad, evalSueldo);
            iEvaluadoresPorCliente[TipoCliente.ClienteGold] = this.CrearEvaluadorClienteGold(evalAntiguedad, evalEdad, evalSueldo);
            iEvaluadoresPorCliente[TipoCliente.ClientePlatinum] = this.CrearEvaluadorClientePlatinum(evalAntiguedad, evalEdad, evalSueldo);

        }

        private IEvaluador CrearEvaluadorNoCliente(EvaluadorAntiguedadLaboral pAntiguedad,EvaluadorEdad pEdad,EvaluadorSueldo pSueldo)
        {
            EvaluadorCompuesto evalCompuesto = new EvaluadorCompuesto();
            EvaluadorCantidadCuotas evalCantidadCuotas = new EvaluadorCantidadCuotas(12);
            EvaluadorMonto evalMonto = new EvaluadorMonto(20000);
            evalCompuesto.AgregarEvaluador(evalCantidadCuotas);
            evalCompuesto.AgregarEvaluador(pSueldo);
            evalCompuesto.AgregarEvaluador(pEdad);
            evalCompuesto.AgregarEvaluador(evalMonto); 
            evalCompuesto.AgregarEvaluador(pAntiguedad);

            return evalCompuesto;
        }

        private IEvaluador CrearEvaluadorCliente(EvaluadorAntiguedadLaboral pAntiguedad, EvaluadorEdad pEdad, EvaluadorSueldo pSueldo)
        {
            EvaluadorCompuesto evalCompuesto = new EvaluadorCompuesto();
            EvaluadorCantidadCuotas evalCantidadCuotas = new EvaluadorCantidadCuotas(32);
            EvaluadorMonto evalMonto = new EvaluadorMonto(100000);
            evalCompuesto.AgregarEvaluador(evalCantidadCuotas);
            evalCompuesto.AgregarEvaluador(pSueldo);
            evalCompuesto.AgregarEvaluador(pEdad);
            evalCompuesto.AgregarEvaluador(evalMonto);
            evalCompuesto.AgregarEvaluador(pAntiguedad);

            return evalCompuesto;

        }

        private IEvaluador CrearEvaluadorClienteGold(EvaluadorAntiguedadLaboral pAntiguedad, EvaluadorEdad pEdad, EvaluadorSueldo pSueldo)
        {
            EvaluadorCompuesto evalCompuesto = new EvaluadorCompuesto();
            EvaluadorCantidadCuotas evalCantidadCuotas = new EvaluadorCantidadCuotas(60);
            EvaluadorMonto evalMonto = new EvaluadorMonto(150000);
            evalCompuesto.AgregarEvaluador(evalCantidadCuotas);
            evalCompuesto.AgregarEvaluador(pSueldo);
            evalCompuesto.AgregarEvaluador(pEdad);
            evalCompuesto.AgregarEvaluador(evalMonto);
            evalCompuesto.AgregarEvaluador(pAntiguedad);

            return evalCompuesto;

        }

        private IEvaluador CrearEvaluadorClientePlatinum(EvaluadorAntiguedadLaboral pAntiguedad, EvaluadorEdad pEdad, EvaluadorSueldo pSueldo)
        {
            EvaluadorCompuesto evalCompuesto = new EvaluadorCompuesto();
            EvaluadorCantidadCuotas evalCantidadCuotas = new EvaluadorCantidadCuotas(60);
            EvaluadorMonto evalMonto = new EvaluadorMonto(200000);
            evalCompuesto.AgregarEvaluador(evalCantidadCuotas);
            evalCompuesto.AgregarEvaluador(pSueldo);
            evalCompuesto.AgregarEvaluador(pEdad);
            evalCompuesto.AgregarEvaluador(evalMonto);
            evalCompuesto.AgregarEvaluador(pAntiguedad);

            return evalCompuesto;

        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
           bool mValida=false;
            if (iEvaluadoresPorCliente.ContainsKey(pSolicitud.Cliente.TipoCliente))
            {
                mValida = iEvaluadoresPorCliente[pSolicitud.Cliente.TipoCliente].EsValida(pSolicitud);
            }
            return mValida;            
        }
    }
}
