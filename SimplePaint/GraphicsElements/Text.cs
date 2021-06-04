using System.Drawing;

namespace SimplePaint.GraphicsElements
{
    public class Text : BaseElement
    {
        public Font Font { get; set; }
        public string TextString { get; set; }
        public PointF Location { get; set; }

        public Text(int lineWidth, Color lineColor, Font font, string text) : base(lineWidth, lineColor)
        {
            Font = font;
            TextString = text;
        }

        public override void Draw(Graphics g)
        {
            g.DrawString(TextString, Font, new SolidBrush(LineColor), Location);
        }
    }
}