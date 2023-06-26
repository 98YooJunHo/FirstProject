using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class MainScene
    {
        // 커서 위치 (37,0)부터 시작 y 마지막 좌표 28
        public void Print()
        {
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
        }
    }
}
