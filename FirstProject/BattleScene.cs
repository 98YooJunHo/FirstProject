﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Threading;

namespace FirstProject
{
    public class BattleScene
    {
        Random random = new Random();
        public string Do(CharacterBase chr, MonsterBase mob)
        {
            Clear();
            System.ConsoleKeyInfo playerInput;
            System.ConsoleKeyInfo rewardInput;
            int count = 1;
            int reduction = 0;
            int shield = 0;
            int poison = 0;
            int getPoison = 0;
            int inBattleAtk = chr.Get_Atk();
            int inBattleArm = chr.Get_Arm();
            int inBattleCri = chr.Get_Cri();
            int inBattleAvoid = chr.Get_Avoid();

            // 바깥 테두리
            for (int y = 0; y < 29; y++)
            {
                for (int x = 0; x < 49; x++)
                {
                    if (x == 0 && y == 0)
                    {
                        Console.SetCursorPosition(x + 37, y);
                        Console.Write("┌");
                    }
                    else if (x == 48 && y == 0)
                    {
                        Console.SetCursorPosition(x + 37, y);
                        Console.Write("┐");
                    }
                    else if (x == 0 && y == 28)
                    {
                        Console.SetCursorPosition(x + 37, y);
                        Console.Write("└");
                    }
                    else if (x == 48 && y == 28)
                    {
                        Console.SetCursorPosition(x + 37, y);
                        Console.Write("┘");
                    }
                    else if (y == 0 || y == 28)
                    {
                        Console.SetCursorPosition(x + 37, y);
                        Console.Write("─");
                    }
                    else if (x == 0 || x == 48)
                    {
                        Console.SetCursorPosition(x + 37, y);
                        Console.Write("│");
                    }
                    else
                    { /* empty */ }
                }
            }
            // 턴 수 바로 아래 선
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
            // 적 체력 바로 위 선
            for (int x = 0; x < 49; x++)
            {
                Console.SetCursorPosition(x + 37, 8);
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
            // 적 체력 바로 아래 선 && 전투 진행상황 위 선
            for (int x = 0; x < 49; x++)
            {
                Console.SetCursorPosition(x + 37, 10);
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
            // 전투 진행상황 아래 선
            for (int x = 0; x < 49; x++)
            {
                Console.SetCursorPosition(x + 37, 16);
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
            // 플레이어 체력 위 선
            for (int x = 0; x < 49; x++)
            {
                Console.SetCursorPosition(x + 37, 22);
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
            // 플레이어 체력 아래 선
            for (int x = 0; x < 49; x++)
            {
                Console.SetCursorPosition(x + 37, 24);
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

            // 능력 체크
            foreach(Ability ability in chr.abilities)
            {
                if (ability.name == "맹독")
                {
                    int increase = 0;
                    if (ability.lvl == 1)
                    {
                        increase += 1;
                    }

                    for (int i = 0; i <= ability.lvl; i++)
                    {
                        increase += i/2;
                    }

                    poison = increase;
                }

                if (ability.name == "분노")
                {
                    int increase = 0;
                    for (int i = 0; i <= ability.lvl; i++)
                    {
                        increase += i;
                    }

                    inBattleAtk = chr.Get_Atk() + increase;
                }

                if (ability.name == "철갑")
                {
                    int increase = 0;
                    for (int i = 0; i <= ability.lvl; i++)
                    {
                        increase += i;
                    }

                    reduction = increase;
                }

                if (ability.name == "광기")
                {
                    int increase = 0;
                    for (int i = 0; i <= ability.lvl; i++)
                    {
                        increase += i;
                    }

                    inBattleCri = chr.Get_Cri() + increase;
                }

                if (ability.name == "회피")
                {
                    int increase = 0;
                    for (int i = 0; i <= ability.lvl; i++)
                    {
                        increase += i;
                    }

                    inBattleAvoid = chr.Get_Avoid() + increase;
                }
            }

            Console.SetCursorPosition(59, 9);
            Console.Write("          ");
            Console.SetCursorPosition(59, 9);
            Console.Write(mob.Get_Hp() + "/" + mob.Get_MaxHp());

            int pos = 0;
            while (true)
            {
                Console.SetCursorPosition(38, 20);
                Console.Write("피해감소");
                Console.SetCursorPosition(41, 21);
                Console.Write(reduction);
                int pCri = random.Next(100);
                int pAvoid = random.Next(100);
                int mCri = random.Next(100);
                int mAvoid = random.Next(100);
                playerInput = new ConsoleKeyInfo();
                // 진행중인 턴 및 현재 체력 표시
                #region
                Console.SetCursorPosition(39, 2);
                Console.Write("진행 중인 턴:" + count);
                Console.SetCursorPosition(55, 5);
                Console.Write(mob.Get_Name());
                Console.SetCursorPosition(60, 19);
                Console.Write(chr.Get_Name());
                Console.SetCursorPosition(58, 23);
                Console.Write("          ");
                Console.SetCursorPosition(58, 23);
                Console.Write(chr.Get_Hp() + "/" + chr.Get_MaxHp());
                Console.SetCursorPosition(38, 15);
                #endregion
                Console.Write("적이 공격을 준비합니다");
                for (int i = 0; i < chr.Get_Skills_Length(); i++)
                {
                    Skill tempSkill = chr.Get_Skill(i);
                    Console.SetCursorPosition(41 + (i * 9), 25);
                    Console.Write(tempSkill.name);
                    Console.SetCursorPosition(42 + (i * 9), 26);
                    if (tempSkill.count != -1)
                    {
                        Console.Write(tempSkill.count);
                    }
                    else
                    {
                        Console.Write("∞");
                    }
                }
                Console.SetCursorPosition(43 + pos * 9, 27);
                Console.Write("▲");
                playerInput = Console.ReadKey();
                switch (playerInput.Key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (pos != 0)
                            {
                                Console.SetCursorPosition(43 + pos * 9, 27);
                                Console.Write(" ");
                                pos -= 1;
                            }
                            continue;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (pos != chr.abilities.Count - 1)
                            {
                                Console.SetCursorPosition(43 + pos * 9, 27);
                                Console.Write(" ");
                                pos += 1;
                            }
                            continue;
                        }
                    case ConsoleKey.Enter:
                        {
                            // 전투 진행상황 초기화
                            #region
                            Console.SetCursorPosition(38, 11);
                            Console.Write("                                          ");
                            Console.SetCursorPosition(38, 12);
                            Console.Write("                                          ");
                            Console.SetCursorPosition(38, 13);
                            Console.Write("                                          ");
                            Console.SetCursorPosition(38, 14);
                            Console.Write("                                          ");
                            Console.SetCursorPosition(38, 15);
                            Console.Write("                                          ");
                            #endregion
                            switch (pos)
                            {
                                case 0:
                                    {
                                        if (mAvoid < mob.Get_Avoid())
                                        {
                                            Console.SetCursorPosition(38, 11);
                                            Console.Write("(적 회피)");
                                        }
                                        else if (pCri < inBattleCri)
                                        {
                                            Console.SetCursorPosition(38, 11);
                                            Console.Write("내 공격 " + inBattleAtk * 16 / 10 + "의 피해(크리티컬)");
                                            mob.Set_Hp(mob.Get_Hp() - inBattleAtk * 16 / 10);
                                            getPoison += poison;

                                            if (getPoison != 0)
                                            {
                                                Console.SetCursorPosition(80, 6);
                                                Console.Write("중독");
                                                Console.SetCursorPosition(81, 7);
                                                Console.Write(getPoison);
                                            }
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(38, 11);
                                            Console.Write("내 공격 " + inBattleAtk + "의 피해");
                                            mob.Set_Hp(mob.Get_Hp() - inBattleAtk);
                                            getPoison += poison;

                                            if (getPoison != 0)
                                            {
                                                Console.SetCursorPosition(80, 6);
                                                Console.Write("중독");
                                                Console.SetCursorPosition(81, 7);
                                                Console.Write(getPoison);
                                            }
                                        }
                                        Console.SetCursorPosition(59, 9);
                                        Console.Write("          ");
                                        Console.SetCursorPosition(59, 9);
                                        Console.Write(mob.Get_Hp() + "/" + mob.Get_MaxHp());
                                        Thread.Sleep(100);
                                        break;
                                    }
                                case 1:
                                    {
                                        if (chr.skills[1].count == 0)
                                        {
                                            break;
                                        }

                                        shield = Convert.ToInt32(chr.Get_Arm() * 1.2f);
                                        Console.SetCursorPosition(48, 20);
                                        Console.Write("방어");
                                        Console.SetCursorPosition(49, 21);
                                        Console.Write(shield);
                                        Thread.Sleep(100);
                                        chr.skills[1].count -= 1;
                                        break;
                                    }

                            }
                            count += 1;
                            break;
                        }
                    default:
                        {
                            continue;
                        }
                }

                if (getPoison != 0)
                {
                    Console.SetCursorPosition(38, 12);
                    Console.Write("중독 " + getPoison + "의 피해");
                    mob.Set_Hp(mob.Get_Hp() - getPoison);
                    Console.SetCursorPosition(59, 9);
                    Console.Write("          ");
                    Console.SetCursorPosition(59, 9);
                    Console.Write(mob.Get_Hp() + "/" + mob.Get_MaxHp());
                    getPoison -= 1;
                    if (getPoison < 0)
                    {
                        getPoison = 0;
                    }
                    Thread.Sleep(100);

                    if (getPoison != 0)
                    {
                        Console.SetCursorPosition(80, 6);
                        Console.Write("중독");
                        Console.SetCursorPosition(81, 7);
                        Console.Write("  ");
                        Console.SetCursorPosition(81, 7);
                        Console.Write(getPoison);
                    }
                    else
                    {
                        Console.SetCursorPosition(80, 6);
                        Console.Write("    ");
                        Console.SetCursorPosition(81, 7);
                        Console.Write("  ");
                    }
                    Thread.Sleep(100);
                }

                if (mob.Get_Hp() == 0)
                {
                    int rCount = 1;
                    int iPos = 0;

                    Console.SetCursorPosition(38, 12);
                    Console.Write("                                          ");
                    Console.SetCursorPosition(38, 12);
                    Console.Write("적 사망");
                    Thread.Sleep(100);
                    // 진행중인 턴 및 현재 체력 표시
                    #region
                    Console.SetCursorPosition(39, 2);
                    Console.Write("진행 중인 턴:" + count);
                    Console.SetCursorPosition(55, 5);
                    Console.Write(mob.Get_Name());
                    Console.SetCursorPosition(59, 9);
                    Console.Write("          ");
                    Console.SetCursorPosition(59, 9);
                    Console.Write(mob.Get_Hp() + "/" + mob.Get_MaxHp());
                    Console.SetCursorPosition(60, 19);
                    Console.Write(chr.Get_Name());
                    Console.SetCursorPosition(58, 23);
                    Console.Write("          ");
                    Console.SetCursorPosition(58, 23);
                    Console.Write(chr.Get_Hp() + "/" + chr.Get_MaxHp());
                    Console.SetCursorPosition(38, 15);
                    #endregion

                    // 보상 리스트 표시
                    List<Item> items_ = Choice_Item();
                    #region
                    Clear_Info();
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
                    Console.SetCursorPosition(62, 7);
                    Console.Write("새로고침 가능 횟수 :" + rCount + "회");
                    Console.SetCursorPosition(53, 9);
                    Console.Write("보상을 선택하세요");
                    Console.SetCursorPosition(46, 13);
                    Console.Write(items_[0].name);
                    Console.SetCursorPosition(59, 13);
                    Console.Write(items_[1].name);
                    Console.SetCursorPosition(72, 13);
                    Console.Write(items_[2].name);
                    Console.SetCursorPosition(45, 14);
                    Console.Write(items_[0].abilityName + "lv." + items_[0].abilityLvl);
                    Console.SetCursorPosition(58, 14);
                    Console.Write(items_[1].abilityName + "lv." + items_[1].abilityLvl);
                    Console.SetCursorPosition(71, 14);
                    Console.Write(items_[2].abilityName + "lv." + items_[2].abilityLvl);
                    // 아이템 스탯 표시
                    Console.SetCursorPosition(44, 15);
                    if (items_[0].atk != 0)
                    {
                        Console.Write("공격력 + " + items_[0].atk);
                    }
                    if (items_[0].maxHp != 0)
                    {
                        Console.Write("최대체력 + " + items_[0].maxHp);
                    }
                    if (items_[0].arm != 0)
                    {
                        Console.Write("방어력 + " + items_[0].arm);
                    }
                    if (items_[0].cri != 0)
                    {
                        Console.Write("크리율 + " + items_[0].cri);
                    }
                    if (items_[0].avoid != 0)
                    {
                        Console.Write("회피율 + " + items_[0].avoid);
                    }
                    Console.SetCursorPosition(57, 15);
                    if (items_[1].atk != 0)
                    {
                        Console.Write("공격력 + " + items_[1].atk);
                    }
                    if (items_[1].maxHp != 0)
                    {
                        Console.Write("최대체력 + " + items_[1].maxHp);
                    }
                    if (items_[1].arm != 0)
                    {
                        Console.Write("방어력 + " + items_[1].arm);
                    }
                    if (items_[1].cri != 0)
                    {
                        Console.Write("크리율 + " + items_[1].cri);
                    }
                    if (items_[1].avoid != 0)
                    {
                        Console.Write("회피율 + " + items_[1].avoid);
                    }
                    Console.SetCursorPosition(70, 15);
                    if (items_[2].atk != 0)
                    {
                        Console.Write("공격력 + " + items_[2].atk);
                    }
                    if (items_[2].maxHp != 0)
                    {
                        Console.Write("최대체력 + " + items_[2].maxHp);
                    }
                    if (items_[2].arm != 0)
                    {
                        Console.Write("방어력 + " + items_[2].arm);
                    }
                    if (items_[2].cri != 0)
                    {
                        Console.Write("크리율 + " + items_[2].cri);
                    }
                    if (items_[2].avoid != 0)
                    {
                        Console.Write("회피율 + " + items_[2].avoid);
                    }
                    #endregion

                    // 보상 선택
                    while (true)
                    {
                        rewardInput = new ConsoleKeyInfo();
                        Console.SetCursorPosition(49 + iPos * 13, 16);
                        Console.Write("▲");

                        rewardInput = Console.ReadKey();
                        switch (rewardInput.Key)
                        {
                            case ConsoleKey.LeftArrow:
                                {
                                    if (iPos != 0)
                                    {
                                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                        Console.Write(" ");
                                        iPos -= 1;
                                    }
                                    continue;
                                }
                            case ConsoleKey.RightArrow:
                                {
                                    if (iPos != 2)
                                    {
                                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                        Console.Write(" ");
                                        iPos += 1;
                                    }
                                    continue;
                                }
                            case ConsoleKey.Enter:
                                {
                                    Add_Reward(chr, items_[iPos]);
                                    Clear_Info();
                                    break;
                                }
                            case ConsoleKey.R:
                                {
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    Console.Write(" ");
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    if(rCount == 1)
                                    {
                                        items_ = Choice_Item();
                                        // 보상 정보 초기화 후 재출력
                                        #region
                                        Clear_Info();
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
                                        Console.SetCursorPosition(53, 9);
                                        Console.Write("보상을 선택하세요");
                                        Console.SetCursorPosition(46, 13);
                                        Console.Write(items_[0].name);
                                        Console.SetCursorPosition(59, 13);
                                        Console.Write(items_[1].name);
                                        Console.SetCursorPosition(72, 13);
                                        Console.Write(items_[2].name);
                                        Console.SetCursorPosition(45, 14);
                                        Console.Write(items_[0].abilityName + "lv." + items_[0].abilityLvl);
                                        Console.SetCursorPosition(58, 14);
                                        Console.Write(items_[1].abilityName + "lv." + items_[1].abilityLvl);
                                        Console.SetCursorPosition(71, 14);
                                        Console.Write(items_[2].abilityName + "lv." + items_[2].abilityLvl);
                                        // 아이템 스탯 표시
                                        Console.SetCursorPosition(44, 15);
                                        if (items_[0].atk != 0)
                                        {
                                            Console.Write("공격력 + " + items_[0].atk);
                                        }
                                        if (items_[0].maxHp != 0)
                                        {
                                            Console.Write("최대체력 + " + items_[0].maxHp);
                                        }
                                        if (items_[0].arm != 0)
                                        {
                                            Console.Write("방어력 + " + items_[0].arm);
                                        }
                                        if (items_[0].cri != 0)
                                        {
                                            Console.Write("크리율 + " + items_[0].cri);
                                        }
                                        if (items_[0].avoid != 0)
                                        {
                                            Console.Write("회피율 + " + items_[0].avoid);
                                        }
                                        Console.SetCursorPosition(57, 15);
                                        if (items_[1].atk != 0)
                                        {
                                            Console.Write("공격력 + " + items_[1].atk);
                                        }
                                        if (items_[1].maxHp != 0)
                                        {
                                            Console.Write("최대체력 + " + items_[1].maxHp);
                                        }
                                        if (items_[1].arm != 0)
                                        {
                                            Console.Write("방어력 + " + items_[1].arm);
                                        }
                                        if (items_[1].cri != 0)
                                        {
                                            Console.Write("크리율 + " + items_[1].cri);
                                        }
                                        if (items_[1].avoid != 0)
                                        {
                                            Console.Write("회피율 + " + items_[1].avoid);
                                        }
                                        Console.SetCursorPosition(70, 15);
                                        if (items_[2].atk != 0)
                                        {
                                            Console.Write("공격력 + " + items_[2].atk);
                                        }
                                        if (items_[2].maxHp != 0)
                                        {
                                            Console.Write("최대체력 + " + items_[2].maxHp);
                                        }
                                        if (items_[2].arm != 0)
                                        {
                                            Console.Write("방어력 + " + items_[2].arm);
                                        }
                                        if (items_[2].cri != 0)
                                        {
                                            Console.Write("크리율 + " + items_[2].cri);
                                        }
                                        if (items_[2].avoid != 0)
                                        {
                                            Console.Write("회피율 + " + items_[2].avoid);
                                        }
                                        #endregion
                                        rCount -= 1;
                                        Console.SetCursorPosition(62, 7);
                                        Console.Write("새로고침 가능 횟수 :" + rCount + "회");
                                        continue;
                                    }
                                    continue;
                                }
                            default:
                                {
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    Console.Write(" ");
                                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                    continue;
                                }
                        }
                        break;
                    }
                    return "배틀윈";
                }


                if (pAvoid < inBattleAvoid)
                {
                    Console.SetCursorPosition(38, 13);
                    Console.Write("(회피)");
                }
                else if (mCri < mob.Get_Cri())
                {
                    int getDamage = (mob.Get_Atk() * 16 / 10) - reduction - shield;
                    if((mob.Get_Atk() * 16 / 10) - reduction - shield < 0)
                    {
                        getDamage = 0;
                    }
                    Console.SetCursorPosition(38, 13);
                    Console.Write("적 공격 " + getDamage + "의 피해(크리티컬)");
                    chr.Set_Hp(chr.Get_Hp() - getDamage);
                }
                else
                {
                    int getDamage = mob.Get_Atk() - reduction - shield;
                    if (mob.Get_Atk() - reduction - shield < 0)
                    {
                        getDamage = 0;
                    }
                    Console.SetCursorPosition(38, 13);
                    Console.Write("적 공격 " + getDamage + "의 피해");
                    chr.Set_Hp(chr.Get_Hp() - getDamage);
                }
                Thread.Sleep(100);
                shield = 0;
                Console.SetCursorPosition(48, 20);
                Console.Write("    ");
                Console.SetCursorPosition(49, 21);
                Console.Write("   ");

                if (chr.Get_Hp() <= 0)
                {
                    chr.Set_Hp(0);
                    Console.SetCursorPosition(38, 14);
                    Console.Write("플레이어 사망, 아무키나 눌러서 타이틀로 갑니다");
                    // 진행중인 턴 및 현재 체력 표시
                    #region
                    Console.SetCursorPosition(39, 2);
                    Console.Write("진행 중인 턴:" + count);
                    Console.SetCursorPosition(55, 5);
                    Console.Write(mob.Get_Name());
                    Console.SetCursorPosition(59, 9);
                    Console.Write("          ");
                    Console.SetCursorPosition(59, 9);
                    Console.Write(mob.Get_Hp() + "/" + mob.Get_MaxHp());
                    Console.SetCursorPosition(60, 19);
                    Console.Write(chr.Get_Name());
                    Console.SetCursorPosition(58, 23);
                    Console.Write("          ");
                    Console.SetCursorPosition(58, 23);
                    Console.Write(chr.Get_Hp() + "/" + chr.Get_MaxHp());
                    Console.SetCursorPosition(38, 15);
                    #endregion

                    Console.ReadKey();
                    return "배틀도중사망";
                }
            }   // while
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
            for (int y = 4; y < 28; y++)
            {
                for (int x = 1; x < 48; x++)
                {
                    Console.SetCursorPosition(x + 37, y);
                    Console.Write(" ");
                }
            }
        }

        public List<Item> Choice_Item()
        {
            ItemList items = new ItemList();
            List<Item> selectedItems = new List<Item>();

            for (int i = 0; i < 1000; i++)
            {
                int randomIndex = random.Next(items.list.Count - 1);
                Item temp = new Item();
                temp = items.list[randomIndex];
                items.list[randomIndex] = items.list[randomIndex + 1];
                items.list[randomIndex + 1] = temp;
            }

            for (int i = 0; i < 3; i++)
            {
                Item temp = items.list[i];
                selectedItems.Add(temp);
            }

            return selectedItems;
        }

        public void Add_Reward(CharacterBase chr, Item items)
        {
            if (items.atk != 0)
            {
                chr.Set_Atk(chr.Get_Atk() + items.atk);
            }

            if (items.arm != 0)
            {
                chr.Set_Arm(chr.Get_Arm() + items.arm);
            }

            if (items.cri != 0)
            {
                chr.Set_Cri(chr.Get_Cri() + items.cri);
            }

            if (items.avoid != 0)
            {
                chr.Set_Avoid(chr.Get_Avoid() + items.avoid);
            }

            if (items.maxHp != 0)
            {
                chr.Set_MaxHp(chr.Get_MaxHp() + items.maxHp);
            }

            if (items.abilityName != null)
            {
                chr.Add_Ability(items.abilityName, items.abilityLvl);
            }
        }
    }
}
