using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Necromancer : MonsterBase
    {
        public Necromancer(float difficult) 
        {
            name = " 네크로 맨서 ";
            hp = Convert.ToInt32(869 * difficult);
            maxHp = Convert.ToInt32(869 * difficult);
            atk = Convert.ToInt32(49 * difficult);
            cri = Convert.ToInt32(10 * difficult);
            avoid = Convert.ToInt32(13 * difficult);
            type = "정예흑마법사";
        }
    }
}
