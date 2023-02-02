using System.Runtime.InteropServices;
using System;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Media;
using System.Collections;
using NAudio.Wave;
using NAudio;
using NAudio.CoreAudioApi;
using System.ComponentModel;
using System.Windows.Forms;
using Windows.UI.Core;
using Windows.UI.Xaml;

namespace System.Media
{



    public class ConsoleProgressBar
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Length { get; set; }

        public ConsoleProgressBar(int left, int top, int length)
        {
            Left = left;
            Top = top;
            Length = length;
        }

        public void ShowProgress(int progress)
        {
            Console.CursorVisible = false;
            if (progress > Length || progress < 0)
                throw new ArgumentException($"Invalid progress value, must be between 0 and {Length} but actual {progress}.");
            (int left, int top) = Console.GetCursorPosition();
            Console.SetCursorPosition(Left, Top);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"{new string('▓', progress)}{new string('░', Length - progress)}");
            Console.SetCursorPosition(left, top);
            Console.ResetColor();
        }

    }

    class Program
    {

        static void Main(string[] args)
        {

            void ShowCup(int a, int b)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(a, b - 1); Console.WriteLine("  █   █   █░");
                Console.SetCursorPosition(a, b); Console.WriteLine("  █▄▄▄█▄▄▄█░");
                Console.SetCursorPosition(a, b + 1); Console.WriteLine("▄▄█████████░▄▄");
                Console.SetCursorPosition(a, b + 2); Console.WriteLine("█░█████████░ ░");
                Console.SetCursorPosition(a, b + 3); Console.WriteLine("█░ ███████░  ░");
                Console.SetCursorPosition(a, b + 4); Console.WriteLine(" █░ █████░  ░");
                Console.SetCursorPosition(a, b + 5); Console.WriteLine("  █▄▄████▄▄░");
                Console.SetCursorPosition(a, b + 6); Console.WriteLine("     ███░");
                Console.SetCursorPosition(a, b + 7); Console.WriteLine("    ▄████▄");
                Console.SetCursorPosition(a, b + 8); Console.WriteLine("   ███████░");
                Console.ResetColor();
            }
            void ShowSky(int a, int b, int step)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(0, 0);
                if (step == 100)
                {
                    Console.WriteLine("                                  ▄██▄                                                      ▄████████▄                  ");
                }
                if (step == 200)
                {
                    Console.WriteLine("                                 ▄██▄                                                      ▄████████▄                   ");
                }
                if (step == 300)
                {
                    Console.WriteLine("                                ▄██▄                                                      ▄████████▄                    ");
                }
                if (step == 400)
                {
                    Console.WriteLine("                               ▄██▄                                                      ▄████████▄                     ");
                }
                if (step == 500)
                {
                    Console.WriteLine("                              ▄██▄                                                      ▄████████▄                      ");
                }
                if (step == 600)
                {
                    Console.WriteLine("                             ▄██▄                                                      ▄████████▄                       ");
                }
                if (step == 700)
                {
                    Console.WriteLine("                            ▄██▄                                                      ▄████████▄                        ");
                }
                if (step == 800)
                {
                    Console.WriteLine("                           ▄██▄                                                      ▄████████▄                         ");
                }
                if (step == 900)
                {
                    Console.WriteLine("                          ▄██▄                                                      ▄████████▄                          ");
                }
                if (step == 1000)
                {
                    Console.WriteLine("                         ▄██▄                                                      ▄████████▄                           ");
                }
                if (step == 1100)
                {
                    Console.WriteLine("                        ▄██▄                                                      ▄████████▄                            ");
                }
                if (step == 1200)
                {
                    Console.WriteLine("                       ▄██▄                                                      ▄████████▄                             ");
                }
                if (step == 1300)
                {
                    Console.WriteLine("                      ▄██▄                                                      ▄████████▄                              ");
                }
                if (step == 1400)
                {
                    Console.WriteLine("                     ▄██▄                                                      ▄████████▄                               ");
                }
                if (step == 1500)
                {
                    Console.WriteLine("                    ▄██▄                                                      ▄████████▄                                ");
                }
                if (step == 1600)
                {
                    Console.WriteLine("                   ▄██▄                                                      ▄████████▄                                 ");
                }
                if (step == 1700)
                {
                    Console.WriteLine("                  ▄██▄                                                      ▄████████▄                                 ▄");
                }
                if (step == 1800)
                {
                    Console.WriteLine("                 ▄██▄                                                      ▄████████▄                                 ▄█");
                }
                if (step == 1900)
                {
                    Console.WriteLine("                ▄██▄                                                      ▄████████▄                                 ▄██");
                }
                if (step == 2000)
                {
                    Console.WriteLine("               ▄██▄                                                      ▄████████▄                                 ▄██▄");
                }
                if (step == 2100)
                {
                    Console.WriteLine("              ▄██▄                                                      ▄████████▄                                 ▄██▄ ");
                }
                if (step == 2200)
                {
                    Console.WriteLine("             ▄██▄                                                      ▄████████▄                                 ▄██▄  ");
                }
                if (step == 2300)
                {
                    Console.WriteLine("            ▄██▄                                                      ▄████████▄                                 ▄██▄   ");
                }
                if (step == 2400)
                {
                    Console.WriteLine("           ▄██▄                                                      ▄████████▄                                 ▄██▄    ");
                }
                if (step == 2500)
                {
                    Console.WriteLine("          ▄██▄                                                      ▄████████▄                                 ▄██▄     ");
                }
                if (step == 2600)
                {
                    Console.WriteLine("         ▄██▄                                                      ▄████████▄                                 ▄██▄      ");
                }
                if (step == 2700)
                {
                    Console.WriteLine("        ▄██▄                                                      ▄████████▄                                 ▄██▄       ");
                }
                if (step == 2800)
                {
                    Console.WriteLine("       ▄██▄                                                      ▄████████▄                                 ▄██▄        ");
                }
                if (step == 2900)
                {
                    Console.WriteLine("      ▄██▄                                                      ▄████████▄                                 ▄██▄         ");
                }
                if (step == 3000)
                {
                    Console.WriteLine("     ▄██▄                                                      ▄████████▄                                 ▄██▄          ");
                }
                if (step == 3100)
                {
                    Console.WriteLine("    ▄██▄                                                      ▄████████▄                                 ▄██▄           ");
                }
                if (step == 3200)
                {
                    Console.WriteLine("   ▄██▄                                                      ▄████████▄                                 ▄██▄            ");
                }
                if (step == 3300)
                {
                    Console.WriteLine("  ▄██▄                                                      ▄████████▄                                 ▄██▄             ");
                }
                if (step == 3400)
                {
                    Console.WriteLine(" ▄██▄                                                      ▄████████▄                                 ▄██▄              ");
                }
                if (step == 3500)
                {
                    Console.WriteLine("▄██▄                                                      ▄████████▄                                 ▄██▄               ");
                }
                if (step == 3600)
                {
                    Console.WriteLine("██▄                                                      ▄████████▄                                 ▄██▄                ▄");
                }
                if (step == 3700)
                {
                    Console.WriteLine("█▄                                                      ▄████████▄                                 ▄██▄                ▄█");
                }
                if (step == 3800)
                {
                    Console.WriteLine("▄                                                      ▄████████▄                                 ▄██▄                ▄██");
                }
                if (step == 3900)
                {
                    Console.WriteLine("                                                      ▄████████▄                                 ▄██▄                ▄██▄");
                }
                if (step == 4000)
                {
                    Console.WriteLine("                                                     ▄████████▄                                 ▄██▄                ▄██▄ ");
                }
                if (step == 4100)
                {
                    Console.WriteLine("                                                    ▄████████▄                                 ▄██▄                ▄██▄  ");
                }
                if (step == 4200)
                {
                    Console.WriteLine("                                                   ▄████████▄                                 ▄██▄                ▄██▄   ");
                }
                if (step == 4300)
                {
                    Console.WriteLine("                                                 ▄████████▄                                  ▄██▄                ▄██▄    ");
                }

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.DarkGray;



            }
            void AddObj(int a, int b)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Blue;

                Console.SetCursorPosition(a, b + 1); Console.WriteLine("         |");
                Console.SetCursorPosition(a, b + 2); Console.WriteLine("  ▄███████▄");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(a, b + 3); Console.WriteLine("▄███████████▄");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(a, b + 4); Console.WriteLine("█████████████");
                Console.SetCursorPosition(a, b + 5); Console.WriteLine("█[|]█[|]█[|]█");
                Console.SetCursorPosition(a, b + 6); Console.WriteLine("█████████████");

                Console.ResetColor();
            }
            void AddObj2(int a, int b)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.Blue;


                Console.SetCursorPosition(a, b + 2); Console.WriteLine(" █  █  █  █  █");
                Console.SetCursorPosition(a, b + 3); Console.WriteLine("▄█████████████▄");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(a, b + 4); Console.WriteLine("███████████████"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(a, b + 5); Console.Write("███[]█[|]█[]███"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("||||||||||||||||||||");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(a, b + 6); Console.WriteLine("███████████████");

                Console.ResetColor();
            }
            void startMenu()
            {




                WMPLib.WindowsMediaPlayer axMusicPlayer = new WMPLib.WindowsMediaPlayer();
                string path = Path.GetFullPath("start.mp3");
                path = Path.GetFullPath("start.mp3");
                axMusicPlayer.URL = path;
                axMusicPlayer.settings.setMode("loop", true);
                axMusicPlayer.controls.play();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██");
                Console.WriteLine("  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██");
                Console.WriteLine("██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██");
                Console.WriteLine("  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██");
                Console.WriteLine("██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                Console.WriteLine("                _   _ ______ ______ _____    ______ ____  _____     _____ _____  ______ ______ _____ ");
                Console.WriteLine("               | \\ | |  ____|  ____|  __ \\  |  ____/ __ \\|  __ \\   / ____|  __ \\|  ____|  ____|  __ \\");
                Console.WriteLine("               |  \\| | |__  | |__  | |  | | | |__ | |  | | |__) | | (___ | |__) | |__  | |__  | |  | | ");
                Console.WriteLine("               | . ` |  __| |  __| | |  | | |  __|| |  | |  _  /   \\___ \\|  ___/|  __| |  __| | |  | |");
                Console.WriteLine("               | |\\  | |____| |____| |__| | | |   | |__| | | \\ \\   ____) | |    | |____| |____| |__| |");
                Console.WriteLine("               |_| \\_|______|______|_____/  |_|    \\____/|_|  \\_\\ |_____/|_|    |______|______|_____/");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("                                                U N D E R G R O U N D");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;





                Console.ResetColor();
                Console.WriteLine();
                string title = "         ";


                int maxProgress = 100;
                ConsoleProgressBar bar = new ConsoleProgressBar(title.Length, 25, maxProgress);
                long previous = -1;
                long total = 1000000000;
                for (long i = 0; i < total; i++)
                {
                    long progress = i * maxProgress / total;
                    if (progress != previous)
                    {
                        bar.ShowProgress((int)progress);
                        previous = progress;
                    }
                }
                bar.ShowProgress(maxProgress);
                string strt = "PRESS ANY KEY FOR START";

                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(9, 25);
                Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████");
                //string strt = "Press any key for start";

                int x = 47;
                int y = 22;
                int flh = 0;

                Console.SetCursorPosition(x, y);
                //Console.WriteLine(strt);

                while (!Console.KeyAvailable)
                {
                    x = 47;

                    for (int i = 0; i < strt.Length; i++)
                    {
                        Console.SetCursorPosition(x, y);
                        if (flh == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        if (flh == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        if (flh == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        }
                        if (flh == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        }
                        if (flh == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        }
                        if (flh == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        x++;

                        Console.WriteLine(strt[i]);
                        Thread.Sleep(1);

                    }

                    flh++;
                    if (flh == 6)
                    {
                        flh = 0;
                    }

                }
                x = 47;
                flh = 0;
                //Console.WriteLine("                                               Press any key for start");
                Console.ReadKey();


                axMusicPlayer.controls.stop();
                Console.Clear();
            }

            void track()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetWindowSize(120, 29);
                //SoundPlayer sound = new SoundPlayer("outrow.waw");
                Console.WriteLine("                                       ▄██▄                                                      ▄████████▄             ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("██████████████████"); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("████"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("██████████████████████████████████████████████████"); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("████"); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("████████████████████████████████████████████");
                Console.Write("█████████████████"); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("██████"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████████████████████████████████████████████████"); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("██████"); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("███████████████████████████████████████████");
                Console.Write("█████████████████"); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("██████"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████████████████████████████████████████████████"); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("██████"); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("███████████████████████████████████████████");
                Console.Write("███████████████████"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████████████████████████████████████████████████████"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██"); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("█████████████████████████████████████████████");
                Console.Write("███████████████████"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("████████████████████████████████████████████████████"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("██"); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("█████████████████████████████████████████████");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("                       wwWWWww                           wwWWWww                         wwWWWww                 wwWWWww");
                Console.WriteLine("     wwWWWww                           wwWWWww                           wwWWWww                        wwWWWww         ");
                for (int i = 0; i < 30; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("██");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("██");
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("      -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -   ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                for (int i = 0; i < 30; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("██");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("██");
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("           oooooo             oooooo             oooooo             oooooo             oooooo             oooooo        ");
                for (int i = 0; i < 30; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("██");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("██");
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -   ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                for (int i = 0; i < 30; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("██");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("██");
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("OOOOOO           OOOOOO              OOOOOO             OOOOOO               OOOOOO            OOOOOO             OOOOOO");
                for (int i = 0; i < 30; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("██");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("██");
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -   ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                for (int i = 0; i < 30; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("██");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("██");
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                AddObj(35, 0);
                AddObj2(85, 0);

                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            void Car1(int start3, int razm2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(start3 - 1, 15);
                Console.Write(" ");
                Console.SetCursorPosition(115, 15);
                Console.Write(" ");
                Console.SetCursorPosition(116, 15);
                Console.Write(" ");
                Console.SetCursorPosition(117, 15);
                Console.Write(" ");
                Console.SetCursorPosition(118, 15);
                Console.Write(" ");
                Console.SetCursorPosition(119, 15);
                Console.Write(" ");
                Console.SetCursorPosition(115, 16);
                Console.Write("-");
                Console.SetCursorPosition(116, 16);
                Console.Write(" ");
                Console.SetCursorPosition(117, 16);
                Console.Write(" ");
                Console.SetCursorPosition(118, 16);
                Console.Write(" ");
                Console.SetCursorPosition(start3 - 1, 17);
                Console.Write(" ");
                Console.SetCursorPosition(start3 - 1, 16);
                Console.Write(" ");
                //
                Console.SetCursorPosition(start3 - 1, 16);
                if (razm2 % 5 == 0 && razm2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("-");
                }

                Console.Write(" ");
                //
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(start3, 15);
                Console.Write("█████▄");
                Console.SetCursorPosition(start3, 16);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("▀▀--▀▀");
            }
            void Car2(int start2, int razm)
            {
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(start2 - 1, 9);
                Console.Write(" ");
                Console.SetCursorPosition(115, 9);
                Console.Write(" ");
                Console.SetCursorPosition(116, 9);
                Console.Write(" ");
                Console.SetCursorPosition(117, 9);
                Console.Write(" ");
                Console.SetCursorPosition(118, 9);
                Console.Write(" ");
                Console.SetCursorPosition(119, 9);
                Console.Write(" ");
                Console.SetCursorPosition(115, 10);
                Console.Write("-");
                Console.SetCursorPosition(116, 10);
                Console.Write(" ");
                Console.SetCursorPosition(117, 10);
                Console.Write(" ");
                Console.SetCursorPosition(118, 10);
                Console.Write(" ");
                Console.SetCursorPosition(start2 - 1, 11);
                Console.Write(" ");
                Console.SetCursorPosition(start2 - 1, 10);
                Console.Write(" ");
                //
                Console.SetCursorPosition(start2 - 1, 10);
                if (razm % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("-");
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(start2, 9);
                Console.Write("▄███▄▄");
                Console.SetCursorPosition(start2, 10);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("▀----▀");
            }
            void Car3(int start, int razm3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(start - 1, 21);
                Console.Write(" ");
                Console.SetCursorPosition(115, 21);
                Console.Write(" ");
                Console.SetCursorPosition(116, 21);
                Console.Write(" ");
                Console.SetCursorPosition(117, 21);
                Console.Write(" ");
                Console.SetCursorPosition(118, 21);
                Console.Write(" ");
                Console.SetCursorPosition(119, 21);
                Console.Write(" ");
                Console.SetCursorPosition(115, 22);
                Console.Write("-");
                Console.SetCursorPosition(116, 22);
                Console.Write(" ");
                Console.SetCursorPosition(117, 22);
                Console.Write(" ");
                Console.SetCursorPosition(118, 22);
                Console.Write(" ");
                Console.SetCursorPosition(start - 1, 23);
                Console.Write(" ");
                Console.SetCursorPosition(start - 1, 22);
                Console.Write(" ");
                //

                //
                Console.SetCursorPosition(start - 1, 22);
                if (razm3 % 5 == 0 && razm3 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("-");
                }

                Console.Write(" ");
                //

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(start, 21);
                Console.Write("█▄▄██▄");
                Console.SetCursorPosition(start, 22);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("▀▀---▀");
            }
            void CleanRoad(int Laps, int Lap2, int Lap1, int Lap3)
            {
                if (Lap2 == Laps)
                {
                    Console.SetCursorPosition(0, 15);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -   ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                }
                if (Lap1 == Laps)
                {
                    Console.SetCursorPosition(0, 9);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -   ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                }
                if (Lap3 == Laps)
                {
                    Console.SetCursorPosition(0, 21);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -    -   ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                }
            }
            void ShowStat(int Lap1, int Lap2, int Lap3, int Laps)


            {
                Console.SetCursorPosition(10, 27);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("            LAPS:");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("        Blue: " + Lap1 + "/" + Laps); Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("                 Red: " + Lap2 + "/" + Laps); Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("                  Green: " + Lap3 + "/" + Laps);
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            void TrafficLights()
            {
                WMPLib.WindowsMediaPlayer axMusicPlayer = new WMPLib.WindowsMediaPlayer();
                string path;
                //1
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(0, 0);

                {
                    Console.WriteLine("                                      ▄██▄                                                      ▄████████▄             ");
                }
                //
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(0, 0);
                //2
                {
                    Console.WriteLine("                                     ▄██▄                                                      ▄████████▄               ");
                }
                //
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Red;


                Console.SetCursorPosition(53, 4);
                Console.Write("▄██");
                Console.SetCursorPosition(54, 4);
                Console.Write("██▄");
                Console.SetCursorPosition(53, 5);
                Console.Write("▀██");
                Console.SetCursorPosition(54, 5);
                Console.Write("██▀");

                Console.SetCursorPosition(60, 4);
                Console.Write("▄██");
                Console.SetCursorPosition(61, 4);
                Console.Write("██▄");
                Console.SetCursorPosition(60, 5);
                Console.Write("▀██");
                Console.SetCursorPosition(61, 5);
                Console.Write("██▀");

                Console.SetCursorPosition(67, 4);
                Console.Write("▄██");
                Console.SetCursorPosition(68, 4);
                Console.Write("██▄");
                Console.SetCursorPosition(67, 5);
                Console.Write("▀██");
                Console.SetCursorPosition(68, 5);
                Console.Write("██▀");
                path = Path.GetFullPath("beep.mp3");
                axMusicPlayer.URL = path;
                axMusicPlayer.settings.setMode("loop", true);
                axMusicPlayer.controls.play();
                Thread.Sleep(500);
                axMusicPlayer.controls.stop();
                Thread.Sleep(500);
                //3
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(0, 0);

                {
                    Console.WriteLine("                                    ▄██▄                                                      ▄████████▄                ");
                }
                //
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;


                Console.SetCursorPosition(53, 4);
                Console.Write("▄██");
                Console.SetCursorPosition(54, 4);
                Console.Write("██▄");
                Console.SetCursorPosition(53, 5);
                Console.Write("▀██");
                Console.SetCursorPosition(54, 5);
                Console.Write("██▀");

                Console.SetCursorPosition(60, 4);
                Console.Write("▄██");
                Console.SetCursorPosition(61, 4);
                Console.Write("██▄");
                Console.SetCursorPosition(60, 5);
                Console.Write("▀██");
                Console.SetCursorPosition(61, 5);
                Console.Write("██▀");

                Console.SetCursorPosition(67, 4);
                Console.Write("▄██");
                Console.SetCursorPosition(68, 4);
                Console.Write("██▄");
                Console.SetCursorPosition(67, 5);
                Console.Write("▀██");
                Console.SetCursorPosition(68, 5);
                Console.Write("██▀");

                path = Path.GetFullPath("beep.mp3");
                axMusicPlayer.URL = path;
                axMusicPlayer.settings.setMode("loop", true);
                axMusicPlayer.controls.play();
                Thread.Sleep(500);
                axMusicPlayer.controls.stop();
                Thread.Sleep(500);
                //4
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(0, 0);

                {
                    Console.WriteLine("                                   ▄██▄                                                      ▄████████▄                 ");
                }
                //
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Green;


                Console.SetCursorPosition(53, 4);
                Console.Write("▄██");
                Console.SetCursorPosition(54, 4);
                Console.Write("██▄");
                Console.SetCursorPosition(53, 5);
                Console.Write("▀██");
                Console.SetCursorPosition(54, 5);
                Console.Write("██▀");

                Console.SetCursorPosition(60, 4);
                Console.Write("▄██");
                Console.SetCursorPosition(61, 4);
                Console.Write("██▄");
                Console.SetCursorPosition(60, 5);
                Console.Write("▀██");
                Console.SetCursorPosition(61, 5);
                Console.Write("██▀");

                Console.SetCursorPosition(67, 4);
                Console.Write("▄██");
                Console.SetCursorPosition(68, 4);
                Console.Write("██▄");
                Console.SetCursorPosition(67, 5);
                Console.Write("▀██");
                Console.SetCursorPosition(68, 5);
                Console.Write("██▀");



            }
            void TrafficLight2()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Blue;


                Console.SetCursorPosition(53, 4);
                Console.Write("███");
                Console.SetCursorPosition(54, 4);
                Console.Write("███");
                Console.SetCursorPosition(53, 5);
                Console.Write("███");
                Console.SetCursorPosition(54, 5);
                Console.Write("███");

                Console.SetCursorPosition(60, 4);
                Console.Write("███");
                Console.SetCursorPosition(61, 4);
                Console.Write("███");
                Console.SetCursorPosition(60, 5);
                Console.Write("███");
                Console.SetCursorPosition(61, 5);
                Console.Write("███");

                Console.SetCursorPosition(67, 4);
                Console.Write("███");
                Console.SetCursorPosition(68, 4);
                Console.Write("███");
                Console.SetCursorPosition(67, 5);
                Console.Write("███");
                Console.SetCursorPosition(68, 5);
                Console.Write("███");



                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            void End1()
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██");
                Console.WriteLine("  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██");
                Console.WriteLine("██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██");
                Console.WriteLine("  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██");
                Console.WriteLine("██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██  ██");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            WMPLib.WindowsMediaPlayer axMusicPlayer = new WMPLib.WindowsMediaPlayer();
            string path = Path.GetFullPath("start.mp3");

            int TotalRed = 0;
            int TotalGreen = 0;
            int TotalBlue = 0;
            int Laps = 5;
            while (true)
            {
                startMenu();
                track();

                int start = 1;
                int start2 = 1;
                int start3 = 1;
                int razm = 0;
                int razm2 = 0;
                int razm3 = 0;
                int Lap1 = 0;
                int Lap2 = 0;
                int Lap3 = 0;
                int skyStep = 0;
                int toStart = 1;
                ArrayList arrWin = new ArrayList();

                while (true)
                {
                    ShowSky(0, 0, skyStep);
                    skyStep++;

                    int Speed = new Random().Next(1, 100);
                    if (toStart == 1)
                    {
                        Speed = 30;
                    }
                    if (Speed < 66 && Lap1 != Laps)
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            start2++;
                            Car2(start2, razm);


                            if (start2 > 115)
                            {
                                start2 = 1;
                                Console.ForegroundColor = ConsoleColor.DarkGray;

                                Console.SetCursorPosition(119, 10);
                                Console.Write("█");
                                Console.SetCursorPosition(start2 - 1, 11);
                                Console.Write(" ");
                                Console.SetCursorPosition(start2 - 1, 10);
                                Console.Write(" ");
                                Lap1++;
                            }
                        }
                        razm++;

                    }


                    if (toStart == 1)
                    {
                        Speed = 40;
                    }
                    if (Speed > 33 & Lap2 != Laps)
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            start3++;
                            //////////////////////////////////
                            Car1(start3, razm2);

                            ///////////////////////////////////////////
                            if (start3 > 115)
                            {
                                start3 = 1;
                                Console.ForegroundColor = ConsoleColor.DarkGray;

                                Console.SetCursorPosition(119, 16);
                                Console.Write("█");
                                Console.SetCursorPosition(start3 - 1, 17);
                                Console.Write(" ");
                                Console.SetCursorPosition(start3 - 1, 16);
                                Console.Write(" ");
                                Lap2++;

                            }

                        }

                        razm2++;
                    }

                    if (toStart == 1)
                    {
                        Speed = 40;
                    }
                    if (Speed > 17 && Speed < 83 & Lap3 != Laps)
                    {
                        for (int i = 0; i < 1; i++)
                        {

                            start++;
                            Car3(start, razm3);


                            if (start > 115)
                            {
                                start = 1;
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.SetCursorPosition(119, 22);
                                Console.Write("█");
                                Console.SetCursorPosition(start - 1, 23);
                                Console.Write(" ");
                                Console.SetCursorPosition(start - 1, 22);
                                Console.Write(" ");
                                Lap3++;
                            }

                        }
                        razm3++;

                    }

                    CleanRoad(Laps, Lap2, Lap1, Lap3);
                    Thread.Sleep(5);

                    ShowStat(Lap1, Lap2, Lap3, Laps);
                    if (toStart == 1)
                    {
                        toStart--;

                        TrafficLights();
                        path = Path.GetFullPath("race.mp3");
                        axMusicPlayer.URL = path;
                        axMusicPlayer.settings.setMode("loop", true);
                        axMusicPlayer.controls.play();
                        Thread.Sleep(500);
                        TrafficLight2();




                    }
                    if (Lap1 == Laps)
                    {
                        int count = 0;
                        foreach (var item in arrWin)
                        {
                            if (item == "Blue")
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            arrWin.Add("Blue");
                        }

                    }
                    if (Lap2 == Laps)
                    {
                        int count = 0;
                        foreach (var item in arrWin)
                        {
                            if (item == "Red")
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            arrWin.Add("Red");
                        }
                    }
                    if (Lap3 == Laps)
                    {
                        int count = 0;
                        foreach (var item in arrWin)
                        {
                            if (item == "Green")
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            arrWin.Add("Green");
                        }
                    }
                    if (Lap1 == Laps && Lap2 == Laps && Lap3 == Laps)
                    {

                        axMusicPlayer.controls.stop();
                        path = Path.GetFullPath("Finish.mp3");
                        axMusicPlayer.URL = path;
                        axMusicPlayer.settings.setMode("loop", true);
                        axMusicPlayer.controls.play();
                        for (int i = 0; i < 15; i++)
                        {
                            Thread.Sleep(300);
                            for (int j = 0; j < 80; j++)
                            {
                                int Salut1 = new Random().Next(0, 25);
                                int Salut2 = new Random().Next(0, 119);
                                int SalutColor = new Random().Next(1, 7);

                                if (SalutColor == 1)
                                {

                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.SetCursorPosition(Salut2, Salut1);
                                    Console.Write("  ");
                                }
                                if (SalutColor == 2)
                                {

                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.SetCursorPosition(Salut2, Salut1);
                                    Console.Write("  ");
                                }
                                if (SalutColor == 3)
                                {

                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.SetCursorPosition(Salut2, Salut1);
                                    Console.Write("  ");
                                }
                                if (SalutColor == 4)
                                {

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.SetCursorPosition(Salut2, Salut1);
                                    Console.Write("  ");
                                }
                                if (SalutColor == 5)
                                {

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    Console.SetCursorPosition(Salut2, Salut1);
                                    Console.Write("  ");
                                }
                                if (SalutColor == 6)
                                {

                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.BackgroundColor = ConsoleColor.Magenta;
                                    Console.SetCursorPosition(Salut2, Salut1);
                                    Console.Write("  ");
                                }



                            }

                        }


                        //Thread.Sleep(2100);
                        axMusicPlayer.controls.stop();

                        break;
                    }


                }

                End1();
                skyStep = 0;
                axMusicPlayer.controls.stop();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("                                                      RACE IS OVER!");
                Thread.Sleep(1500);
                Console.WriteLine("                                                          WINERS:");
                Console.WriteLine();
                if (arrWin[0] == "Blue")
                {
                    TotalBlue += 1;
                }
                if (arrWin[0] == "Red")
                {
                    TotalRed += 1;
                }
                if (arrWin[0] == "Green")
                {
                    TotalGreen += 1;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("                                                        1st: ");
                if (arrWin[0] == "Blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(arrWin[0]);
                }
                if (arrWin[0] == "Red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(arrWin[0]);
                }
                if (arrWin[0] == "Green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(arrWin[0]);
                }
                ///////
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("                                                        2nd: ");
                if (arrWin[1] == "Blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(arrWin[1]);
                }
                if (arrWin[1] == "Red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(arrWin[1]);
                }
                if (arrWin[1] == "Green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(arrWin[1]);
                }
                ////////////////
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("                                                        3rd: ");
                if (arrWin[2] == "Blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(arrWin[2]);
                }
                if (arrWin[2] == "Red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(arrWin[2]);
                }
                if (arrWin[2] == "Green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(arrWin[2]);
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine();


                Console.WriteLine("                          TOTAL WINS:");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("                   Blue: " + TotalBlue + " ");
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("                            Red: " + TotalRed + " ");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("                                     Green: " + TotalGreen + " ");
                axMusicPlayer.controls.stop();

                path = Path.GetFullPath("win.mp3");
                axMusicPlayer.URL = path;
                axMusicPlayer.settings.setMode("loop", true);
                axMusicPlayer.controls.play();
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine();
                ShowCup(80, 16);
                //////////////////////
                string strt = "PRESS ANY KEY FOR RESTART";
                int x = 48;
                int y = 27;
                int flh = 0;

                Console.SetCursorPosition(x, y);


                while (!Console.KeyAvailable)
                {
                    x = 48;

                    for (int i = 0; i < strt.Length; i++)
                    {
                        Console.SetCursorPosition(x, y);
                        if (flh == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        if (flh == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        if (flh == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        }
                        if (flh == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        }
                        if (flh == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        }
                        if (flh == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        x++;

                        Console.WriteLine(strt[i]);
                        Thread.Sleep(1);

                    }

                    flh++;
                    if (flh == 6)
                    {
                        flh = 0;
                    }

                }
                x = 48;
                flh = 0;
                //////////////////////
                Console.ForegroundColor = ConsoleColor.White;



                Console.ReadKey();
                axMusicPlayer.controls.stop();
                Console.Clear();

            }

        }
    }
}






