using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada fachadaSolicitud = new Fachada();
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido");
            string apellido = Console.ReadLine();

            Console.WriteLine("Elija el tipo de cliente que es: ");
            Console.WriteLine("1-No Cliente  2-Cliente 3-Cliente Gold 4-Cliente Platinum");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese fecha de nacimiento");
            DateTime fNacimiento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Ingrese fecha ingreso a empleo");
            DateTime fIngreso = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Ingrese el sueldo mensual de su empleo");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese monto a solicitar");
            double monto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese cantidad de cuotas");
            int cuotas = Convert.ToInt32(Console.ReadLine());

            bool resultado = false;
            resultado = fachadaSolicitud.ingresarDatosPorCliente(opcion,nombre, apellido, fNacimiento, sueldo, fIngreso, monto, cuotas);
            if (resultado) { Console.WriteLine("Solicitud Valida"); }
            else { Console.WriteLine("Solicitud Invalida "); }
            Console.ReadKey();
        }
    }
}
