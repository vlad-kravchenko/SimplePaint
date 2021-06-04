using System.Drawing;

namespace SimplePaint.GraphicsElements
{
    public class Line : BaseElement
    {
        public PointF Point1 { get; set; }
        public PointF Point2 { get; set; }

        public Line(int lineWidth, Color lineColor) : base(lineWidth, lineColor)
        {

        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(new Pen(LineColor, LineWidth), Point1, Point2);
        }
    }
}