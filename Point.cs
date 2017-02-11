﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMeans
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Color Color { get; set; }
        public Point(double x, double y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public Point(Point point, Color color)
        {
            X = point.X;
            Y = point.Y;
            Color = color;
        }
    }
}
