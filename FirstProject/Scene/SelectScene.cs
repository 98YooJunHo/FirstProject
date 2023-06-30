using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FirstProject
{
    public class SelectScene
    {
        public string Do()
        {
            Clear();
            System.ConsoleKeyInfo playerInput;
            Console.SetCursorPosition(39, 1);
            Console.Write("뒤로 가기 : q");
            Console.SetCursorPosition(56, 1);
            Console.Write("캐릭터 선택");
            Console.SetCursorPosition(59, 3);
            Console.Write("기사");
            Console.SetCursorPosition(59, 5);
            Console.Write("도적");
            Console.SetCursorPosition(59, 7);
            Console.Write("궁수");
            Console.SetCursorPosition(59, 9);
            Console.Write("법사");
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
            Console.SetCursorPosition(50, 3);
            Console.Write("▶");
            Console.SetCursorPosition(71, 3);
            Console.Write("◀");
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
                            Console.SetCursorPosition(50, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(71, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(50, Console.CursorTop -= 2);
                            Console.Write("▶");
                            Console.SetCursorPosition(71, Console.CursorTop);
                            Console.Write("◀");
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (Console.CursorTop == 9)
                            {
                                break;
                            }
                            Console.SetCursorPosition(50, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(71, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(50, Console.CursorTop += 2);
                            Console.Write("▶");
                            Console.SetCursorPosition(71, Console.CursorTop);
                            Console.Write("◀");
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            if (Console.CursorTop == 3)
                            {
                                return "기사";
                            }
                            if (Console.CursorTop == 5)
                            {
                                return "도적";
                            }
                            if (Console.CursorTop == 7)
                            {
                                return "궁수";
                            }
                            if (Console.CursorTop == 9)
                            {
                                return "법사";
                            }
                            Console.SetCursorPosition(50, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(50, Console.CursorTop);
                            Console.Write("▶");
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            break;
                        }
                    case ConsoleKey.Q:
                        {
                            return "타이틀로";
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
    }
}
