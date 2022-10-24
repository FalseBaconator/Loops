using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static int storeX = 5;
        static int storeY = 5;

        static bool gameOver = false;

        static string Input;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            DrawBorder();
            while(gameOver == false)
            {
                PlayerDraw(storeX, storeY);
                Input = Console.ReadKey(true);
            }
        }

        static void DrawBorder()
        {
            Console.WriteLine("+---------+");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("+---------+");
        }

        static void PlayerDraw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("O");
        }


    }
}
