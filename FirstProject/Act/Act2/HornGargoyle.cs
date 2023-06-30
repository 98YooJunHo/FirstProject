using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class HornGargoyle : MonsterBase
    {
        public HornGargoyle(float difficult) 
        {
            name = " 뿔 가 고 일 ";
            hp = Convert.ToInt32(90 * difficult);
            maxHp = Convert.ToInt32(90 * difficult);
            atk = Convert.ToInt32(14 * difficult);
            cri = Convert.ToInt32(8 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "석상";
        }
    }
}
