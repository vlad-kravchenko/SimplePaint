using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace SimplePaint.GraphicsElements
{
    public class PenPoints : BaseElement
    {
        public List<List<PointF>> Sections { get; set; }

        public PenPoints(int lineWidth, Color lineColor) : base(lineWidth, lineColor)
        {
            Sections = new List<List<PointF>>();
            Sections.Add(new List<PointF>());
        }

        public override void Draw(Graphics g)
        {
            foreach(var section in Sections)
            {
                GraphicsPath path = new GraphicsPath();
                for (int i = 0; i < section.Count - 1; i++)
                    path.AddLine(section[i], section[i + 1]);
                g.DrawPath(new Pen(LineColor, LineWidth), path);
            }
        }

        public void PrepareNextSection()
        {
            if (Sections.Last().Count > 0)
                Sections.Add(new List<PointF>());
        }
    }
}