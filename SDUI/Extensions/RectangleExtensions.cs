﻿using System.Drawing;
using System.Drawing.Drawing2D;

namespace SDUI.Extensions
{
    internal static class RectangleExtensions
    {
        internal static GraphicsPath Radius(this Rectangle rectangle, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.X + rectangle.Width - radius - 1, rectangle.Y, radius, radius, 270, 90);
            path.AddArc(rectangle.X + rectangle.Width - radius - 1, rectangle.Y + rectangle.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            return path;
        }

        internal static GraphicsPath Radius(this RectangleF rectangle, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.X + rectangle.Width - radius - 1, rectangle.Y, radius, radius, 270, 90);
            path.AddArc(rectangle.X + rectangle.Width - radius - 1, rectangle.Y + rectangle.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            return path;
        }

        public static Rectangle ToRectangle(this RectangleF rect)
        {
            return Rectangle.Round(rect);
        }

        public static RectangleF ToRectangleF(this Rectangle rect)
        {
            return new RectangleF(rect.X, rect.Y, rect.Width, rect.Height);
        }
    }
}
