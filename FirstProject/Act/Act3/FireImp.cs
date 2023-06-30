using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstProject
{
    public class FireImp : MonsterBase
    {
        public FireImp(float difficult) 
        {
            name = " 화 염 임 프 ";
            hp = Convert.ToInt32(135 * difficult);
            maxHp = Convert.ToInt32(135 * difficult);
            atk = Convert.ToInt32(20 * difficult);
            cri = Convert.ToInt32(9 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "악마";
        }
    }
}
