using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Act.Act4
{
    public class Belphe : MonsterBase
    {
        public Belphe(float difficult) 
        {
            name = " 벨 페 고 르 ";
            hp = Convert.ToInt32(675 * difficult);
            maxHp = Convert.ToInt32(675 * difficult);
            atk = Convert.ToInt32(40 * difficult);
            cri = Convert.ToInt32(7 * difficult);
            avoid = Convert.ToInt32(7 * difficult);
            type = "보스몹";
        }
    }
}
