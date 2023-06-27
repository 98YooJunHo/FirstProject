using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class CharacterSelect
    {
        int chrNumber = 0;
        // 커서 위치 (37,0)부터 시작 y 마지막 좌표 28
        public void Print(ref string chr)
        {
            Clear();

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
            Console.SetCursorPosition(59, 1);
            Console.Write(chr);
            Console.SetCursorPosition(38, 27);
            Console.Write("◀");
            Console.SetCursorPosition(84, 27);
            Console.Write("▶");
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
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            chr = "재선택";
                            return;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }

        void Clear()
        {
            for (int y = 0; y < 29; y++)
            {
                for (int x = 0; x < 49; x++)
                {
                    Console.SetCursorPosition(x + 37, y);
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
