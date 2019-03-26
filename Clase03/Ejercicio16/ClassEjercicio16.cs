using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class ClassEjercicio16
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";
            Alumno alumno1 = new Alumno("Luquez", "Eliseo", 0);
            Alumno alumno2 = new Alumno("Gonzalez", "Gonzalo", 1);
            Alumno alumno3 = new Alumno("Perez", "Daniel", 2);
            Alumno.colegio = " UTN Fra ";
            alumno1.apellido = "Perez";
            alumno1.Estudiar(9, 8);
            alumno2.Estudiar(7, 8);
            alumno3.Estudiar(6, 2);
            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            System.Console.ReadKey();
        }
    }
}
