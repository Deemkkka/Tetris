﻿using System;
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

            Point point1 = new Point();
            point1.x = 2;
            point1.y = 3;
            point1.c = '*';
            point1.Draw();

            //Relay
            Console.ReadKey();
        }


        
    }
}
