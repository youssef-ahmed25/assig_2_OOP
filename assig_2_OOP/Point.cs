using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig_2_OOP
{
    internal class Point
    {

        public int x1;
        public int y1;
        public int x2;
        public int y2;

        public Point(int x, int y,int a,int b)
        {
            this.x1 = x;
            this.y1 = y;
            this.x2 = a;
            this.y2 = b;
        }
        public void distance() {

            double x = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) ) ;

            Console.WriteLine("distance="+x);
        
        }

    }
}
