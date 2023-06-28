using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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
                        CharacterSelect cha = new CharacterSelect();
                        cha.Print(ref chr);
                        if (chr == "종료")
                        {
                            return;
                        }

                        if (chr == "타이틀로")
                        {
                            break;
                        }

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

                if (chr == "타이틀로")
                {
                    continue;
                }
                // 메인 씬 진입
                while (true)
                {
                    MainScene main = new MainScene();
                    chr = main.Do(ref player, ref count, ref act);
                    if (chr == "종료") 
                    {
                        return;
                    }

                    if (chr == "타이틀로")
                    {
                        break;
                    }
                    break;
                }
                continue;
            }
        }
    }
}
