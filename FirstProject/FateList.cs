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

            Fate fate5 = new Fate();
            Fate fate6 = new Fate();
            Fate fate7 = new Fate();
            Fate fate8 = new Fate();
            Fate fate9 = new Fate();
            fate.Init("독  한", "맹독", 1);
            fate1.Init("튼튼한", "철갑", 1);
            fate2.Init("민첩한", "회피", 1);
            fate3.Init("분노한", "분노", 1);
            fate4.Init("미  친", "광기", 1);

            fate5.Init("지독한", "맹독", 2);
            fate6.Init("무  통", "철갑", 2);
            fate7.Init("신속한", "회피", 2);
            fate8.Init("격분한", "분노", 2);
            fate9.Init("맑은눈", "광기", 2);
            list.Add(fate);
            list.Add(fate1);
            list.Add(fate2);
            list.Add(fate3);
            list.Add(fate4);

            list.Add(fate5);
            list.Add(fate6);
            list.Add(fate7);
            list.Add(fate8);
            list.Add(fate9);
        }
    }
}
