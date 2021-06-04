using System;
using System.Drawing;

namespace SimplePaint.GraphicsElements
{
    public class BaseElement
    {
        public Color LineColor { get; set; }
        public int LineWidth { get; set; }

        public bool Finished { get; set; }

        public BaseElement(int lineWidth, Color lineColor) 
        {
            LineWidth = lineWidth;
            LineColor = lineColor;
        }

        public void EndElement()
        {
            Finished = true;
        }

        public virtual void Draw(Graphics g) { }

        protected RectangleF GetRect(PointF start, PointF end)
        {
            return new RectangleF(Math.Min(start.X, end.X), Math.Min(start.Y, end.Y), Math.Abs(start.X - end.X), Math.Abs(start.Y - end.Y));
        }
    }
}