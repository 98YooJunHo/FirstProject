using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Expedition
    {
        Random random = new Random();

        public int Exp(int act ,int count, int cas)
        {
            int case_ = 0;
            
            if(cas != 0)
            {
                return cas;
            }

            if(act == 1 && count == 1)
            {
                case_ = 5;
                return case_;
            }

            int battleRate = random.Next(100);
            if(count == 11)
            {
                case_ = 1;
                return case_;
            }
            else if (count == 12)
            {
                case_ = 2;
                return case_;
            }
            else if(battleRate < 50) 
            {
                case_ = 3;
                return case_;
            }
            else if(battleRate > 49)
            {
                case_ = 4;
                return case_;
            }
            return 0;
        }

        public void Print(List<Fate> fates_, int _case, int roll)
        {
            switch(_case)
            {
                case 1:
                    {
                        Console.SetCursorPosition(47,8);
                        Console.Write("여정 중 모닥불을 마주쳤습니다");
                        Console.SetCursorPosition(40, 17);
                        Console.Write("휴식한다");
                        Console.SetCursorPosition(40, 19);
                        Console.Write("명상한다");
                        break;
                    }
                case 2:
                    {
                        Console.SetCursorPosition(52, 8);
                        Console.Write("보스를 마주쳤습니다");
                        Console.SetCursorPosition(40, 17);
                        Console.Write("싸운다");
                        break;
                    }
                case 3:
                    {
                        Console.SetCursorPosition(53, 8);
                        Console.Write("적을 마주쳤습니다");
                        Console.SetCursorPosition(40, 17);
                        Console.Write("싸운다");
                        break;
                    }
                case 4:
                    {
                        Console.SetCursorPosition(53, 8);
                        Console.Write("샘을 마주쳤습니다");
                        Console.SetCursorPosition(40, 17);
                        Console.Write("마신다");
                        Console.SetCursorPosition(40, 19);
                        Console.Write("지나간다");
                        break;
                    }
                case 5:
                    {
                        Console.SetCursorPosition(62, 7);
                        Console.Write("새로고침 가능 횟수 :" + roll + "회");
                        Console.SetCursorPosition(53, 9);
                        Console.Write("운명을 선택하세요");
                        Console.SetCursorPosition(46, 13);
                        Console.Write(fates_[0].name);
                        Console.SetCursorPosition(59, 13);
                        Console.Write(fates_[1].name);
                        Console.SetCursorPosition(72, 13);
                        Console.Write(fates_[2].name);
                        Console.SetCursorPosition(45, 14);
                        Console.Write(fates_[0].abilityName + "lv." + fates_[0].abilityLvl);
                        Console.SetCursorPosition(58, 14);
                        Console.Write(fates_[1].abilityName + "lv." + fates_[1].abilityLvl);
                        Console.SetCursorPosition(71, 14);
                        Console.Write(fates_[2].abilityName + "lv." + fates_[2].abilityLvl);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        public List<Fate> Choice_Fate()
        {
            FateList fates = new FateList();
            List<Fate> selectedFates = new List<Fate>();

            for (int i = 0; i < 1000; i++)
            {
                int randomIndex = random.Next(fates.list.Count-1);
                Fate temp = fates.list[randomIndex];
                fates.list[randomIndex] = fates.list[randomIndex+1];
                fates.list[randomIndex + 1] = temp;
            }

            for(int i = 0; i < 3; i ++)
            {
                Fate temp = new Fate();
                temp.name = fates.list[i].name;
                temp.abilityName = fates.list[i].abilityName;
                temp.abilityLvl = fates.list[i].abilityLvl;
                selectedFates.Add(temp);
            }

            return selectedFates;
        }

    }
}
