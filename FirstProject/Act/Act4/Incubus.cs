using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Incubus : MonsterBase
    {
        public Incubus(float difficult) 
        {
            name = " 인 큐 버 스 ";
            hp = Convert.ToInt32(202 * difficult);
            maxHp = Convert.ToInt32(202 * difficult);
            atk = Convert.ToInt32(27 * difficult);
            cri = Convert.ToInt32(9 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "악마";
        }
    }
}
