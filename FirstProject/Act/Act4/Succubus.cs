using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Succubus : MonsterBase
    {
        public Succubus(float difficult) 
        {
            name = " 서 큐 버 스 ";
            hp = Convert.ToInt32(235 * difficult);
            maxHp = Convert.ToInt32(235 * difficult);
            atk = Convert.ToInt32(26 * difficult);
            cri = Convert.ToInt32(6 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "악마";
        }
    }
}
