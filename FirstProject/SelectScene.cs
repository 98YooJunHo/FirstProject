using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class SelectScene
    {
        System.ConsoleKeyInfo playerInput;
        public string Print()
        {
            Console.SetCursorPosition(50, 1);
            Console.Write("탑 캐릭터 선택 씬 입니다");
            Console.SetCursorPosition(58, 3);
            Console.Write("기사");
            Console.SetCursorPosition(54, 26);
            Console.Write("방향키로 이동하고");
            Console.SetCursorPosition(52, 27);
            Console.Write("엔터키로 선택 하세요");
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
            Console.SetCursorPosition(40, 3);
            Console.Write("▶");
            while (true)
            {
                playerInput = Console.ReadKey();
                switch (playerInput.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (Console.CursorTop == 3)
                            {
                                break;
                            }
                            else
                            {
                                Console.SetCursorPosition(40, Console.CursorTop);
                                Console.Write(" ");
                                Console.SetCursorPosition(40, Console.CursorTop -= 2);
                                Console.Write("▶");
                                break;
                            }
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (Console.CursorTop == 9)
                            {
                                break;
                            }
                            else
                            {
                                Console.SetCursorPosition(40, Console.CursorTop);
                                Console.Write(" ");
                                Console.SetCursorPosition(40, Console.CursorTop += 2);
                                Console.Write("▶");
                                break;
                            }
                        }
                    case ConsoleKey.Enter:
                        {
                            if (Console.CursorTop == 3)
                            {
                                string chr = "기사";
                                Console.SetCursorPosition(54, 26);
                                Console.Write("                    ");
                                Console.SetCursorPosition(51, 27);
                                Console.WriteLine("기사를 선택하셨습니다");
                                return chr;
                            }
                            Console.SetCursorPosition(40, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(40, Console.CursorTop);
                            Console.Write("▶");
                            break;
                        }
                    default:
                        {
                            Console.SetCursorPosition(40, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(40, Console.CursorTop);
                            Console.Write("▶");
                            break;
                        }
                }
            }
        }
    }
}
