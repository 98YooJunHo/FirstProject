using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Act.Act6
{
    public class Lucifer : MonsterBase
    {
        public Lucifer(float difficult) 
        {
            name = "  루 시 퍼  ";
            hp = Convert.ToInt32(1518 * difficult);
            maxHp = Convert.ToInt32(1518 * difficult);
            atk = Convert.ToInt32(54 * difficult);
            cri = Convert.ToInt32(4 * difficult);
            avoid = Convert.ToInt32(10 * difficult);
            type = "보스몹";
        }
    }
}
