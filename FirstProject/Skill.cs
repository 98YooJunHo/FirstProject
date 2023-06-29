using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Skill
    {
        // 현재 배틀에 존재하는 스킬 종류
        // 맹독, 철갑, 회피, 분노, 광기
        public string name;
        public int count;
        public int fullCount;

        public void Init(string nam, int cool, int fullCool)
        {
            name = nam;
            count = cool;
            fullCount = fullCool;
        }
    }
}
