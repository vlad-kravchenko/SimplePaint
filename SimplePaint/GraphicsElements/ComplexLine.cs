using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SimplePaint.GraphicsElements
{
    public class ComplexLine : BaseElement
    {
        public List<PointF> Points { get; set; }
        public PointF ActivePoint { get; set; }

        public ComplexLine(int lineWidth, Color lineColor) : base(lineWidth, lineColor)
        {
            Points = new List<PointF>();
        }

        public override void Draw(Graphics g)
        {
            if (Points.Count == 1)
            {
                g.DrawLine(new Pen(LineColor, LineWidth), Points.Last(), ActivePoint);
            }
            else if (Points.Count > 1)
            {
                for (int i = 0; i < Points.Count - 1; i++)
                    g.DrawLine(new Pen(LineColor, LineWidth), Points[i], Points[i + 1]);
                if (!Finished)
                    g.DrawLine(new Pen(LineColor, LineWidth), Points.Last(), ActivePoint);
            }
        }
    }
}