using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography;

namespace FirstProject
{
    public class MainScene
    {
        // 커서 위치 (37,0)부터 시작 y 마지막 좌표 28
        public string Do(ref CharacterBase chr, ref int count, ref int act)
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
                Console.Write(act + "액트 진행도:" + count + "/" + "12");
                Console.SetCursorPosition(39, 4);
                Console.Write("종료 : q");
                playerInput = new ConsoleKeyInfo();
                _case = Run.Exp(act, count, _case);

                // 운명 선택중이고 불러온 운명이 없다면
                if (_case == 5 && fates.Count == 0)
                {
                    // 운명 3가지 불러오기
                    fates = Run.Choice_Fate();
                }

                Run.Print(fates, _case, fateRoll);
                // 진행중인 상황에 따라 커서위치 표시
                #region
                // 보스전 직전 캠핑
                if (_case == 1)
                {
                    Console.SetCursorPosition(38, 17 + campPos * 2);
                    Console.Write("▶");
                }
                // 보스전
                if (_case == 2)
                {
                    Console.SetCursorPosition(38, 17 + bossPos * 2);
                    Console.Write("▶");
                }
                // 적 조우
                if (_case == 3)
                {
                    Console.SetCursorPosition(38, 17 + battlePos * 2);
                    Console.Write("▶");
                }
                // 이벤트
                if (_case == 4)
                {
                    Console.SetCursorPosition(38, 17 + eventPos * 2);
                    Console.Write("▶");
                }
                // 운명 선택
                if (_case == 5)
                {
                    Console.SetCursorPosition(49 + fatePos * 13, 15);
                    Console.Write("▲");
                }
                #endregion

