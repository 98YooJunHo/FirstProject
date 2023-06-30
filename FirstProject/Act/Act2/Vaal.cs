using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Act.Act2
{
    public class Vaal : MonsterBase
    {
        public Vaal(float difficult) 
        {
            name = " 바 알 제 붑 ";
            hp = Convert.ToInt32(300 * difficult);
            maxHp = Convert.ToInt32(300 * difficult);
            atk = Convert.ToInt32(26 * difficult);
            cri = Convert.ToInt32(10 * difficult);
            avoid = Convert.ToInt32(0 * difficult);
            type = "보스몹";
        }
    }
}
