using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static int storeX = 10;
        static int storeY = 10;

        static bool gameOver = false;

        static ConsoleKeyInfo Input;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            while(gameOver == false)
            {
                Console.Clear();
                DrawBorder();
                PlayerDraw(storeX, storeY);
                Input = Console.ReadKey(true);
                if (Input.Key == ConsoleKey.Escape)
                {
                    gameOver = true;
                }
                else if (Input.Key == ConsoleKey.UpArrow && storeY > 1)
                {
                    storeY--;
                }
                else if (Input.Key == ConsoleKey.DownArrow && storeY < 19)
                {
                    storeY++;
                }
                else if (Input.Key == ConsoleKey.RightArrow && storeX < 19)
                {
                    storeX++;
                }
                else if (Input.Key == ConsoleKey.LeftArrow && storeX > 1)
                {
                    storeX--;
                }
            }
        }

        static void DrawBorder()
        {
            Console.WriteLine("+-------------------+");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.Write("+-------------------+");
        }

        static void PlayerDraw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("O");
        }


    }
}
