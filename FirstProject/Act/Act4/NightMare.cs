using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class NightMare : MonsterBase
    {
        public NightMare(float difficult) 
        {
            name = " 나이트 메어 ";
            hp = Convert.ToInt32(337 * difficult);
            maxHp = Convert.ToInt32(337 * difficult);
            atk = Convert.ToInt32(31 * difficult);
            cri = Convert.ToInt32(6 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "정예악마";
        }
    }
}
