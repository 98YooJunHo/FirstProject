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
            hp = 170;
            maxHp = 170;
            atk = 11;
            arm = 14;
            cri = 9;
            avoid = 4;

            skills = new List<Skill>();
            Skill normalAttack = new Skill();
            Skill normalBlock = new Skill();
            normalAttack.Init("공격", -1, -1);
            normalBlock.Init("방어", 30, 30);
            skills.Add(normalAttack);
            skills.Add(normalBlock);

            abilities = new List<Ability>();
            Ability ironPlate = new Ability();
            ironPlate.Init("철갑", 3);
            abilities.Add(ironPlate);
        }

    }
}
