using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstProject
{
    public class Wraith : MonsterBase
    {
        public Wraith(float difficult) 
        {
            name = "   망   령   ";
            hp = Convert.ToInt32(303 * difficult);
            maxHp = Convert.ToInt32(303 * difficult);
            atk = Convert.ToInt32(34 * difficult);
            cri = Convert.ToInt32(10 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "귀신";
        }
    }
}
