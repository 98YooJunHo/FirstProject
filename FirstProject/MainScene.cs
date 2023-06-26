using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class MainScene
    {
        // 커서 위치 (37,0)부터 시작 y 마지막 좌표 28
        public string Do(ref CharacterBase chr, ref int count, ref int act)
        {
            Clear();
            System.ConsoleKeyInfo playerInput;
            Console.SetCursorPosition(39, 1);
            Console.Write(chr.Get_Name());
            Console.SetCursorPosition(77, 1);
            Console.Write(chr.Get_Hp() + "/" + chr.Get_MaxHp());
            Console.SetCursorPosition(39, 2);
            Console.Write("액트 진행도:" + count + "/" + "12");
            Console.SetCursorPosition(72, 2);
            Console.Write("보스정보 : b");
            Console.SetCursorPosition(55, 27);
            Console.Write("캐릭터 정보 : i");
            // 바깥 테두리
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
            // 맨 윗 칸 구분
            for (int x = 0; x < 49; x++)
            {
                Console.SetCursorPosition(x + 37, 3);
                if (x == 0)
                {
                    Console.Write("├");
                }
                else if (x == 48)
                {
                    Console.Write("┤");
                }
                else
                {
                    Console.Write("─");
                }
            }
            // 맨 아래 칸 구분
            for (int x = 0; x < 49; x++)
            {
                Console.SetCursorPosition(x + 37, 26);
                if (x == 0)
                {
                    Console.Write("├");
                }
                else if (x == 48)
                {
                    Console.Write("┤");
                }
                else
                {
                    Console.Write("─");
                }
            }

            Expedition Run = new Expedition();
            List<Fate> fates = new List<Fate>();
            int _case = 0;
            // while 시작
            while (true)
            {
                _case = Run.Exp(ref act, ref count, _case);
                if (Console.CursorTop != 18 || Console.CursorTop != 24)  // 캐릭터 정보창이나 보스 정보창이 떠 있을 경우가 아닐 때
                {
                    if (_case == 5 && fates.Count == 0)
                    {
                        fates = Run.Choice_Fate(fates, _case);
                    }
                }

                Clear_Info();
                Run.Print(fates, _case);

                playerInput = Console.ReadKey();
                // switch() 시작
                switch (playerInput.Key)
                {
                    case ConsoleKey.I:
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Clear_Info();
                            Print_ChrInfo(chr);
                            while (true)
                            {
                                System.ConsoleKeyInfo playerInput1;
                                playerInput1 = Console.ReadKey();
                                if (playerInput1.Key == ConsoleKey.Enter)
                                {
                                    break;
                                }
                                else 
                                {
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    Console.Write(" ");
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                }
                            }
                            break;
                        }
                    case ConsoleKey.B:
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Clear_Info();
                            MonsterBase boss = new MonsterBase();
                            if (act == 1)
                            {
                                boss = new StarveTree(1);
                            }
                            Print_BossInfo(boss);
                            while (true)
                            {
                                System.ConsoleKeyInfo playerInput1;
                                playerInput1 = Console.ReadKey();
                                if (playerInput1.Key == ConsoleKey.Enter)
                                {
                                    break;
                                }
                                else 
                                {
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    Console.Write(" ");
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                }
                            }
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            return ("종료");
                        }
                    default:
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                }   // switch();
            }   // while;
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

        void Clear_Info()
        {
            for (int y = 4; y < 26; y++)
            {
                for (int x = 1; x < 48; x++)
                {
                    Console.SetCursorPosition(x + 37, y);
                    Console.WriteLine(" ");
                }
            }
        }

        void Print_ChrInfo(CharacterBase chr)
        {
            Console.SetCursorPosition(56, 7);
            Console.Write("캐릭터 정보");
            Console.SetCursorPosition(59, 14);
            Console.Write(chr.Get_Name());
            Console.SetCursorPosition(74, 9);
            Console.Write("공격력:" + chr.Get_Atk());
            Console.SetCursorPosition(74, 10);
            Console.Write("방어력:" + chr.Get_Arm());
            Console.SetCursorPosition(74, 11);
            Console.Write("크리율:" + chr.Get_Cri());
            Console.SetCursorPosition(74, 12);
            Console.Write("회피율:" + chr.Get_Avoid());

            for (int i = 0; i < chr.Get_Ability_Length(); i++)
            {
                Console.SetCursorPosition(40, 9 + i);
                Ability tempAbility = chr.Get_Ability(i);
                Console.Write(tempAbility.name + "Lv:" + tempAbility.lvl);
            }

            for (int i = 0; i < chr.Get_Skills_Length(); i++)
            {
                Console.SetCursorPosition(43 + (i * 5), 20);
                Skill tempSkill = chr.Get_Skills(i);
                Console.Write(tempSkill.name);
                Console.SetCursorPosition(44 + (i * 5), 21);
                Console.Write(tempSkill.cooltime);
            }

            Console.SetCursorPosition(59, 24);
            Console.Write("확인");
        }

        void Print_BossInfo(MonsterBase boss)
        {
            Console.SetCursorPosition(57, 9);
            Console.Write("보스 정보");
            Console.SetCursorPosition(56, 11);
            Console.Write(boss.Get_Name());
            Console.SetCursorPosition(48, 13);
            Console.Write("체  력:" + boss.Get_Hp());
            Console.SetCursorPosition(66, 13);
            Console.Write("공격력:" + boss.Get_Atk());
            Console.SetCursorPosition(48, 15);
            Console.Write("크리율:" + boss.Get_Cri());
            Console.SetCursorPosition(66, 15);
            Console.Write("회피율:" + boss.Get_Avoid());
            Console.SetCursorPosition(59, 18);
            Console.Write("확인");
        }


    }
}
