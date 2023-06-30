using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Durahan : MonsterBase
    {
        public Durahan(float difficult) 
        {
            name = " 듀  라  한 ";
            hp = Convert.ToInt32(757 * difficult);
            maxHp = Convert.ToInt32(757 * difficult);
            atk = Convert.ToInt32(45 * difficult);
            cri = Convert.ToInt32(6 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "정예기사";
        }
    }
}
