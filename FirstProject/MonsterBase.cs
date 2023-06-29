using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject 
{
    public class MonsterBase
    {
        protected string name;
        protected int hp;
        protected int maxHp;
        protected int atk;
        protected int cri;
        protected int avoid;

        public string Get_Name()
        {
            return name;
        }
        public int Get_Hp()
        {
            return hp;
        }
        public void Set_Hp(int cHp)
        {
            hp = cHp;
            if(hp < 0)
            {
                hp = 0;
            }
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
        public int Get_Cri()
        {
            return cri;
        }
        public int Get_Avoid()
        {
            return avoid;
        }
    }
}
