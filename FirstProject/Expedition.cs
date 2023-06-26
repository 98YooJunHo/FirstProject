using System;
using System.Collections.Generic;
using System.Linq;
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
            
            if(act == 1 && count == 1)
            {
                case_ = 5;
                return case_;
            }

            if(cas != 0)
            {
                return 0;
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

        public void Print(int _case)
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
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
