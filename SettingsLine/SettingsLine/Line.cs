using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsLine
{
    [Serializable]
    public class Line
    {
        public ConsoleColor Color { set; get; }

        public int Height { set; get; }

        public int Width { set; get; }

        public int MarginTop { set; get; }

        public int MarginLeft { set; get; }

        public Line()
        {
            Height = 1;
            Width = 1;
            Color = ConsoleColor.Black;
            MarginTop = 0;
            MarginLeft = 0;
        }

        public void PrintLine()
        {
            Console.Clear();
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(MarginLeft, MarginTop);
            for (int j = 0; j < Width; j++) 
            {
                for (int i = 0; i < Height; i++)
                {
                    Console.SetCursorPosition(MarginLeft + i, MarginTop + j); Console.Write("=");
                }
            }
            Console.ReadLine();
            Console.Clear();
        }

        public void SetColor(int choise)
        {
            switch (choise)
            {
                case 0: Color =  ConsoleColor.Black;         break;
                case 1: Color =  ConsoleColor.Blue;          break;
                case 2: Color =  ConsoleColor.Cyan;          break;
                case 3: Color =  ConsoleColor.DarkBlue;      break;
                case 4: Color =  ConsoleColor.DarkCyan;      break;
                case 5: Color =  ConsoleColor.DarkGray;      break;
                case 6: Color =  ConsoleColor.DarkGreen;     break;
                case 7: Color =  ConsoleColor.DarkMagenta;   break;
                case 8: Color =  ConsoleColor.DarkRed;       break;
                case 9: Color =  ConsoleColor.DarkYellow;    break;
                case 10: Color = ConsoleColor.Gray;          break;
                case 11: Color = ConsoleColor.Green;         break;
                case 12: Color = ConsoleColor.Magenta;       break;
                case 13: Color = ConsoleColor.Red;           break;
                case 14: Color = ConsoleColor.White;         break;
                case 15: Color = ConsoleColor.Yellow;        break;                
            }
        }
    }
}
