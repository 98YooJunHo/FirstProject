using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class DarkKnight : MonsterBase
    {
        public DarkKnight(float difficult) 
        {
            name = " 다크 나이트 ";
            hp = Convert.ToInt32(931 * difficult);
            maxHp = Convert.ToInt32(931 * difficult);
            atk = Convert.ToInt32(50 * difficult);
            cri = Convert.ToInt32(12 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "정예기사";
        }
    }
}
