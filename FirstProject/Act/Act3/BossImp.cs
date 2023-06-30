using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class BossImp : MonsterBase
    {
        public BossImp(float difficult) 
        {
            name = " 임 프 두 목 ";
            hp = Convert.ToInt32(225 * difficult);
            maxHp = Convert.ToInt32(225 * difficult);
            atk = Convert.ToInt32(24 * difficult);
            cri = Convert.ToInt32(5 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "정예악마";
        }
    }
}
