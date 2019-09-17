using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        private float Area()
        {
            return (float)(Math.Abs(vertice3.GetX() - vertice4.GetX()) * Math.Abs(vertice2.GetY() - vertice3.GetY()));
        }

        public float Perimetro()
        {
            return (float)(Math.Abs(vertice3.GetX() - vertice4.GetX()) + Math.Abs(vertice2.GetY() - vertice3.GetY()) * 2);
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            Punto p2 = new Punto(vertice3.GetX(), vertice1.GetY());
            Punto p4 = new Punto(vertice1.GetX(), vertice1.GetY());
        }

        public float GetArea()
        {
            if (this.area == -1)
            {
                this.area = this.Area();
            }
            return this.area;
        }

        public float GetPerimetro()
        {
            return this.perimetro;
        }
    }
}
