using System.Drawing;

namespace SimplePaint.GraphicsElements
{
    public class SimpleRectangle : BaseElement
    {
        public Color FillColor { get; set; }
        public bool Filled { get; set; }

        public PointF Point1 { get; set; }
        public PointF Point2 { get; set; }

        public SimpleRectangle(int lineWidth, Color lineColor, Color fillColor, bool filled) : base(lineWidth, lineColor)
        {
            FillColor = fillColor;
            Filled = filled;
        }

        public override void Draw(Graphics g)
        {
            if (Filled)
                g.FillRectangle(new SolidBrush(FillColor), GetRect(Point1, Point2));
            g.DrawRectangle(new Pen(LineColor, LineWidth), Rectangle.Round(GetRect(Point1, Point2)));
        }
    }
}