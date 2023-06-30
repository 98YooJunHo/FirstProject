using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class HeadLessKnight : MonsterBase
    {
        public HeadLessKnight(float difficult) 
        {
            name = " 목없는 기사 ";
            hp = Convert.ToInt32(513 * difficult);
            maxHp = Convert.ToInt32(513 * difficult);
            atk = Convert.ToInt32(40 * difficult);
            cri = Convert.ToInt32(6 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "기사";
        }
    }
}
