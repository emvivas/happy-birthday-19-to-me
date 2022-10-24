/**
 * @title: Mis 19
 * @version: 1.0
 * @author: Vivas Rodríguez Emiliano (vivasrguez)
 * @date: 2020/11/10
*/

using System;
using static System.Console;
using static System.Threading.Thread;

namespace FelicidadesAMi
{
    internal sealed class Program
    {
        private const byte MAX_BORDER_X = 54, MAX_BORDER_Y = 42;
        private static readonly Random random = new Random(DateTime.Now.Millisecond);

        private static void Main()
        {
            string[] nicknames = { "Chepón, ", "Vivudo ", " y Viveishon son lo mismo   <3" };
            Title = "¡Felicitaciones para mí!   :D";
            for (byte x, y = 0; y < MAX_BORDER_Y; y++)
            {
                x = (byte)random.Next(0, MAX_BORDER_X);
                ForegroundColor = x % 2 != 0 ? ConsoleColor.Cyan : ConsoleColor.Yellow;
                SetCursorPosition(x, y);
                WriteLine('.');
                Sleep(100);
            }
            Sleep(900);
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            SetCursorPosition(0, MAX_BORDER_Y - 20);
            Sleep(1500);
            WriteLine("                                                       ");
            SetCursorPosition(0, MAX_BORDER_Y - 19);
            WriteLine("          Hola, soy Emiliano Vivas    ^_____^          ");
            SetCursorPosition(0, MAX_BORDER_Y - 18);
            WriteLine("                                                       ");
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
            SetCursorPosition(3, MAX_BORDER_Y - 13);
            Sleep(1750);
            WriteLine("Un tal 10 de noviembre del 2001, hace 19 años...");
            SetCursorPosition(13, MAX_BORDER_Y - 11);
            Sleep(2000);
            WriteLine("oriné al partero de mi madre");
            SetCursorPosition(8, MAX_BORDER_Y - 9);
            Sleep(1500);
            WriteLine("cuando me expulsó del vientre de ella.");
            SetCursorPosition(1, MAX_BORDER_Y - 4);
            Sleep(1250);
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            WriteLine("                                                     ");
            SetCursorPosition(1, MAX_BORDER_Y - 3);
            WriteLine("  ¡Mi primera acción en este mundo!    ¯\\_( >u<)_/¯  ");
            SetCursorPosition(1, MAX_BORDER_Y - 2);
            WriteLine("                                                     ");
            BackgroundColor = ConsoleColor.DarkYellow;
            ForegroundColor = ConsoleColor.DarkYellow;
            Sleep(1500);
            Number.Action();
            Sleep(1000);
            SetCursorPosition(19, 16);
            WriteLine("Te invito a mis XV");
            Sleep(1500);
            SetCursorPosition(19, 16);
            WriteLine("Te invito a mis ××");
            Sleep(750);
            SetCursorPosition(19, 16);
            WriteLine("Te invito a mis XIX");
            Sleep(750);
            SetCursorPosition(19, 16);
            WriteLine("×× ×××××× × ××× ×××");
            Sleep(750);
            SetCursorPosition(19, 16);
            WriteLine(" ¡Mis diecinueve!  ");
            SetCursorPosition(MAX_BORDER_X, MAX_BORDER_Y);
            Sleep(5000);
            Title = "";
            for (byte i = 0; i < 3; i++)
            {
                Title += nicknames[i];
                Firework.Action();
            }
            Title = "Objects in mirror are closer than they appear";
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.White;
            Greetings.Action();
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
            SetCursorPosition(10, MAX_BORDER_Y - 1);
            Sleep(1500);
            WriteLine("Presione una tecla para continuar...");
            ForegroundColor = ConsoleColor.Black;
            SetCursorPosition(MAX_BORDER_X - 7, MAX_BORDER_Y - 1);
            ReadKey();
            Environment.Exit(Environment.ExitCode);
        }

        private sealed class Number
        {
            private readonly byte number;
            private readonly Position position;

            public Number(byte number, byte x, byte y)
            {
                this.number = number;
                position = new Position(x, y);
            }

            public static void Action()
            {
                new Number(1, 16, 3).Draw();
                new Number(9, 36, 3).Draw();
            }

            public void Draw()
            {
                switch (number)
                {
                    case 1:
                        for (int y = position.Y; y < position.Y + 10; y++)
                        {
                            for (int x = position.X; x < position.X + 4; x++)
                            {
                                SetCursorPosition(x, y);
                                WriteLine('█');
                                Sleep(5);
                            }
                        }
                        break;

                    case 9:
                        for (int y = position.Y; y < position.Y + 6; y++)
                        {
                            for (int x = position.X - 9; x < position.X + 4; x++)
                            {
                                SetCursorPosition(x, y);
                                WriteLine('█');
                                Sleep(5);
                            }
                        }
                        for (int y = position.Y + 6; y < position.Y + 10; y++)
                        {
                            for (int x = position.X; x < position.X + 4; x++)
                            {
                                SetCursorPosition(x, y);
                                WriteLine('█');
                                Sleep(5);
                            }
                        }
                        BackgroundColor = ConsoleColor.Black;
                        for (int y = position.Y - 2; y < position.Y; y++)
                        {
                            for (int x = position.X - 5; x < position.X; x++)
                            {
                                SetCursorPosition(x, y + 4);
                                WriteLine(' ');
                                Sleep(5);
                            }
                        }
                        break;
                }
            }
        }

