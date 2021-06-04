using System.Drawing;

namespace SimplePaint.GraphicsElements
{
    public class Ellipse : BaseElement
    {
        public Color FillColor { get; set; }
        public bool Filled { get; set; }

        public PointF Point1 { get; set; }
        public PointF Point2 { get; set; }

        public Ellipse(int lineWidth, Color lineColor, Color fillColor, bool filled) : base(lineWidth, lineColor)
        {
            FillColor = fillColor;
            Filled = filled;
        }

        public override void Draw(Graphics g)
        {
            if (Filled)
                g.FillEllipse(new SolidBrush(FillColor), GetRect(Point1, Point2));
            g.DrawEllipse(new Pen(LineColor, LineWidth), GetRect(Point1, Point2));

            if (!Finished)
            {
                Pen pen = new Pen(Color.Black);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawRectangle(pen, Rectangle.Round(GetRect(Point1, Point2)));
            }
        }
    }
}