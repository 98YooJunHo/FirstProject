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
            Console.SetCursorPosition(52, 27);
            Console.Write("아무키나 입력 하세요");
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

            Console.SetCursorPosition(38, 1);
            Console.Write(" _____");
            Console.SetCursorPosition(38, 2);
            Console.Write("|_   _|");
            Console.SetCursorPosition(38, 3);
            Console.Write("  | |    ___  __      __  ___  _ __");
            Console.SetCursorPosition(38, 4);
            Console.Write("  | |   / _ \\ \\ \\ /\\ / / / _ \\| '__|");
            Console.SetCursorPosition(38, 5);
            Console.Write("  | |  | (_) | \\ V  V / |  __/| |");
            Console.SetCursorPosition(38, 6);
            Console.Write("  \\_/   \\___/   \\_/\\_/   \\___||_|");

            Console.SetCursorPosition(48, 7);
            Console.Write(" _____   __");
            Console.SetCursorPosition(48, 8);
            Console.Write("|  _  | / _|");
            Console.SetCursorPosition(48, 9);
            Console.Write("| | | || |_");
            Console.SetCursorPosition(48, 10);
            Console.Write("| | | ||  _|");
            Console.SetCursorPosition(48, 11);
            Console.Write("\\ \\_/ /| |");
            Console.SetCursorPosition(48, 12);
            Console.Write(" \\___/ |_|");

            Console.SetCursorPosition(53, 13);
            Console.Write("______               _    _");
            Console.SetCursorPosition(53, 14);
            Console.Write("|  _  \\             | |  | |");
            Console.SetCursorPosition(53, 15);
            Console.Write("| | | |  ___   __ _ | |_ | |__");
            Console.SetCursorPosition(53, 16);
            Console.Write("| | | | / _ \\ / _` || __|| '_ \\");
            Console.SetCursorPosition(53, 17);
            Console.Write("| |/ / |  __/| (_| || |_ | | | |");
            Console.SetCursorPosition(53, 18);
            Console.Write("|___/   \\___| \\__,_| \\__||_| |_|");
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
