using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 08";

            bool booleanoValorHoras = false;
            bool booleanoAnios = false;
            bool booleanoHsTrabajadas = false;
            float valorHora;
            float totalBruto;
            float totalNeto;
            float totalDescuentos;
            float descuento = 0.13f;
            float totalSueldosNeto = 0;
            string nombre;
            string dato;
            int aniosAntiguedad;
            int horasTrabajadas;

            do
            {
                Console.WriteLine("Ingerse Valor Horas: ");
                dato = Console.ReadLine();
                booleanoValorHoras = float.TryParse(dato, out valorHora);
                Console.WriteLine("Ingerse Nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingerse Años Antiguedad: ");
                dato = Console.ReadLine();
                booleanoAnios= int.TryParse(dato, out aniosAntiguedad);
                Console.WriteLine("Ingerse Cantidad de horas trabajadas: ");
                dato = Console.ReadLine();
                booleanoHsTrabajadas = int.TryParse(dato, out horasTrabajadas);
                totalBruto = (valorHora * horasTrabajadas) + (aniosAntiguedad * 150);
                totalDescuentos = totalBruto * descuento;
                totalNeto = totalBruto - totalDescuentos;
                totalSueldosNeto += totalNeto;
                Console.WriteLine("Desea ingresar otro Empleado? S/N");
                dato = Console.ReadLine();

            } while (!booleanoValorHoras && !booleanoHsTrabajadas && !booleanoAnios && dato == "S" || dato == "s");


            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Antiguedad: {0}", aniosAntiguedad);
            Console.WriteLine("Valor Hora: {0}", valorHora);
            Console.WriteLine("Total Bruto: {0}", totalBruto);
            Console.WriteLine("Total Descuentos: {0}", totalDescuentos);
            Console.WriteLine("Total Neto: {0}", totalNeto);
            Console.WriteLine("Total Sueldos: {0}", totalSueldosNeto);

            Console.ReadKey();
        }
    }
}
