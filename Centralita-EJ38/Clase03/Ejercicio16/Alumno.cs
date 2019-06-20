using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        public String apellido;
        public int legajo;
        public String nombre;
        public static String colegio;
        public static Random rnd;

        public Alumno(String apellido, String nombre, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.notaFinal = -1;
        }

        static Alumno()
        {
            colegio = "UTN Fra";
            rnd = new Random();
        }

        public void CalcularFinal()
        {
            if((this.nota1 >= 4) && (this.nota2 >= 4))
            {
                this.notaFinal = rnd.Next(1, 6);

            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public String Mostrar()
        {
            //CONDICION ? VERDADERO : FALSO;
            return this.legajo + " - " + this.apellido + " " + this.nombre + " " + colegio + " " + this.nota1 + " " 
                +this.nota2 + " " + (this.notaFinal == -1 ? "DESAPROBADO": this.notaFinal.ToString());

        }
    }
}