                playerInput = Console.ReadKey();
                // switch() 시작
                switch (playerInput.Key)
                {
                    // 플레이어 정보 불러오기
                    case ConsoleKey.I:
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Clear_Info();
                            Print_ChrInfo(chr);
                            System.ConsoleKeyInfo playerInput1 = new ConsoleKeyInfo();
                            // 엔터를 누르기 전까지 플레이어 정보 지속 출력
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
                    // 액트에 따른 보스 정보 부르기
                    case ConsoleKey.B:
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Clear_Info();
                            MonsterBase boss = new MonsterBase();

                            #region
                            if (act == 1)
                            {
                                boss = new Mamon(1);
                            }
                            if (act == 2)
                            {
                                boss = new Vaal(1);
                            }
                            if (act == 3)
                            {
                                boss = new Asmo(1);
                            }
                            if (act == 4)
                            {
                                boss = new Belphe(1);
                            }
                            if (act == 5)
                            {
                                boss = new Levi(1);
                            }
                            if (act == 6)
                            {
                                boss = new Lucifer(1);
                            }
                            if (act == 7)
                            {
                                boss = new Satan(1);
                            }
                            #endregion

                            // 보스 정보 출력
                            Print_BossInfo(boss);
                            System.ConsoleKeyInfo playerInput1 = new ConsoleKeyInfo();
                            // 엔터를 누르기 전까지 보스 정보 지속 출력
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
                    // 메인 씬에서의 상하 방향키는 이벤트와 캠핑때만 사용함
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
                    // 메인 씬에서의 좌우 방향키는 운명선택때만 사용함
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
                    // 운명 1회 새로고침 가능
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
                    // 케이스 별로 엔터 실행 후 해당 케이스 진행
                    case ConsoleKey.Enter:
                        {
                            Clear_Info();
                            switch (_case)
                            {
                                // 캠핑
                                case 1:
                                    {
                                        // 회복 시 최대체력의 50퍼센트 만큼 회복
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
                                        // 명상 시 모든 스킬의 사용가능 횟수 최대치로 회복
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
                                            string isBossDeath;
                                            MonsterBase mob = new MonsterBase();

                                            // 액트별로 보스 불러오기
                                            #region
                                            if (act == 1)
                                            {
                                                mob = new Mamon(1);
                                            }
                                            if (act == 2)
                                            {
                                                mob = new Vaal(1);
                                            }
                                            if (act == 3)
                                            {
                                                mob = new Asmo(1);
                                            }
                                            if (act == 4)
                                            {
                                                mob = new Belphe(1);
                                            }
                                            if (act == 5)
                                            {
                                                mob = new Levi(1);
                                            }
                                            if (act == 6)
                                            {
                                                mob = new Lucifer(1);
                                            }
                                            if (act == 7)
                                            {
                                                mob = new Satan(1);
                                            }
                                            #endregion

                                            BattleScene battle = new BattleScene();
                                            isBossDeath = battle.Do(chr, mob);
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

                                            // 보스가 죽었다면
                                            if (isBossDeath == "배틀윈")
                                            {
                                                // 액트 7 이라면
                                                if(act == 7)
                                                {
                                                    Console.SetCursorPosition(50, 14);
                                                    Console.Write("탑의 정상을 차지하였습니다");
                                                    Thread.Sleep(1000);
                                                    return "타이틀로";
                                                }
                                                // 그외 다른 액트 보스의 경우
                                                act += 1;
                                                count = 1;
                                                Console.SetCursorPosition(52, 14);
                                                Console.Write("보스를 처치하였습니다");
                                                Console.SetCursorPosition(43, 15);
                                                Console.Write("체력과 스킬사용 횟수를 모두 회복합니다");
                                                Thread.Sleep(1000);
                                                Console.SetCursorPosition(52, 14);
                                                Console.Write("                     ");
                                                Console.SetCursorPosition(43, 15);
                                                Console.Write("                                      ");
                                                chr.Set_Hp(chr.Get_MaxHp());
                                                foreach(Skill skill in chr.skills)
                                                {
                                                    skill.count = skill.fullCount;
                                                }
                                                break;
                                            }

                                            // 내가 죽었다면
                                            if (isBossDeath == "배틀도중사망")
                                            {
                                                return "타이틀로";
                                            }
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

                                            // 액트별 적 구분
                                            #region
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
                                            if (act == 2)
                                            {
                                                switch (who)
                                                {
                                                    case 0:
                                                        mob = new Gargoyle(1);
                                                        break;
                                                    case 1:
                                                        mob = new HornGargoyle(1);
                                                        break;
                                                    case 2:
                                                        mob = new StoneGargoyle(1);
                                                        break;
                                                }
                                            }
                                            if (act == 3)
                                            {
                                                switch (who)
                                                {
                                                    case 0:
                                                        mob = new Imp(1);
                                                        break;
                                                    case 1:
                                                        mob = new FireImp(1);
                                                        break;
                                                    case 2:
                                                        mob = new BossImp(1);
                                                        break;
                                                }
                                            }
                                            if (act == 4)
                                            {
                                                switch (who)
                                                {
                                                    case 0:
                                                        mob = new Incubus(1);
                                                        break;
                                                    case 1:
                                                        mob = new Succubus(1);
                                                        break;
                                                    case 2:
                                                        mob = new NightMare(1);
                                                        break;
                                                }
                                            }
                                            if (act == 5)
                                            {
                                                switch (who)
                                                {
                                                    case 0:
                                                        mob = new Ghost(1);
                                                        break;
                                                    case 1:
                                                        mob = new Wraith(1);
                                                        break;
                                                    case 2:
                                                        mob = new Banshee(1);
                                                        break;
                                                }
                                            }
                                            if (act == 6)
                                            {
                                                switch (who)
                                                {
                                                    case 0:
                                                        mob = new HeadLessKnight(1);
                                                        break;
                                                    case 1:
                                                        mob = new DeathKnight(1);
                                                        break;
                                                    case 2:
                                                        mob = new Durahan(1);
                                                        break;
                                                }
                                            }
                                            if (act == 7)
                                            {
                                                switch (who)
                                                {
                                                    case 0:
                                                        mob = new DarkKnight(1);
                                                        break;
                                                    case 1:
                                                        mob = new Necromancer(1);
                                                        break;
                                                    case 2:
                                                        mob = new BoneDragon(1);
                                                        break;
                                                }
                                            }
                                            #endregion

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
                                            // 샘의 종류를 결정할 랜덤수
                                            int IsWhat = random.Next(10);
                                            // 10퍼센트 확률로 썩은샘 (0)
                                            if (IsWhat < 1)
                                            {
                                                // 최대체력의 10퍼센트 만큼 체력 감소
                                                chr.Set_Hp(chr.Get_Hp() - chr.Get_MaxHp() / 10);
                                                // 샘 정보 출력
                                                Clear_Info();
                                                Console.SetCursorPosition(56, 15);
                                                Console.Write("썩은샘이였다");
                                                Thread.Sleep(1000);
                                                Console.SetCursorPosition(56, 15);
                                                Console.Write("            ");
                                            }
                                            // 50퍼센트 확률로 맑은 샘 (1,2,3,4,5)
                                            else if (IsWhat < 6)
                                            {
                                                // 최대체력의 20퍼센트 만큼 체력 회복
                                                chr.Set_Hp(chr.Get_Hp() + (chr.Get_MaxHp() / 10) * 2);
                                                // 샘 정보 출력
                                                Clear_Info();
                                                Console.SetCursorPosition(56, 15);
                                                Console.Write("맑은샘이였다");
                                                Thread.Sleep(1000);
                                                Console.SetCursorPosition(56, 15);
                                                Console.Write("            ");
                                            }
                                            // 20퍼센트 확률로 기억의 샘 (6,7)
                                            else if (IsWhat < 8)
                                            {
                                                // 갖고 있는 능력중 한가지를 1레벨 증가
                                                int rand = random.Next(chr.Get_Ability_Length());
                                                Ability randAbil = chr.Get_Ability(rand);
                                                chr.Add_Ability(randAbil.name, 1);
                                                // 샘 정보 출력
                                                Clear_Info();
                                                Console.SetCursorPosition(55, 15);
                                                Console.Write("기억의샘이였다");
                                                Thread.Sleep(1000);
                                                Console.SetCursorPosition(55, 15);
                                                Console.Write("              ");
                                            }
                                            // 나머지 20퍼센트 확률로 강화의 샘 (8,9)
                                            else
                                            {
                                                // 어떤 스탯을 강화할지 랜덤돌림
                                                int rand = random.Next(5);
                                                // 선택된 랜덤스탯 강화 스위치 문
                                                switch(rand)
                                                {
                                                    case 0:
                                                        {
                                                            int hpPlus = chr.Get_MaxHp() / 6;
                                                            if(hpPlus < 1)
                                                            {
                                                                hpPlus = 1;
                                                            }
                                                            chr.Set_MaxHp(hpPlus);
                                                            break;
                                                        }
                                                    case 1:                                                        
                                                        {
                                                            int atkPlus = chr.Get_Atk() / 6;
                                                            if(atkPlus < 1)
                                                            {
                                                                atkPlus = 1;
                                                            }
                                                            chr.Set_Atk(atkPlus);
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            int armPlus = chr.Get_Arm() / 6;
                                                            if(armPlus < 1)
                                                            {
                                                                armPlus = 1;
                                                            }
                                                            chr.Set_Arm(armPlus);
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            int criPlus = chr.Get_Cri() / 6;
                                                            if(criPlus < 1)
                                                            {
                                                                criPlus = 1;
                                                            }
                                                            chr.Set_Cri(criPlus);
                                                            break;
                                                        }
                                                    case 4:
                                                        {
                                                            int avoidPlus = chr.Get_Avoid() / 6;
                                                            if(avoidPlus < 1)
                                                            {
                                                                avoidPlus = 1;
                                                            }
                                                            chr.Set_Avoid(avoidPlus);
                                                            break;
                                                        }
                                                }
                                                // 샘 정보 출력
                                                Clear_Info();
                                                Console.SetCursorPosition(55, 15);
                                                Console.Write("강화의샘이였다");
                                                Thread.Sleep(1000);
                                                Console.SetCursorPosition(55, 15);
                                                Console.Write("              ");
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
                                // 운명 선택
                                case 5:
                                    {
                                        // 왼쪽 운명
                                        if (fatePos == 0)
                                        {
                                            chr.Add_Ability(fates[0].abilityName, fates[0].abilityLvl);
                                            _case = 0;
                                            count += 1;
                                            break;
                                        }
                                        // 가운데 운명
                                        if (fatePos == 1)
                                        {
                                            chr.Add_Ability(fates[1].abilityName, fates[1].abilityLvl);
                                            _case = 0;
                                            count += 1;
                                            break;
                                        }
                                        // 오른쪽 운명
                                        if (fatePos == 2)
                                        {
                                            chr.Add_Ability(fates[2].abilityName, fates[2].abilityLvl);
                                            _case = 0;
                                            count += 1;
                                            break;
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
                    // q입력시 종료
                    case ConsoleKey.Q:
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

        /// <summary>
        /// 테두리를 포함한 출력을 지우는 함수
        /// </summary>
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

        /// <summary>
        /// 테두리를 제외한 내부 출력을 지우는 함수
        /// </summary>
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

        /// <summary>
        /// 플레이어 정보 출력 함수
        /// </summary>
        /// <param name="chr"></param>
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
            Console.Write("확 인");
            Console.SetCursorPosition(59, 25);
            Console.Write("Enter");
        }

        /// <summary>
        /// 보스 정보 출력 함수
        /// </summary>
        /// <param name="boss"></param>
        void Print_BossInfo(MonsterBase boss)
        {
            Console.SetCursorPosition(57, 9);
            Console.Write("보스 정보");
            Console.SetCursorPosition(55, 11);
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
            Console.Write("확 인");
            Console.SetCursorPosition(59, 19);
            Console.Write("Enter");
        }

    }
}
