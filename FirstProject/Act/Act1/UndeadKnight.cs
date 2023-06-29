using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class UndeadKnight : MonsterBase
    {
        public UndeadKnight(float difficult)
        {
            name = "되살아난 검사";
            hp = Convert.ToInt32(70 * difficult);
            maxHp = Convert.ToInt32(70 * difficult);
            atk = Convert.ToInt32(12 * difficult);
            cri = Convert.ToInt32(4 * difficult);
            avoid = Convert.ToInt32(2 * difficult);
        }
    }
}
