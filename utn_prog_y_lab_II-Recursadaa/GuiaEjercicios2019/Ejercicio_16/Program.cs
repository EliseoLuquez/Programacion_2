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


            do
            {
                Console.WriteLine("Ingrese Nota 1: ");
                dato = Console.ReadLine();
                ingresoNotaUno = byte.TryParse(dato, out notaUno);
                Console.WriteLine("Ingrese Nota 2: ");
                dato = Console.ReadLine();
                ingresoNotaDos = byte.TryParse(dato, out notaDos);

            } while (!ingresoNotaUno && !ingresoNotaDos);

            a1.Estudiar(notaUno, notaDos);
            a2.Estudiar(nota1Aux, nota2Aux);
            a3.Estudiar(nota1Aux, nota2Aux);


            Console.ReadKey();

        }
    }
}
