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

        public int Exp(ref int act ,ref int count, int cas)
        {
            int case_ = 0;
            
            if(cas != 0)
            {
                return 0;
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
            else if(battleRate < 33) 
            {
                case_ = 3;
                return case_;
            }
            else if(battleRate > 32)
            {
                case_ = 4;
                return case_;
            }
            return 0;
        }

        public void Print(List<Fate> fates_, int _case)
        {
            switch(_case)
            {
                case 1:
                    {
                        Console.SetCursorPosition(47,8);
                        Console.Write("여정 중 모닥불을 마주쳤습니다");
                        break;
                    }
                case 2:
                    {
                        Console.SetCursorPosition(52, 8);
                        Console.Write("보스를 마주쳤습니다");
                        break;
                    }
                case 3:
                    {
                        Console.SetCursorPosition(53, 8);
                        Console.Write("적을 마주쳤습니다");
                        break;
                    }
                case 4:
                    {
                        Console.SetCursorPosition(51, 8);
                        Console.Write("이벤트를 마주쳤습니다");
                        break;
                    }
                case 5:
                    {
                        Console.SetCursorPosition(53, 8);
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

        public List<Fate> Choice_Fate(List<Fate> fates_,int cas)
        {
            List<Fate> fates = new List<Fate>();
            List<Fate> selectedFates = new List<Fate>();
            Fate fate = new Fate();
            Fate fate1 = new Fate();
            Fate fate2 = new Fate();
            fate.name = "지독한";
            fate.abilityName = "맹독";
            fate.abilityLvl = 1;
            fates.Add(fate);
            fate1.name = "튼튼한";
            fate1.abilityName = "철갑";
            fate1.abilityLvl = 1;
            fates.Add(fate1);
            fate2.name = "민첩한";
            fate2.abilityName = "회피";
            fate2.abilityLvl = 1;
            fates.Add(fate2);

            for (int i = 0; i < 1000; i++)
            {
                int randomIndex = random.Next(fates.Count-1);
                Fate temp = new Fate();
                temp = fates[randomIndex];
                fates[randomIndex] = fates[randomIndex+1];
                fates[randomIndex + 1] = temp;
            }

            for(int i = 0; i < 3; i ++)
            {
                Fate temp = new Fate();
                temp.name = fates[i].name;
                temp.abilityName = fates[i].abilityName;
                temp.abilityLvl = fates[i].abilityLvl;
                selectedFates.Add(temp);
            }

            return selectedFates;
        }
    }
}
