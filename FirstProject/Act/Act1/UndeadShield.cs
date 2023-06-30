using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class UndeadShield : MonsterBase
    {
        public UndeadShield(float difficult)
        {
            name = "되살아난 탱커";
            hp = Convert.ToInt32(100 * difficult);
            maxHp = Convert.ToInt32(100 * difficult);
            atk = Convert.ToInt32(8 * difficult);
            cri = Convert.ToInt32(3 * difficult);
            avoid = Convert.ToInt32(2 * difficult);
            type = "언데드";
        }
    }
}
