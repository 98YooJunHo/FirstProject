using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstProject
{
    public class StoneGargoyle : MonsterBase
    {
        public StoneGargoyle(float difficult)
        {
            name = " 락 가 고 일 ";
            hp = Convert.ToInt32(150 * difficult);
            maxHp = Convert.ToInt32(150 * difficult);
            atk = Convert.ToInt32(17 * difficult);
            cri = Convert.ToInt32(4 * difficult);
            avoid = Convert.ToInt32(2 * difficult);
            type = "정예석상";
        }
    }
}
