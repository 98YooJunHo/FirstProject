using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class FateList
    {
        public List<Fate> list = new List<Fate>();
        public FateList() 
        {
            Fate fate = new Fate();
            Fate fate1 = new Fate();
            Fate fate2 = new Fate();
            Fate fate3 = new Fate();
            Fate fate4 = new Fate();
            fate.Init("지독한", "맹독", 1);
            list.Add(fate);
            fate1.Init("튼튼한", "철갑", 1);
            list.Add(fate1);
            fate2.Init("민첩한", "회피", 1);
            list.Add(fate2);
            fate3.Init("분  한", "분노", 1);
            list.Add(fate3);
            fate4.Init("미  친", "광기", 1);
        }
    }
}
