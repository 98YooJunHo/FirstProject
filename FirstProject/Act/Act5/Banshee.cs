using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstProject
{
    public class Banshee : MonsterBase
    {
        public Banshee(float difficult) 
        {
            name = "   밴   시   ";
            hp = Convert.ToInt32(505 * difficult);
            maxHp = Convert.ToInt32(505 * difficult);
            atk = Convert.ToInt32(38 * difficult);
            cri = Convert.ToInt32(6 * difficult);
            avoid = Convert.ToInt32(3 * difficult);
            type = "정예귀신";
        }
    }
}
