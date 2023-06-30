using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstProject.Act.Act3
{
    public class Asmo : MonsterBase
    {
        public Asmo(float difficult) 
        {
            name = "아스모 데우스";
            hp = Convert.ToInt32(450 * difficult);
            maxHp = Convert.ToInt32(450 * difficult);
            atk = Convert.ToInt32(33 * difficult);
            cri = Convert.ToInt32(2 * difficult);
            avoid = Convert.ToInt32(10 * difficult);
            type = "보스몹";
        }
    }
}
