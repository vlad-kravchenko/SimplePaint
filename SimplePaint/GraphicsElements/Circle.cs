using System;
using System.Drawing;

namespace SimplePaint.GraphicsElements
{
    public class Circle : BaseElement
    {
        public Color FillColor { get; set; }
        public bool Filled { get; set; }

        public PointF Point1 { get; set; }
        public PointF Point2 { get; set; }

        public Circle(int lineWidth, Color lineColor, Color fillColor, bool filled) : base(lineWidth, lineColor)
        {
            FillColor = fillColor;
            Filled = filled;
        }

        public override void Draw(Graphics g)
        {
            float radius = GetDistance(Point1, Point2);

            PointF p1 = new PointF(Point1.X - radius, Point1.Y - radius);
            PointF p2 = new PointF(Point1.X + radius, Point1.Y + radius);

            if (Filled)
                g.FillEllipse(new SolidBrush(FillColor), GetRect(p1, p2));
            g.DrawEllipse(new Pen(LineColor, LineWidth), GetRect(p1, p2));

            if (!Finished)
            {
                Pen pen = new Pen(Color.Black);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawRectangle(pen, Rectangle.Round(GetRect(p1, p2)));
            }
        }

        private float GetDistance(PointF p1, PointF p2)
        {
            return (float)Math.Pow(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2), 0.5);
        }
    }
}