        private sealed class Firework
        {
            private readonly Position position;
            private readonly static ConsoleColor[] consoleColor = { ConsoleColor.DarkCyan, ConsoleColor.Cyan, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.DarkMagenta, ConsoleColor.Magenta, ConsoleColor.DarkRed, ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.Yellow, ConsoleColor.DarkBlue, ConsoleColor.Blue };

            public Firework(byte x, byte y)
            {
                position = new Position(x, y);
            }

            public static void Action()
            {
                for (byte i = 0, j = 16, k = 20; i < 3; i++, j += 10, k = (byte)(k == 20 ? 10 : 20))
                {
                    new Firework(j, k).Draw();
                    Clear();
                    for (byte x, y = 0; y < MAX_BORDER_Y; y += 2)
                    {
                        x = (byte)random.Next(0, MAX_BORDER_X - 4);
                        ForegroundColor = consoleColor[random.Next(0, 11)];
                        SetCursorPosition(x, y);
                        WriteLine('B');
                        ForegroundColor = consoleColor[random.Next(0, 11)];
                        SetCursorPosition(x + 1, y);
                        WriteLine('O');
                        ForegroundColor = consoleColor[random.Next(0, 11)];
                        SetCursorPosition(x + 2, y);
                        WriteLine('O');
                        ForegroundColor = consoleColor[random.Next(0, 11)];
                        SetCursorPosition(x + 3, y);
                        WriteLine('M');
                    }
                    Sleep(250);
                    Clear();
                }
            }

            public void Draw()
            {
                byte rocket = MAX_BORDER_Y;
                ForegroundColor = ConsoleColor.DarkYellow;
                do
                {
                    SetCursorPosition(position.X, rocket);
                    WriteLine('▒');
                    Sleep(25);
                    Clear();
                } while (--rocket > position.Y);
                ForegroundColor = ConsoleColor.White;
                SetCursorPosition(position.X, position.Y);
                WriteLine('■');
                rocket = (byte)random.Next(1, 12);
                ForegroundColor = consoleColor[rocket - 1];
                for (byte i = 0, x = 4, y = 2; i < 5; i++, x += 4, y += 2)
                {
                    ForegroundColor = i > 1 && rocket % 2 != 0 ? consoleColor[rocket] : consoleColor[rocket - 1];
                    try
                    {
                        SetCursorPosition(position.X, position.Y - y);
                        WriteLine('»');
                        SetCursorPosition(position.X + x, position.Y - y);
                        WriteLine('»');
                        SetCursorPosition(position.X + x, position.Y);
                        WriteLine('»');
                        SetCursorPosition(position.X + x, position.Y + y);
                        WriteLine('»');
                        SetCursorPosition(position.X, position.Y + y);
                        WriteLine('«');
                        SetCursorPosition(position.X - x, position.Y + y);
                        WriteLine('«');
                        SetCursorPosition(position.X - x, position.Y);
                        WriteLine('«');
                        SetCursorPosition(position.X - x, position.Y - y);
                        WriteLine('«');
                    }
                    catch (ArgumentOutOfRangeException) { }
                    finally { Sleep(75); }
                }
                Sleep(50);
                for (rocket = (byte)random.Next(5, 10); rocket > 0; rocket--)
                {
                    ForegroundColor = consoleColor[random.Next(0, 11)];
                    SetCursorPosition(random.Next(0, MAX_BORDER_X), random.Next(position.Y + 15, MAX_BORDER_Y));
                    WriteLine('*');
                    Sleep(35);
                }
                Sleep(165);
            }
        }

        private sealed class Greetings
        {
            public static void Action()
            {
                byte x, y;
                char[] regards = "Gracias por formar parte de mí y de mi historia".ToCharArray();
                for (y = 0; y < MAX_BORDER_Y - 2; y++)
                {
                    for (x = 0; x < MAX_BORDER_X + 1; x++)
                    {
                        SetCursorPosition(x, y);
                        WriteLine('█');
                        if (x == MAX_BORDER_X / 2 || x == MAX_BORDER_X)
                            Sleep(5);
                    }
                }
                x = 3;
                y = (byte)((MAX_BORDER_Y / 2) - x);
                SetCursorPosition(x + 1, y);
                Sleep(1500);
                ForegroundColor = ConsoleColor.Black;
                for (byte z = 0; z < regards.Length; z++)
                {
                    SetCursorPosition(x + z + 1, y);
                    WriteLine(regards[z]);
                    Sleep(150);
                }
                ForegroundColor = ConsoleColor.DarkBlue;
                SetCursorPosition(MAX_BORDER_X / 2 - x * 2, y + x);
                Sleep(1500);
                WriteLine("\\_( ^o^)_/");
            }
        }

        private sealed class Position
        {
            private readonly byte x, y;

            public Position(byte x, byte y)
            {
                this.x = x;
                this.y = y;
            }

            public byte X => x;
            public byte Y => y;
        }
    }
}