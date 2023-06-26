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
        protected List<Skill> skills = new List<Skill>();
        protected List<Ability> abilities = new List<Ability>();

        // 직업 불러오기
        public string Get_Name()
        {
            return name;
        }

        // 스탯관련 함수
        public int Get_Hp()
        {
            return hp;
        }
        public void Set_Hp(int cHp)
        {
            hp = cHp;
        }
        public int Get_MaxHp()
        {
            return maxHp;
        }
        public void Set_maxHp(int cMaxHp)
        {
            maxHp = cMaxHp;
        }
        public int Get_Atk()
        {
            return atk;
        }
        public void Set_Atk(int cAtk)
        {
            atk = cAtk;
        }
        public int Get_Arm()
        {
            return arm;
        }
        public void Set_Arm(int cArm)
        {
            arm = cArm;
        }
        public int Get_Cri()
        {
            return cri;
        }
        public void Set_Cri(int cCri)
        {
            cri = cCri;
        }
        public int Get_Avoid()
        {
            return avoid;
        }
        public void Set_Avoid(int cAvoid)
        {
            avoid = cAvoid;
        }

        // 스킬 관련
        public Skill Get_Skills(int i)
        {
            return skills[i];
        }
        public void Add_Skill(string name, int cooltime)
        {
            Skill tempskill = new Skill();
            tempskill.name = name;
            tempskill.cooltime = cooltime;
            skills.Add(tempskill);
        }
        public int Get_Skills_Length()
        {
            return skills.Count;
        }

        // 능력 관련
        public Ability Get_Ability(int i)
        {
            return abilities[i];
        }

        public void Add_Ability(string name, int lvl)
        {
            Ability tempAbility = new Ability();
            tempAbility.name = name;
            tempAbility.lvl = lvl;
            abilities.Add(tempAbility);
        }

        public int Get_Ability_Length()
        {
            return abilities.Count;
        }
    }

}
