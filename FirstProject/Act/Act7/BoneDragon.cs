using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class BoneDragon : MonsterBase
    {
        public BoneDragon(float difficult) 
        {
            name = " 본 드 래 곤 ";
            hp = Convert.ToInt32(1135 * difficult);
            maxHp = Convert.ToInt32(1135* difficult);
            atk = Convert.ToInt32(54 * difficult);
            cri = Convert.ToInt32(7 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "용";
        }
    }
}
