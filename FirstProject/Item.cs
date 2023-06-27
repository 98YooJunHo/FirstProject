using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Item
    {
        public string name;
        public string abilityName;
        public int abilityLvl;
        public int atk;
        public int maxHp;
        public int arm;
        public int avoid;
        public int cri;

        public void Init(string nam, string abName, int abLvl, int at, int max, int ar, int avo, int cr)
        {
            name = nam;
            abilityName = abName;
            abilityLvl = abLvl;
            atk = at;
            maxHp = max; 
            arm = ar; 
            avoid = avo;
            cri = cr;
        }
    }
}
