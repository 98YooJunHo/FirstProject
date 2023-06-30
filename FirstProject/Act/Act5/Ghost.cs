using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstProject
{
    public class Ghost : MonsterBase
    {
        public Ghost(float difficult) 
        {
            name = "   유   령   ";
            hp = Convert.ToInt32(342 * difficult);
            maxHp = Convert.ToInt32(342 * difficult);
            atk = Convert.ToInt32(33 * difficult);
            cri = Convert.ToInt32(6 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "귀신";
        }
    }
}
