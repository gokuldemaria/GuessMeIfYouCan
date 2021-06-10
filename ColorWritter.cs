using System;
namespace num_finder.tools
{
    public class ColorWritter
    {
        public static void ColorMaker(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            System.Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}