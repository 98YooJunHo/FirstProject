using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Game
    {
        public void Start()
        {
            // 타이틀 씬 진입
            while (true)
            {
                CharacterBase player = new CharacterBase();
                //System.ConsoleKeyInfo playerInput;
                string chr;
                int count = 1;
                int act = 1;
                TitleScene Title = new TitleScene();
                Title.Print();
                Console.ReadKey();

                // 캐릭터 선택 씬 진입
                while (true)
                {
                    SelectScene Select = new SelectScene();
                    chr = Select.Print();
                    if (chr != null)
                    {
                        Character cha = new Character();
                        cha.Print(ref chr);
                        if (chr == "재선택")
                        {
                            continue;
                        }

                        if (chr != "재선택")
                        {
                            if (chr == "기사")
                            {
                                player = new Knight();
                            }
                            break;
                        }
                    }
                }

                // 메인 씬 진입
                while (true)
                {
                    MainScene main = new MainScene();
                    main.Do(ref player, ref count, ref act);
                    break;
                }
                break;
            }
        }
    }
}
