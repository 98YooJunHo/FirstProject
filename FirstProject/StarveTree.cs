using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class StarveTree : MonsterBase
    {
        public StarveTree(float difficult)
        {
            name = "메마른 거목";
            hp = Convert.ToInt32(200 * difficult);
            maxHp = Convert.ToInt32(200 * difficult);
            atk = Convert.ToInt32(19 * difficult);
            cri = Convert.ToInt32(8 * difficult);
            avoid = Convert.ToInt32(0 * difficult);
        }
    }
}
