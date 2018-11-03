using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SettingsLine
{
    class Program
    {
        public static void ChoiseColor(Line line)
        {
            int choise = 0;
            Console.WriteLine("0)Black");
            Console.WriteLine("1)Blue");
            Console.WriteLine("2)Cyan");
            Console.WriteLine("3)DarkBlue");
            Console.WriteLine("4)DarkCyan");
            Console.WriteLine("5)DarkGray");
            Console.WriteLine("6)DarkGreen");
            Console.WriteLine("7)DarkMagenta");
            Console.WriteLine("8)DarkRed");
            Console.WriteLine("9)DarkYellow");
            Console.WriteLine("10)Gray");
            Console.WriteLine("11)Green");
            Console.WriteLine("12)Magenta");
            Console.WriteLine("13)Red");
            Console.WriteLine("14)White");
            Console.WriteLine("15)Yellow");

            int.TryParse(Console.ReadLine(), out choise);

            line.SetColor(choise);

            Console.WriteLine("Height");
            int.TryParse(Console.ReadLine(), out choise);
            line.Height = choise;

            Console.WriteLine("Width");
            int.TryParse(Console.ReadLine(), out choise);
            line.Width = choise;

            Console.WriteLine("MarginLeft");
            int.TryParse(Console.ReadLine(), out choise);
            line.MarginLeft = choise;

            Console.WriteLine("MarginTop");
            int.TryParse(Console.ReadLine(), out choise);
            line.MarginTop = choise;
        }

        public static int ChoiseIndex(List<Line> list)
        {
            int choise = 0;
            Console.WriteLine("0)Line");
            Console.WriteLine("1)Line");
            Console.WriteLine("2)Line");

            int.TryParse(Console.ReadLine(),out choise);

            if (choise > 0 && choise < 3)
            {
                return choise;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            bool isTrue = true;
            int index = 0;
            int choise;
            BinaryFormatter formatter = new BinaryFormatter();
            Line line = new Line();
            List<Line> list = new List<Line>
            {
                new Line
                {
                    Color = ConsoleColor.White,
                    Width = 1,
                    Height = 2,
                    MarginLeft = 0,
                    MarginTop = 0
                },
                new Line
                {
                    Color = ConsoleColor.White,
                    Width = 1,
                    Height = 2,
                    MarginLeft = 0,
                    MarginTop = 0
                },
                new Line
                {
                    Color = ConsoleColor.White,
                    Width = 1,
                    Height = 2,
                    MarginLeft = 0,
                    MarginTop = 0
                },
            };

            index = ChoiseIndex(list);

            do
            {
                Console.WriteLine("0)Show Line");
                Console.WriteLine("1)Edit Line");
                Console.WriteLine("2)Save");
                Console.WriteLine("3)Download");
                Console.WriteLine("4)Exit");

                int.TryParse(Console.ReadLine(), out choise);

                switch (choise)
                {
                    case 0: list[index].PrintLine(); break;
                    case 1: ChoiseColor(list[index]); break;
                    case 2:
                        if (!Directory.Exists(@"C:/data"))
                        {
                            Directory.CreateDirectory(@"C:/data");
                        }

                        using (FileStream file = File.Create(@"C:/data/Line.bin"))
                        {
                            formatter.Serialize(file, list);
                        }
                        break;
                    case 3:
                        using (FileStream file = File.OpenRead(@"C:/data/Line.bin"))
                        {
                            list = formatter.Deserialize(file) as List<Line>;
                        }
                        break;
                    case 4: isTrue = false; break;
                }
            }
            while (isTrue);

        }
    }
}
