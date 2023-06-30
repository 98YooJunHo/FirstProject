using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Levi : MonsterBase
    {
        public Levi(float difficult) 
        {
            name = " 레 비 아 탄 ";
            hp = Convert.ToInt32(1012 * difficult);
            maxHp = Convert.ToInt32(1012 * difficult);
            atk = Convert.ToInt32(47 * difficult);
            cri = Convert.ToInt32(14 * difficult);
            avoid = Convert.ToInt32(0 * difficult);
            type = "보스몹";
        }
    }
}
