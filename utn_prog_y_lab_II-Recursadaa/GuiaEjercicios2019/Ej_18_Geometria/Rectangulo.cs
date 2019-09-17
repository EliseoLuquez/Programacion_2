using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_18_Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float Area()
        {
            float bas;
            float altura;
            bas = (Math.Abs(vertice1.GetX()) - Math.Abs(vertice3.GetX()));
            altura = (Math.Abs(vertice1.GetY() - Math.Abs(vertice3.GetY())));
            this.area = bas * altura;
            return this.area;
        }

        public float Perimetro()
        {
            float bas;
            float altura;
            bas = (Math.Abs(vertice1.GetX() - vertice3.GetX()));
            altura = (Math.Abs(vertice1.GetY() - vertice3.GetY()));
            this.perimetro = (bas + altura) * 2;
            return this.perimetro;
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            Punto p2 = new Punto(vertice3.GetX(), vertice1.GetY());
            Punto p4 = new Punto(vertice1.GetX(), vertice1.GetY());
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = p2;
            this.vertice4 = p4;
        }

        public string Mostrar(Rectangulo rect)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Area: " + this.Area());
            sb.AppendLine("Perimetro: " + this.Perimetro());

            return sb.ToString();
        }
    }
}
