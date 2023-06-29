using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Ability
    {
        public string name;
        public int lvl;

        public void Init(string nam, int lv)
        {
            name = nam;
            lvl = lv;
        }
    }
}
