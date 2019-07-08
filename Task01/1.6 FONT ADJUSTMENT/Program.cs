using System;
using System.Collections.Generic;

namespace _1._6_FONT_ADJUSTMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Font_Adjustment();
        }

        static void Font_Adjustment()
        {
            ConsoleKeyInfo e;
            List<bool> pressed = new List<bool>() { false, false, false };
            int i = -1;
            for (; ; )
            {
                e = Console.ReadKey();
                switch (e.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        i = 0;
                        if (!pressed[i])
                            pressed[i] = true;
                        else
                            pressed[i] = false;
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        i = 1;
                        if (!pressed[i])
                            pressed[i] = true;
                        else
                            pressed[i] = false;
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        i = 2;
                        if (!pressed[i])
                            pressed[i] = true;
                        else
                            pressed[i] = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("_____________________________________");
                        Console.WriteLine("ERROR: Enter only 1-3 or esc for exit");
                        Console.WriteLine("_____________________________________");
                        break;
                }

                Console.WriteLine("Font propetries is:");

                for (int j = 0; j < pressed.Count; j++)
                {
                    if (pressed[j])
                        Console.WriteLine(Enum.GetName(typeof(Font), j) + " ");
                }
                if (e.Key == ConsoleKey.Escape)
                    break;
            }
        }

        enum Font { italic, bold, underline };
    }
}