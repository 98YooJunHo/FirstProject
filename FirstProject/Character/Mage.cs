using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstProject
{
    public class Mage : CharacterBase
    {
        public Mage() 
        {
            name = "법사";
            hp = 130;
            maxHp = 130;
            atk = 15;
            arm = 10;
            cri = 15;
            avoid = 5;

            skills = new List<Skill>();
            Skill normalAttack = new Skill();
            Skill normalBlock = new Skill();
            normalAttack.Init("공격", -1, -1);
            normalBlock.Init("쉴드", 30, 30);
            skills.Add(normalAttack);
            skills.Add(normalBlock);

            abilities = new List<Ability>();
            Ability toxic = new Ability();
            toxic.Init("맹독", 3);
            abilities.Add(toxic);
        }
    }
}
