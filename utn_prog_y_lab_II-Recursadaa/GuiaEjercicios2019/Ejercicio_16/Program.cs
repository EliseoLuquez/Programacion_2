using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";

            string dato;
            bool ingresoNotaUno = false;
            bool ingresoNotaDos = false;
            byte notaUno;
            byte notaDos;
        
            Alumno a1 = new Alumno();
            a1.nombre = "Pedro";
            a1.apellido = "Morales";
            a1.legajo = 1;

            Alumno a2 = new Alumno();
            a2.nombre = "Juan";
            a2.apellido = "Gonzalez";
            a2.legajo = 2;

            Alumno a3 = new Alumno();
            a3.nombre = "Arturo";
            a3.apellido = "Duro";
            a3.legajo = 3;


            a1.Estudiar(2, 4);
            a2.Estudiar(6, 8);
            a3.Estudiar(9, 7);

            a1.CalcularFinal();
            a2.CalcularFinal();
            a3.CalcularFinal();

            Console.WriteLine(a1.Mostrar());
            Console.WriteLine(a2.Mostrar());
            Console.WriteLine(a3.Mostrar());


            Console.ReadKey();

        }
    }
}
