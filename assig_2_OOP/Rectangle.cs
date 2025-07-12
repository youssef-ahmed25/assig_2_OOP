using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig_2_OOP
{
    internal class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
         
        }

        public double Width
        {
            get { return width; }
            set { width = value< 0?0:value; }
        }
        

        public double Height
        {
            get { return height; }
            set { height = value < 0 ? 0 : value; ; }
        }
        public double Area()
        {
            return width * height;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"area of rectange:{Area()}");
        }
    }
}
