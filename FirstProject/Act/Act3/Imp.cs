using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Imp : MonsterBase
    {
        public Imp(float difficult) 
        {
            name = "   임   프   ";
            hp = Convert.ToInt32(157 * difficult);
            maxHp = Convert.ToInt32(157 * difficult);
            atk = Convert.ToInt32(19 * difficult);
            cri = Convert.ToInt32(5 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "악마";
        }
    }
}
