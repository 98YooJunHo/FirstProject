using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FirstProject
{
    public class Game
    {
        System.ConsoleKeyInfo playerInput;
        public void Start()
        {
            // 타이틀 씬 진입
            while (true)
            {
                CharacterBase player = new CharacterBase();
                string chr;
                int count = 1;
                int act = 1;
                TitleScene Title = new TitleScene();
                Title.Print();
                playerInput = Console.ReadKey();
                if (playerInput.Key == ConsoleKey.Q)
                {
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
                    Clear();
                    Console.SetCursorPosition(53, 14);
                    Console.Write("게임을 종료 합니다");
                    Console.SetCursorPosition(43, 27);
                    return;
                }

                if (playerInput.Key != ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(" ");
                }

                // 캐릭터 선택 씬 진입
                while (true)
                {
                    SelectScene Select = new SelectScene();
                    chr = Select.Do();

                    if (chr == "타이틀로")
                    {
                        break;
                    }

                    if (chr != null)
                    {
                        CharacterSelect cha = new CharacterSelect();
                        cha.Do(ref chr);

                        if (chr == "재선택")
                        {
                            continue;
                        }

                        if (chr != "재선택")
                        {
                            if (chr == "기사")
                            {
                                player = new Knight();
                            }

                            if (chr == "도적")
                            {
                                player = new Thief();
                            }

                            if (chr == "궁수")
                            {
                                player = new Archer();
                            }

                            if (chr == "법사")
                            {
                                player = new Mage();
                            }
                            break;
                        }
                    }
                }
                if (chr == "타이틀로")
                {
                    continue;
                }
                // 메인 씬 진입
                while (true)
                {
                    MainScene main = new MainScene();
                    chr = main.Do(ref player, ref count, ref act);
                    if (chr == "종료")
                    {
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
                        Clear();
                        Console.SetCursorPosition(53, 14);
                        Console.Write("게임을 종료 합니다");
                        Console.SetCursorPosition(42, 27);
                        return;
                    }

                    if (chr == "타이틀로")
                    {
                        break;
                    }
                    break;
                }
                continue;
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
