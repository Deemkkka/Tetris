using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Stick
    {
        Point[] points = new Point[4];

        public Stick(int x, int y, char sym)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(x, y + i, sym);
            }
        }

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
    }
}
