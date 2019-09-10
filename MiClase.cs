using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    public static class MiClase
    {


        public static  void mover()
        {
            ConsoleKeyInfo teclaPresionada;
            do
            {
                teclaPresionada = Console.ReadKey(false);
                switch (teclaPresionada.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.CursorLeft = Console.CursorLeft - 2;
                        Console.Write(" ");
                        Console.CursorLeft = Console.CursorLeft - 1;
                        Console.CursorTop = Console.CursorTop - 1;
                        Console.Write("█");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.CursorLeft = Console.CursorLeft - 2;
                        Console.Write(" ");
                        Console.CursorLeft = Console.CursorLeft - 1;
                        Console.CursorTop = Console.CursorTop + 1;
                        Console.Write("█");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.CursorLeft = Console.CursorLeft - 2;
                        Console.Write(" ");
                        Console.CursorLeft = Console.CursorLeft - 2;
                        Console.Write("█");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.CursorLeft = Console.CursorLeft - 2;
                        Console.Write(" ");                        
                        Console.Write("█");
                        break;
                }


            } while (teclaPresionada.KeyChar.ToString().ToLower() != "s");


            }


    }
}
