using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleImage.Actions
{
    static class Model
    {
        public static double Scale { get; set; } = 0;
        public static Point P0 { get; set; } = new Point(0, 0);
        public static Point PCurrent { get; set; } = new Point(0, 0);
        public static Point PRelative
        {
            get
            {
                return new Point(PCurrent.X - P0.X, PCurrent.Y - P0.Y);
            }
        }

        public static double getLength(Point p)
        {
            double distance = 0;
            distance = Math.Round(Math.Sqrt(Math.Pow(p.X - P0.X, 2) + Math.Pow(p.Y - P0.Y, 2)), 2);
            return distance;
        }
        public static double getLength()
        {
            return getLength(PCurrent);
        }
        public static double getRealLength(Point p)
        {
            double distance = 0;
            distance = Math.Round(Math.Sqrt(Math.Pow(p.X - P0.X, 2) + Math.Pow(p.Y - P0.Y, 2)) / Scale, 2);
            return distance;
        }
        public static double getRealLength()
        {
            return getRealLength(PCurrent);
        }
        public static Point getRealPRelative(Point p)
        {
            if (Scale > 0) {
                return new Point((int)((p.X - P0.X) / Scale), (int)((p.Y - P0.Y) / Scale));
            }
            else {
                return new Point(0, 0);
                    }
        }
        public static Point getRealPRelative()
        {
            return getRealPRelative(PCurrent);
        }
    }
}
