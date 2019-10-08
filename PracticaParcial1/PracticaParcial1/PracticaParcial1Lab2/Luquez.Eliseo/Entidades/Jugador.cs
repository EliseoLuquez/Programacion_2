using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;


        public float Altura
        {
            get { return altura; }
        }

        public float Peso
        {
            get { return peso; }
        }

        public Posicion Posicion
        {
            get { return posicion; }
        }

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion): base(nombre, apellido, dni, edad)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.Append("\nPeso: " + this.Peso);
            sb.Append("\nAltura: " + this.Altura);
            sb.Append("\nPosicion: " + this.Posicion);

            return sb.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            //ValidarEstadoFisico deberá validar que el índice de masa corporal se encuentre en el rango de 18.5 y
            //25 inclusive.Para calcularlo, utilizar la siguiente fórmula:
            //IMC = peso / altura ^ 2
            double imc;
            imc = Math.Pow((this.Peso / this.Altura), 2);
            return  (imc <= 25 && imc >= 18.5) ? true : false;
        }

        public override bool ValidarAptitud()
        {
            //ValidarAptitud: Un jugador será apto para ingresar a un equipo siempre que su edad no supere los
            //40 años y se encuentre en estado físico
            bool validar = false;
            validar = (this.Edad < 40 && ValidarEstadoFisico() == true) ? true : false;
            return validar;
        }
    }
}
