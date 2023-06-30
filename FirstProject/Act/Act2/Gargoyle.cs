using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Gargoyle : MonsterBase
    {
        public Gargoyle(float difficult)
        {
            name = " 가   고   일";
            hp = Convert.ToInt32(100 * difficult);
            maxHp = Convert.ToInt32(100 * difficult);
            atk = Convert.ToInt32(18 * difficult);
            cri = Convert.ToInt32(6 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "악마";
        }
    }
}
