using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Archer : CharacterBase
    {
        public Archer()
        {
            name = "궁수";
            hp = 150;
            maxHp = 150;
            atk = 12;
            arm = 13;
            cri = 11;
            avoid = 4;

            skills = new List<Skill>();
            Skill normalAttack = new Skill();
            Skill normalBlock = new Skill();
            normalAttack.Init("공격", -1, -1);
            normalBlock.Init("방어", 30, 30);
            skills.Add(normalAttack);
            skills.Add(normalBlock);

            abilities = new List<Ability>();
            Ability anger = new Ability();
            anger.Init("분노", 3);
            abilities.Add(anger);
        }
    }
}
