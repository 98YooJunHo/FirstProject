using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class CharacterSelect
    {
        int chrNumber = 0;
        // 커서 위치 (37,0)부터 시작 y 마지막 좌표 28
        public void Do(ref string chr)
        {
            Clear();

            Console.SetCursorPosition(39, 1);
            Console.Write("뒤로 가기 : q");

            if (chr == "기사")
            {
                chrNumber = 0;
            }

            if (chr == "도적")
            {
                chrNumber = 1;
            }

            if (chr == "궁수")
            {
                chrNumber = 2;
            }

            if (chr == "법사")
            {
                chrNumber = 3;
            }
            System.ConsoleKeyInfo playerInput;

            // 바깥 테두리영역표시
            for (int y = 0; y < 29; y++)
            {
                for (int x = 0; x < 49; x++)
                {
                    Console.SetCursorPosition(x + 37, y);
                    if (x == 0 && y == 0)
                    {
                        Console.Write("┌");
                    }
                    else if (x == 48 && y == 0)
                    {
                        Console.Write("┐");
                    }
                    else if (x == 0 && y == 28)
                    {
                        Console.Write("└");
                    }
                    else if (x == 48 && y == 28)
                    {
                        Console.Write("┘");
                    }
                    else if (y == 0 || y == 28)
                    {
                        Console.Write("─");
                    }
                    else if (x == 0 || x == 48)
                    {
                        Console.Write("│");
                    }
                    else
                    { /* empty */ }
                }
            }

            while (true)
            {
                for (int y = 5; y < 24; y++)
                {
                    Console.SetCursorPosition(38, y);
                    Console.Write("                                             ");
                }
                Console.SetCursorPosition(59, 1);
                Console.Write(chr);
                Console.SetCursorPosition(40, 27);
                Console.Write("◀");
                Console.SetCursorPosition(82, 27);
                Console.Write("▶");
                Print();
                playerInput = Console.ReadKey();
                switch (playerInput.Key)
                {
                    case ConsoleKey.RightArrow:
                        {
                            if (chrNumber == 3)
                            {
                                break;
                            }
                            else
                            {
                                chrNumber += 1;
                                if (chrNumber == 1)
                                {
                                    chr = "도적";
                                }

                                if (chrNumber == 2)
                                {
                                    chr = "궁수";
                                }

                                if (chrNumber == 3)
                                {
                                    chr = "법사";
                                }
                                Console.SetCursorPosition(59, 1);
                                Console.Write(chr);
                                continue;
                            }
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            if (chrNumber == 0)
                            {
                                break;
                            }
                            else
                            {
                                chrNumber -= 1;
                                if (chrNumber == 0)
                                {
                                    chr = "기사";
                                }

                                if (chrNumber == 1)
                                {
                                    chr = "도적";
                                }

                                if (chrNumber == 2)
                                {
                                    chr = "궁수";
                                }
                                Console.SetCursorPosition(59, 1);
                                Console.Write(chr);
                                continue;
                            }
                        }
                    case ConsoleKey.Enter:
                        {
                            if (chrNumber == 0)
                            {
                                return;
                            }

                            if (chrNumber == 1)
                            {
                                return;
                            }

                            if (chrNumber == 2)
                            {
                                return;
                            }

                            if (chrNumber == 3)
                            {
                                return;
                            }
                            break;
                        }
                    case ConsoleKey.Q:
                        {
                            chr = "재선택";
                            return;
                        }
                    default:
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                }
            }
        }

        void Clear()
        {
            for (int y = 1; y < 28; y++)
            {
                for (int x = 1; x < 48; x++)
                {
                    Console.SetCursorPosition(x + 37, y);
                    Console.WriteLine(" ");
                }
            }
        }

        void Print()
        {
            switch (chrNumber)
            {
                case 0:
                    {
                        Console.SetCursorPosition(45, 5);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 6);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣴⣶⣿⣿⣿⣿⣶⣦⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 7);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 8);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⣼⣿⣿⡿⠿⠟⠛⠉⠉⠉⠉⠛⠻⠿⢿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 9);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠘⠋⠉⢀⣀⣠⣤⣶⣾⣿⣿⣷⣶⣤⣄⣀⡀⠉⠙⠃⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 10);
                        Console.Write("⠀⠀⠀⠀⠀⣤⣴⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣦⣤⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 11);
                        Console.Write("⠀⠀⠀⠀⠀⣿⣿⣿⣿⡿⢿⣿⣿⠋⠙⣿⣿⠋⠙⣿⣿⡿⢿⣿⣿⣿⣿⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 12);
                        Console.Write("⠀⠀⠀⠀⠀⣿⣿⣿⣿⠀⠀⣿⣿⠀⠀⣿⣿⠀⠀⣿⣿⠀⠀⣿⣿⣿⣿⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 13);
                        Console.Write("⠀⠀⠀⠀⠀⣿⣿⣿⣿⠀⠀⣿⣿⠀⠀⣿⣿⠀⠀⣿⣿⠀⠀⣿⣿⣿⣿⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 14);
                        Console.Write("⠀⠀⠀⠀⠀⣿⣿⣿⣿⣦⣼⣿⣿⠀⠀⣿⣿⠀⠀⣿⣿⣧⣴⣿⣿⣿⣿⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 15);
                        Console.Write("⠀⠀⠀⠀⠀⠛⠿⣿⣿⣿⣿⣿⣿⣷⣾⣿⣿⣷⣾⣿⣿⣿⣿⣿⣿⠿⠛⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 16);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 17);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⣠⣶⣦⣄⡀⠉⠛⠿⣿⣿⠿⠛⠉⢀⣠⣴⣶⣄⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 18);
                        Console.Write("⠀⠀⠀⠀⠀⣤⣾⣿⣿⣿⣿⣿⣷⣦⣄⣀⣀⣠⣴⣾⣿⣿⣿⣿⣿⣷⣤⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 19);
                        Console.Write("⠀⠀⠀⠀⠀⠛⠻⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⠛⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 20);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠙⠛⠿⢿⣿⣿⡿⠿⠛⠛⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(56, 22);
                        Console.Write("철갑 Lv.3");
                        Console.SetCursorPosition(47, 23);
                        Console.Write("철갑은 받는 피해를 줄여줍니다");
                        Console.SetCursorPosition(40, 27);
                        Console.Write(" ");
                        break;
                    }
                case 1:
                    {
                        Console.SetCursorPosition(43, 5);
                        Console.Write("⠀⠀⠀⠀⠀⠀⣠⣤⣄⠀");
                        Console.SetCursorPosition(43, 6);
                        Console.Write("⠀⠀⠀⠀⠀⠸⣿⣿⠟⠀⠀");
                        Console.SetCursorPosition(43, 7);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠈⠁⠰⣿⣷⣦⡀⠀⠀⠀⠀⠀⠀⠀⣠⣤⣤⡤⠀⠀");
                        Console.SetCursorPosition(43, 8);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣿⣦⡀⠀⠀⣠⣴⣿⡿⠿⠿⠁⠀");
                        Console.SetCursorPosition(43, 9);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⣿⠗⣠⣶⡿⠛⣡⣄⠀⠀⠀");
                        Console.SetCursorPosition(43, 10);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⡿⠋⣠⡘⢿⣿⣷⣄⠀⠀");
                        Console.SetCursorPosition(43, 11);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⣿⠟⠠⣾⣿⣿⣦⠙⣿⣿⣆⠀⠀");
                        Console.SetCursorPosition(43, 12);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣿⣿⢋⣴⣤⡈⢿⣿⣿⣷⡌⢿⣿⣷⡀⠀");
                        Console.SetCursorPosition(43, 13);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⣿⣿⡇⠈⠻⣿⣿⣦⣈⠻⢿⣿⣄⠻⣿⣿⣆⠀");
                        Console.SetCursorPosition(43, 14);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⢈⡿⠿⠃⠀⠀⠈⠙⢿⣿⣷⣦⣉⠛⠄⠹⣿⣿⣧⡀");
                        Console.SetCursorPosition(43, 15);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿⣷⣤⣀⣹⣿⣿⣷⡄⠀");
                        Console.SetCursorPosition(43, 16);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⢿⣿⣿⣿⣿⣿⣿⣿⡀⠀");
                        Console.SetCursorPosition(43, 17);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣿⣿⡄⠀");
                        Console.SetCursorPosition(43, 18);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠻⢿⣿⣿⣿⡄⠀");
                        Console.SetCursorPosition(43, 19);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠿⣿⡄⠀");
                        Console.SetCursorPosition(43, 20);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠀");
                        Console.SetCursorPosition(56, 22);
                        Console.Write("광기 Lv.3");
                        Console.SetCursorPosition(46, 23);
                        Console.Write("광기는 치명타 확률을 올려줍니다");
                        break;
                    }
                case 2:
                    {
                        Console.SetCursorPosition(45, 5);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 6);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 7);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡾⠙⠿⣿⣶⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 8);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡞⠀⠀⠀⠀⠙⠻⣿⣿⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 9);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡟⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 10);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⣠⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 11);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⣰⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⣿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 12);
                        Console.Write("⠀⠀⠀⠀⠀⠈⣻⣿⣿⣿⣦⣄⣄⣠⣠⣠⣀⣄⣼⣿⣷⣨⣻⣶⣦⣄⡀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 13);
                        Console.Write("⠀⠀⠀⠀⠀⠠⠽⣿⠿⠿⠟⠉⠉⠉⠉⠉⠉⠉⢹⣿⡿⢉⡽⠿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 14);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠸⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠺⣿⣿⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 15);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠘⣧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 16);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣧⡀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 17);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢷⠀⠀⠀⠀⣠⣴⣿⡿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 18);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢷⣠⣶⣿⠿⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 19);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(45, 20);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.SetCursorPosition(56, 22);
                        Console.Write("분노 Lv.3");
                        Console.SetCursorPosition(44, 23);
                        Console.Write("분노는 전투 중 공격력을 올려줍니다");
                        break;
                    }
                case 3:
                    {
                        Console.SetCursorPosition(38, 5);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣶⣶⣶⣶⣦⣤⣄⡀⠀⠀⠀");
                        Console.SetCursorPosition(38, 6);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣦⣄⠀⠀");
                        Console.SetCursorPosition(38, 7);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⡿⠛⠛⠛⠛⠛⠛⠃⠀⠀");
                        Console.SetCursorPosition(38, 8);
                        Console.Write("⠀⠀⠀⠀   ⢀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀");
                        Console.SetCursorPosition(38, 9);
                        Console.Write("⠀⠀   ⢠⣾⣿⣿⣿⣿⣶⣤⣄⡀⠀⠀⠀⠀⠰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀");
                        Console.SetCursorPosition(38, 10);
                        Console.Write("⠀⠀   ⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⠆⠀⠀⠀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀");
                        Console.SetCursorPosition(38, 11);
                        Console.Write("⠀   ⠀⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿⠉⠀⠀⠀⠀⠀⠀⠀⠙⠻⢿⣿⣿⣿⣿⣿⣿⠀");
                        Console.SetCursorPosition(38, 12);
                        Console.Write("⠀   ⠀⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠛⠿⠿⠿⠀");
                        Console.SetCursorPosition(38, 13);
                        Console.Write("⠀⠀⠀   ⠈⢻⣿⣿⣿⣿⣿⣿⣿⣿⣷⣦⡀⠀");
                        Console.SetCursorPosition(38, 14);
                        Console.Write("⠀⠀⠀   ⠀⠀⠙⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣄⠀⠀⠀");
                        Console.SetCursorPosition(38, 15);
                        Console.Write("⠀⠀⠀⠀⠀   ⠀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣤⣄⡀⠀⠀⠀⠀⢰⣿⣿⣷⣤⡀");
                        Console.SetCursorPosition(38, 16);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣶⣾⣿⣿⣿⣿⣿⣷⣄⡀");
                        Console.SetCursorPosition(38, 17);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠉⠻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀");
                        Console.SetCursorPosition(38, 18);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠉⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀");
                        Console.SetCursorPosition(38, 19);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠉⠛⠻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠀ ");
                        Console.SetCursorPosition(38, 20);
                        Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ⠀⠀⠀⠈⠙⠛⠛⠛⠿⠿⠿⠿⠛⠛⠋⠀⠀⠀⠀");
                        Console.SetCursorPosition(56, 22);
                        Console.Write("맹독 Lv.3");
                        Console.SetCursorPosition(42, 23);
                        Console.Write("맹독은 전투 중 적에게 지속피해를 줍니다");
                        Console.SetCursorPosition(82, 27);
                        Console.Write(" ");
                        break;
                    }
            }
        }
    }
}
