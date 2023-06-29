using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FirstProject
{
    public class MainScene
    {
        // 커서 위치 (37,0)부터 시작 y 마지막 좌표 28
        public string Do(ref CharacterBase chr, ref int count, ref int act)
        {
            Clear();
            Random random = new Random();
            System.ConsoleKeyInfo playerInput;

            Expedition Run = new Expedition();
            List<Fate> fates = new List<Fate>();
            int _case = 0;
            int fateRoll = 1;
            int fatePos = 0;
            int eventPos = 0;
            int battlePos = 0;
            int bossPos = 0;
            int campPos = 0;
            string condition;
            // while 시작
            while (true)
            {
                if (chr.Get_Hp() == 0)
                {
                    return "타이틀로";
                }
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
                Console.SetCursorPosition(39, 1);
                Console.Write(chr.Get_Name());
                Console.SetCursorPosition(72, 2);
                Console.Write("보스정보 : b");
                Console.SetCursorPosition(55, 27);
                Console.Write("캐릭터 정보 : i");
                Console.SetCursorPosition(77, 1);
                Console.Write(chr.Get_Hp() + "/" + chr.Get_MaxHp());
                Console.SetCursorPosition(39, 2);
                Console.Write("액트 진행도:" + count + "/" + "12");
                playerInput = new ConsoleKeyInfo();
                _case = Run.Exp(act, count, _case);

                if ((_case == 5 && fates.Count == 0))
                {
                    fates = Run.Choice_Fate();
                }

                Run.Print(fates, _case, fateRoll);
                if (_case == 5)
                {
                    Console.SetCursorPosition(49 + fatePos * 13, 15);
                    Console.Write("▲");
                }

                if (_case == 1)
                {
                    Console.SetCursorPosition(38, 17 + campPos * 2);
                    Console.Write("▶");
                }

                if (_case == 2)
                {
                    Console.SetCursorPosition(38, 17 + bossPos * 2);
                    Console.Write("▶");
                }

                if (_case == 3)
                {
                    Console.SetCursorPosition(38, 17 + battlePos * 2);
                    Console.Write("▶");
                }

                if (_case == 4)
                {
                    Console.SetCursorPosition(38, 17 + eventPos * 2);
                    Console.Write("▶");
                }

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
                            System.ConsoleKeyInfo playerInput1 = new ConsoleKeyInfo();
                            while (playerInput1.Key != ConsoleKey.Enter)
                            {
                                playerInput1 = Console.ReadKey();
                                if (playerInput1.Key != ConsoleKey.Enter)
                                {
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    Console.Write(" ");
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    continue;
                                }
                            }
                            Clear_Info();
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
                            System.ConsoleKeyInfo playerInput1 = new ConsoleKeyInfo();
                            while (playerInput1.Key != ConsoleKey.Enter)
                            {
                                playerInput1 = Console.ReadKey();
                                if (playerInput1.Key != ConsoleKey.Enter)
                                {
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    Console.Write(" ");
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    continue;
                                }
                            }
                            Clear_Info();
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (_case == 4)
                            {
                                if (eventPos != 1)
                                {
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    Console.Write(" ");
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    eventPos += 1;
                                }
                            }

                            if (_case == 1)
                            {
                                if (campPos != 1)
                                {
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    Console.Write(" ");
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    campPos += 1;
                                }
                            }
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (_case == 4)
                            {
                                if (eventPos != 0)
                                {
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    Console.Write(" ");
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    eventPos -= 1;
                                }
                            }

                            if (_case == 1)
                            {
                                if (campPos != 0)
                                {
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    Console.Write(" ");
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    campPos -= 1;
                                }
                            }
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            if (_case == 5)
                            {
                                if (fatePos != 0)
                                {
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    Console.Write(" ");
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    fatePos -= 1;
                                }
                            }
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (_case == 5)
                            {
                                if (fatePos != 2)
                                {
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    Console.Write(" ");
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    fatePos += 1;
                                }
                            }
                            break;
                        }
                    case ConsoleKey.R:
                        {
                            if (_case == 5 && fateRoll == 1)
                            {
                                fateRoll -= 1;
                                fates = Run.Choice_Fate();
                            }
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            Clear_Info();
                            switch (_case)
                            {
                                // 운명 선택
                                case 5:
                                    {
                                        if (fatePos == 0)
                                        {
                                            chr.Add_Ability(fates[0].abilityName, fates[0].abilityLvl);
                                            _case = 0;
                                            count += 1;
                                            break;
                                        }

                                        if (fatePos == 1)
                                        {
                                            chr.Add_Ability(fates[1].abilityName, fates[1].abilityLvl);
                                            _case = 0;
                                            count += 1;
                                            break;
                                        }

                                        if (fatePos == 2)
                                        {
                                            chr.Add_Ability(fates[2].abilityName, fates[2].abilityLvl);
                                            _case = 0;
                                            count += 1;
                                            break;
                                        }
                                        break;
                                    }
                                // 적 조우
                                case 3:
                                    {
                                        if (battlePos == 0)
                                        {
                                            int who = random.Next(3);
                                            MonsterBase mob = null;
                                            if (act == 1)
                                            {
                                                switch (who)
                                                {
                                                    case 0:
                                                        mob = new UndeadArcher(1);
                                                        break;
                                                    case 1:
                                                        mob = new UndeadKnight(1);
                                                        break;
                                                    case 2:
                                                        mob = new UndeadShield(1);
                                                        break;
                                                }
                                            }
                                            BattleScene battle = new BattleScene();
                                            condition = battle.Do(chr, mob);
                                            if (condition == "배틀도중사망")
                                            {
                                                return "타이틀로";
                                            }
                                            _case = 0;
                                            count += 1;
                                            break;
                                        }
                                        break;
                                    }
                                // 이벤트
                                case 4:
                                    {
                                        if (eventPos == 0)
                                        {
                                            int Istoxic = random.Next(10);
                                            if (Istoxic < 2)
                                            {
                                                chr.Set_Hp(chr.Get_Hp() - chr.Get_MaxHp() / 10);
                                                Clear_Info();
                                                Console.SetCursorPosition(56, 15);
                                                Console.Write("썩은샘이였다");
                                                Thread.Sleep(1000);
                                                Console.SetCursorPosition(56, 15);
                                                Console.Write("            ");
                                            }
                                            else
                                            {
                                                chr.Set_Hp(chr.Get_Hp() + (chr.Get_MaxHp() / 10) * 2);
                                                Clear_Info();
                                                Console.SetCursorPosition(56, 15);
                                                Console.Write("맑은샘이였다");
                                                Thread.Sleep(1000);
                                                Console.SetCursorPosition(56, 15);
                                                Console.Write("            ");
                                            }

                                            _case = 0;
                                            count += 1;
                                            break;
                                        }
                                        else if (eventPos == 1)
                                        {
                                            eventPos = 0;
                                            _case = 0;
                                            count += 1;
                                            break;
                                        }
                                        break;
                                    }
                                // 캠핑
                                case 1:
                                    {
                                        if (campPos == 0)
                                        {
                                            chr.Set_Hp(chr.Get_Hp() + (chr.Get_MaxHp() / 10) * 5);
                                            Clear_Info();
                                            Console.SetCursorPosition(55, 15);
                                            Console.Write("푹쉬고 갑니다");
                                            Thread.Sleep(1000);
                                            Console.SetCursorPosition(55, 15);
                                            Console.Write("             ");
                                            _case = 0;
                                            count += 1;
                                            break;
                                        }
                                        else if (campPos == 1)
                                        {
                                            foreach (Skill skill in chr.skills)
                                            {
                                                skill.count = skill.fullCount;
                                            }
                                            Clear_Info();
                                            Console.SetCursorPosition(55, 15);
                                            Console.Write("잘쉬고 갑니다");
                                            Thread.Sleep(1000);
                                            Console.SetCursorPosition(55, 15);
                                            Console.Write("             ");
                                            _case = 0;
                                            count += 1;
                                            break;
                                        }
                                        break;
                                    }
                                // 보스전
                                case 2:
                                    {
                                        if (battlePos == 0)
                                        {
                                            MonsterBase mob = new StarveTree(1);
                                            BattleScene battle = new BattleScene();
                                            battle.Do(chr, mob);
                                            _case = 0;
                                            count = 0;
                                            Clear();
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
                                            Console.SetCursorPosition(52, 14);
                                            Console.Write("보스를 처치하였습니다");
                                            Thread.Sleep(1000);
                                            return "종료";
                                        }
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            return "종료";
                        }
                    default:
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                }   // switch();
                continue;
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
                    Console.Write(" ");
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
                Ability tempAbility = chr.Get_Ability(i);
                Console.SetCursorPosition(40, 9 + i);
                Console.Write(tempAbility.name + "Lv:" + tempAbility.lvl);
            }

            for (int i = 0; i < chr.Get_Skills_Length(); i++)
            {
                Skill tempSkill = chr.Get_Skill(i);
                Console.SetCursorPosition(41 + (i * 9), 20);
                Console.Write(tempSkill.name);
                Console.SetCursorPosition(42 + (i * 9), 21);
                if (tempSkill.count != -1)
                {
                    Console.Write(tempSkill.count);
                }
                else
                {
                    Console.Write("∞");
                }
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
