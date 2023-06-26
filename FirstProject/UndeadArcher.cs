using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstProject
{
    public class UndeadArcher : MonsterBase
    {
        public UndeadArcher(float difficult)
        {
            name = "되살아난 궁수";
            hp = Convert.ToInt32(60 * difficult);
            atk = Convert.ToInt32(11 * difficult);
            cri = Convert.ToInt32(8 * difficult);
            avoid = Convert.ToInt32(2 * difficult);
        }
    }
}
