using System;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;

namespace consoleApp1
{

    class Program
    {
        static void Main()
        {
            int health = 5, maxHealth = 10;
            int mana = 7, maxMana = 10;

            DrawBar(health, maxHealth, ConsoleColor.Green, 0);
            DrawBar(mana, maxMana, ConsoleColor.Blue, 1);
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += " ";

            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += " ";
            }

            Console.Write(bar + ']');
        }



    }
}


