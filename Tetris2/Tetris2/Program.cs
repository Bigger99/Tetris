using System;

namespace Tetris2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40,30);
            Console.SetBufferSize(40,30);

            int x1 = 2;
            int y1 = 2;
            char c1 = '*';
            Draw(x1,y1,c1);

            int x2 = 4;
            int y2 = 5;
            char c2 = '#';
            Draw(x2, y2, c2);


            Console.ReadKey();
        }

        static void Draw(int x, int y, char c) {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
