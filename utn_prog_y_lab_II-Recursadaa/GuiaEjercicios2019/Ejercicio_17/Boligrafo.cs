using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            short tintaTotal;
            if(tinta > 0)
            {
                this.tinta = 100;
            }
            else
            {
                tintaTotal = this.tinta += tinta;
                if(tintaTotal < 0)
                {
                    this.tinta = 0;
                }
            }

        }

        public void Recargar()
        {
            this.SetTinta(100);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool pintado = false;
            dibujo = "";

            if (this.GetTinta() > 0)
            {
                Console.WriteLine("Se puede dibujar");
                if(this.GetTinta() < Math.Abs(gasto))
                {
                    this.SetTinta(gasto);
                    for (int i = 0; i <= this.tinta; i++)
                    {
                        dibujo += "*";
                    }
                }
                else
                {
                    this.SetTinta(gasto);
                    Math.Abs(gasto);
                    for (int i = 0; i <= Math.Abs(gasto); i++)
                    {
                        dibujo += "*";
                    }
                }
                Console.ForegroundColor = this.color;
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.Gray;
                pintado = true;
            }

            return pintado;
        }
    }
}
