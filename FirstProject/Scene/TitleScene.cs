using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class TitleScene
    {
        // 커서 위치 (37,0)부터 시작 y 마지막 좌표 28
        public void Print()
        {
            Clear();
            Console.SetCursorPosition(52, 26);
            Console.Write("아무키나 입력 하세요");
            Console.SetCursorPosition(58, 27);
            Console.Write("종료 : q");
            for (int y = 0; y < 29; y++)
            {
                for (int x = 0; x < 49; x++)
                {
                    Console.SetCursorPosition(x + 37, y);
                    if (x == 0 && y == 0)
                    {
                        Console.Write("┌");
                    }
                    else if (x == 48 && y == 0)
                    {
                        Console.Write("┐");
                    }
                    else if (x == 0 && y == 28)
                    {
                        Console.Write("└");
                    }
                    else if (x == 48 && y == 28)
                    {
                        Console.Write("┘");
                    }
                    else if (y == 0 || y == 28)
                    {
                        Console.Write("─");
                    }
                    else if (x == 0 || x == 48)
                    {
                        Console.Write("│");
                    }
                    else
                    { /* empty */ }
                }
            }


            Console.SetCursorPosition(40, 6);
            Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⣀⠀⠀⠀");
            Console.SetCursorPosition(40, 7);
            Console.Write("⠀⠀⠀⠀⠀⠛⢛⣿⠛⠛⠁⢀⣀⠀⢀⡀⢀⡀⢀⡀⠀⣀⡀⠀⢀⡀⣀⡀");
            Console.SetCursorPosition(40, 8);
            Console.Write("⠀⠀⠀⠀⠀⠀⢸⡟⠀⠀⣼⠟⢹⡧⢸⣧⣿⡇⣾⢱⣿⣭⠿⠀⣿⠟⠻⠃⠀");
            Console.SetCursorPosition(40, 9);
            Console.Write("⠀⠀⠀⠀⠀⠀⢸⠇⠀⠀⢿⣶⠾⠁⢸⡟⠸⡿⠃⠸⣿⣤⠶⠠⡿⠀");
            Console.SetCursorPosition(40, 10);
            Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⠀");
            Console.SetCursorPosition(40, 11);
            Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⠾⠿⢷⣆⠀⢰⡟⠉⠀");
            Console.SetCursorPosition(40, 12);
            Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⠁⠀⠀⣸⡏⠚⣿⠛⠃");
            Console.SetCursorPosition(40, 13);
            Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣤⣠⣴⠟⠀⢠⡿⠀");
            Console.SetCursorPosition(40, 14);
            Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠀⠀⠀⠈⠁");
            Console.SetCursorPosition(40, 15);
            Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(40, 16);
            Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⡿⢷⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⠶⢠⣿");
            Console.SetCursorPosition(40, 17);
            Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡇⠀⠈⣿⢀⣴⢾⣶⠄⣾⡄⣰⡖⣰⡆⢸⡇");
            Console.SetCursorPosition(40, 18);
            Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣃⣀⣴⡟⢸⣟⣋⣡⠀⢸⣷⠟⠀⣿⠀⣾⠇");
            Console.SetCursorPosition(40, 19);
            Console.Write("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠋⠁⠀⠀⠉⠉⠁⠀⠀⠉⠀⠀⠉⠀⠉");
        }
        void Clear()
        {
            for (int y = 1; y < 28; y++)
            {
                for (int x = 1; x < 48; x++)
                {
                    Console.SetCursorPosition(x + 37, y);
                    Console.WriteLine(" ");
                }
            }
        }

    }
}
