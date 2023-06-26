using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Game
    {
        TitleScene Title = new TitleScene();
        SelectScene Select = new SelectScene();
        System.ConsoleKeyInfo playerInput;
        string character;
        public void Start()
        {
            while (true)
            {
                // 타이틀 씬 진입
                Title.Print();
                Console.ReadKey();
                character = Select.Print();
                
                break;
                while (true)
                {
                    // 메인 씬 진입

                }
            }
        }
    }
}
