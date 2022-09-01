using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Square s = new Square(2, 5, '*');
            s.Draw();

            Stick stick = new Stick(5, 10, '*');
            stick.Draw();
            //Point point1 = new Point(2, 3, '*');
            //point1.Draw();

            Point p2 = new Point()
            {
                x = 4,
                y = 5,
                c = '#'
            };


            //Relay
            Console.ReadKey();
        }


        
    }
}
