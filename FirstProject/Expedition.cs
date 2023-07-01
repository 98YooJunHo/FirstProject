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

        /// <summary>
        /// 진행중인 정보를 저장하기 위한 case를 반환하는 함수,
        /// case가 0일 경우 새로운 진행 정보를 저장하기 위해 
        /// 정해진 확률로 case값에 새로운 수를 저장함
        /// </summary>
        /// <param name="act"></param>
        /// <param name="count"></param>
        /// <param name="cas"></param>
        /// <returns></returns>
        public int Exp(int act ,int count, int cas)
        {
            int case_;
            
            // 이미 정해진 진행 정보가 있다면
            if(cas != 0)
            {
                return cas;
            }

            // 액트1에 진척도가 1이라면
            if(act == 1 && count == 1)
            {
                // 운명 선택
                case_ = 5;
                return case_;
            }

            int battleRate = random.Next(100);
            // 액트 진척도가 11이라면
            if(count == 11)
            {
                // 캠핑
                case_ = 1;
                return case_;
            }
            // 액트 진척도가 12라면
            else if (count == 12)
            {
                // 보스전
                case_ = 2;
                return case_;
            }
            // 그외에 70퍼확률로
            else if(battleRate < 70) 
            {
                // 적 조우
                case_ = 3;
                return case_;
            }
            // 30퍼확률로
            else if(battleRate > 69)
            {
                // 이벤트 발생
                case_ = 4;
                return case_;
            }
            return 0;
        }

        /// <summary>
        /// case에 따른 진행중인 상황을 출력하는 함수,
        /// fate리스트는 운명 선택시 선택할 3가지 운명을 보여줌
        /// roll의 경우 운명 선택시 새로고침 횟수를 보여줌
        /// </summary>
        /// <param name="fates_"></param>
        /// <param name="_case"></param>
        /// <param name="roll"></param>
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
                        Console.SetCursorPosition(59, 7);
                        Console.Write("새로고침(r) 가능 횟수 :" + roll + "회");
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

        /// <summary>
        /// 전체 운명중 랜덤으로 3가지를 불러오는 함수
        /// </summary>
        /// <returns></returns>
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
