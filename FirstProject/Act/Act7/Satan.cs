using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Satan : MonsterBase
    {
        public Satan(float difficult) 
        {
            name = "   사   탄   ";
            hp = Convert.ToInt32(2278 * difficult);
            maxHp = Convert.ToInt32(2278 * difficult);
            atk = Convert.ToInt32(66 * difficult);
            cri = Convert.ToInt32(16 * difficult);
            avoid = Convert.ToInt32(16 * difficult);
            type = "보스몹";
        }
    }
}
