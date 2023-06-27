using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class CharacterBase
    {
        protected string name;
        protected int hp;
        protected int maxHp;
        protected int atk;
        protected int arm;
        protected int cri;
        protected int avoid;
        public List<Skill> skills;
        public List<Ability> abilities;
        // 직업 불러오기
        public string Get_Name()
        {
            return name;
        }

        // 스탯 관련 함수
        public int Get_Hp()
        {
            return hp;
        }
        public void Set_Hp(int cHp)
        {
            hp = cHp;
            if(hp > maxHp)
            {
                hp = maxHp;
            }
        }
        public int Get_MaxHp()
        {
            return maxHp;
        }
        public void Set_MaxHp(int cMaxHp)
        {
            maxHp = cMaxHp;
            if (maxHp > 600)
            {
                maxHp = 600;
            }
        }
        public int Get_Atk()
        {
            return atk;
        }
        public void Set_Atk(int cAtk)
        {
            atk = cAtk;
            if(atk > 60)
            {
                atk = 60;
            }
        }
        public int Get_Arm()
        {
            return arm;
        }
        public void Set_Arm(int cArm)
        {
            arm = cArm;
            if(arm > 60)
            {
                arm = 60;
            }
        }
        public int Get_Cri()
        {
            return cri;
        }
        public void Set_Cri(int cCri)
        {
            cri = cCri;
            if(cri > 75)
            {
                cri = 75;
            }
        }
        public int Get_Avoid()
        {
            return avoid;
        }
        public void Set_Avoid(int cAvoid)
        {
            avoid = cAvoid;
            if(avoid > 75)
            {
                avoid = 75;
            }
        }
        // 스탯 관련 끝

        // 스킬 관련
        public Skill Get_Skills(int i)
        {
            return skills[i];
        }
        public void Add_Skill(string name, int cooltime)
        {
            Skill tempSkill = new Skill();
            tempSkill.name = name;
            tempSkill.cooltime = cooltime;
            for (int i = 0; i < skills.Count; i++)
            {
                if (skills[i].name == tempSkill.name)
                {
                    if (skills[i].cooltime != 0)
                    {
                        skills[i].cooltime -= 1;
                        return;
                    }
                }

                skills.Add(tempSkill);
            }
        }
        public int Get_Skills_Length()
        {
            return skills.Count;
        }
        // 스킬 관련 끝

        // 능력 관련
        public Ability Get_Ability(int i)
        {
            return abilities[i];
        }
        public void Add_Ability(string name, int lvl)
        {
            int same = 0;
            int index = 0;
            for (int i = 0; i < abilities.Count; i++)
            {
                if (abilities[i].name == name)
                {
                    same += 1;
                    index = i;
                    break;
                }
                else
                {
                    continue;
                }
            }

            if(same == 0)
            {
                Ability tempAbility = new Ability();
                tempAbility.name = name;
                tempAbility.lvl = lvl;
                abilities.Add(tempAbility);
                return;
            }

            if(same == 1)
            {
                if (abilities[index].lvl != 7)
                {
                    abilities[index].lvl += 1;
                }
            }

        }
        public int Get_Ability_Length()
        {
            return abilities.Count;
        }
        // 능력 관련 끝
    }

}
