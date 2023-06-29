using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstProject
{
    public class Thief : CharacterBase
    {
        public Thief() 
        {
            name = "도적";
            hp = 120;
            maxHp = 120;
            atk = 13;
            arm = 10;
            cri = 17;
            avoid = 7;

            skills = new List<Skill>();
            Skill normalAttack = new Skill();
            Skill normalBlock = new Skill();
            normalAttack.Init("공격", -1, -1);
            normalBlock.Init("방어", 30, 30);
            skills.Add(normalAttack);
            skills.Add(normalBlock);

            abilities = new List<Ability>();
            Ability madness = new Ability();
            madness.Init("광기", 3);
            abilities.Add(madness);
        }
    }
}
