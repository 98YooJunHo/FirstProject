using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class DeathKnight : MonsterBase
    {
        public DeathKnight(float difficult) 
        {
            name = " 데스 나이트 ";
            hp = Convert.ToInt32(454 * difficult);
            maxHp = Convert.ToInt32(454 * difficult);
            atk = Convert.ToInt32(41 * difficult);
            cri = Convert.ToInt32(10 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "기사";
        }
    }
}
