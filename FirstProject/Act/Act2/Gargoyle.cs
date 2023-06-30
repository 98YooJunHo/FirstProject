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
            hp = Convert.ToInt32(105 * difficult);
            maxHp = Convert.ToInt32(105 * difficult);
            atk = Convert.ToInt32(13 * difficult);
            cri = Convert.ToInt32(5 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "석상";
        }
    }
}
