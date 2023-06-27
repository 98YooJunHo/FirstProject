using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Knight : CharacterBase
    {
        public Knight()
        {
            name = "기사";
            hp = 1700;
            maxHp = 1700;
            atk = 110;
            arm = 14;
            cri = 9;
            avoid = 4;

            skills = new List<Skill>();
            Skill normalAttack = new Skill();
            normalAttack.name = "평타";
            normalAttack.cooltime = 0;
            skills.Add(normalAttack);

            abilities = new List<Ability>();
            Ability ironPlate = new Ability();
            ironPlate.name = "철갑";
            ironPlate.lvl = 3;
            abilities.Add(ironPlate);
        }

    }
}
