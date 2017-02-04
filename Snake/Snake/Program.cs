﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.SetWindowSize(80,26);
            Console.SetBufferSize(80, 26);
            //frame
            HorizontalLine upline = new HorizontalLine(0,78,0,'+');
            HorizontalLine downline = new HorizontalLine(0,78,24,'+');
            VerticalLine leftline = new VerticalLine(0,24,0,'+');
            VerticalLine rightline = new VerticalLine(0,24,78,'+');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();

            //point
            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            Console.ReadLine();
        }
  

    }
}
