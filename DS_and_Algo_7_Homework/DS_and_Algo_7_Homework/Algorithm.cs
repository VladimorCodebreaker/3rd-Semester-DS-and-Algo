using System;
using System.Drawing;
using System.Collections.Generic;

namespace DS_and_Algo_7_Homework
{
    public class Algorithm
    {
        private static bool isValid(int[,] screen, int m, int n, int x, int y, int prevC, int newC)
        {
            if (x < 0 || x >= m || y < 0 || y >= n || screen[x, y] != prevC
            || screen[x, y] == newC)
            {
                return false;
            }
            return true;
        }

        internal static void FloodFill(int[,] screen, int m, int n, int x, int y, int prevC, int newC)
        {
            List<Tuple<int, int>> queue = new List<Tuple<int, int>>();

            queue.Add(new Tuple<int, int>(x, y));

            screen[x, y] = newC;

            while (queue.Count > 0)
            {
                Tuple<int, int> currPixel = queue[queue.Count - 1];
                queue.RemoveAt(queue.Count - 1);

                int posX = currPixel.Item1;
                int posY = currPixel.Item2;

                if (isValid(screen, m, n, posX + 1, posY, prevC, newC))
                {
                    screen[posX + 1, posY] = newC;
                    queue.Add(new Tuple<int, int>(posX + 1, posY));
                }

                if (isValid(screen, m, n, posX - 1, posY, prevC, newC))
                {
                    screen[posX - 1, posY] = newC;
                    queue.Add(new Tuple<int, int>(posX - 1, posY));
                }

                if (isValid(screen, m, n, posX, posY + 1, prevC, newC))
                {
                    screen[posX, posY + 1] = newC;
                    queue.Add(new Tuple<int, int>(posX, posY + 1));
                }

                if (isValid(screen, m, n, posX, posY - 1, prevC, newC))
                {
                    screen[posX, posY - 1] = newC;
                    queue.Add(new Tuple<int, int>(posX, posY - 1));
                }
            }
        }
    }
}
