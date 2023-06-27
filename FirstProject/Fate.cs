using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Fate
    {
        public string name;
        public string abilityName;
        public int abilityLvl;

        public void Init(string nam, string abNam, int abLvl)
        {
            name = nam;
            abilityName = abNam;
            abilityLvl = abLvl;
        }
    }
}
