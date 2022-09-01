using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Square
    {
        Point[,] points = new Point[2,2];

        public Square(int x, int y, char sym)
        {
            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    points[i, j] = new Point(x + i, y + j, sym);
                }
            }
            //points[0] = new Point(x, y, sym);
            //points[1] = new Point(x + 1, y, sym);
            //points[2] = new Point(x, y + 1, sym);
            //points[3] = new Point(x + 1, y + 1, sym);
        }

        public void Draw()
        {
            foreach(Point p in points)
            {
                p.Draw();
            }
        }
    }
}
