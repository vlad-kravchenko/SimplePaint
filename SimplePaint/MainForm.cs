using SimplePaint.GraphicsElements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class MainForm : Form
    {
        Bitmap image = null;

        BaseElement currentElement;
        List<BaseElement> elements = new List<BaseElement>();
        Color lineColor = Color.Black;
        Color fillColor = Color.White;
        int lineWidth = 1;
        Font font = new Font(new FontFamily("Times New Roman"), 10);

        public MainForm()
        {
            InitializeComponent();

            labelFont.Text = font.Name + ": " + font.Size + " (" + font.Style + ")";
            panelFillColor.BackColor = fillColor;
            panelLineColor.BackColor = lineColor;
            cbLineWidth.SelectedIndex = 0;
        }

        #region Main menu

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentElement = null;
            elements.Clear();
            lineColor = Color.Black;
            fillColor = Color.White;
            lineWidth = 1;
            font = new Font(new FontFamily("Times New Roman"), 10);
            labelFont.Text = font.Name + ": " + font.Size + " (" + font.Style + ")";
            panelFillColor.BackColor = fillColor;
            panelLineColor.BackColor = lineColor;
            cbLineWidth.SelectedIndex = 0;
            panel.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var fs = File.OpenRead(dialog.FileName))
                    image = new Bitmap(fs);

                Graphics g = panel.CreateGraphics();
                g.DrawImage(image, 0, 0);
                g.Dispose();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImageFormat format = ImageFormat.Jpeg;
                Bitmap bmp = new Bitmap(panel.ClientSize.Width, panel.ClientSize.Height);
                panel.DrawToBitmap(bmp, panel.ClientRectangle);
                switch (dialog.FilterIndex)
                {
                    case 1:
                        format = ImageFormat.Jpeg;
                        break;
                    case 2:
                        format = ImageFormat.Bmp;
                        break;
                }
                bmp.Save(dialog.FileName, format);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elements.Clear();
            currentElement = null;
            foreach (var btn in toolStrip.Items)
                (btn as ToolStripButton).Checked = false;
            panel.Invalidate();
        }

        #endregion

        #region Drawing

        private void btnDrawingTool_Click(object sender, EventArgs e)
        {
            foreach (var btn in toolStrip.Items)
                (btn as ToolStripButton).Checked = false;
            (sender as ToolStripButton).Checked = true;

            if (sender == btnPen && btnPen.Checked)
                currentElement = new PenPoints(lineWidth, lineColor);
            else if (sender == btnLine && btnLine.Checked)
                currentElement = new Line(lineWidth, lineColor);
            else if (sender == btnComplexLine && btnComplexLine.Checked)
                currentElement = new ComplexLine(lineWidth, lineColor);
            else if (sender == btnText && btnText.Checked)
            {
                string text = Microsoft.VisualBasic.Interaction.InputBox("Input text", "Input text");
                if (string.IsNullOrEmpty(text))
                    btnText.Checked = false;
                else
                {
                    currentElement = new Text(lineWidth, lineColor, font, text);
                    toolTip.Active = true;
                }
            }
            else if (sender == btnRect && btnRect.Checked)
                currentElement = new SimpleRectangle(lineWidth, lineColor, fillColor, cbFilled.Checked);
            else if (sender == btnCircle && btnCircle.Checked)
                currentElement = new Circle(lineWidth, lineColor, fillColor, cbFilled.Checked);
            else if (sender == btnEllipse && btnEllipse.Checked)
                currentElement = new Ellipse(lineWidth, lineColor, fillColor, cbFilled.Checked);
            else if (sender == btnEraser && btnEraser.Checked)
                currentElement = new Eraser(lineWidth, panel.BackColor);
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnPen.Checked)
            {
                (currentElement as PenPoints).Sections.Last().Add(new PointF(e.X, e.Y));
            }
            else if (btnLine.Checked)
            {
                if ((currentElement as Line).Point1 == PointF.Empty)
                    (currentElement as Line).Point1 = new PointF(e.X, e.Y);
                else if ((currentElement as Line).Point1 != PointF.Empty)
                {
                    (currentElement as Line).Point2 = new PointF(e.X, e.Y);
                    EndElement();
                }
            }
            else if (btnComplexLine.Checked)
            {
                (currentElement as ComplexLine).Points.Add(new PointF(e.X, e.Y));
            }
            else if (btnText.Checked)
            {
                (currentElement as Text).Location = new PointF(e.X + 3, e.Y + 17);
                EndElement();
                toolTip.Hide(this);
                toolTip.Active = false;
            }
            else if (btnRect.Checked)
            {
                if ((currentElement as SimpleRectangle).Point1 == PointF.Empty)
                    (currentElement as SimpleRectangle).Point1 = new PointF(e.X, e.Y);
                else if ((currentElement as SimpleRectangle).Point1 != PointF.Empty)
                {
                    (currentElement as SimpleRectangle).Point2 = new PointF(e.X, e.Y);
                    EndElement();
                }
            }
            else if (btnCircle.Checked)
            {
                if ((currentElement as Circle).Point1 == PointF.Empty)
                    (currentElement as Circle).Point1 = new PointF(e.X, e.Y);
                else if ((currentElement as Circle).Point1 != PointF.Empty)
                {
                    (currentElement as Circle).Point2 = new PointF(e.X, e.Y);
                    EndElement();
                }
            }
            else if (btnEllipse.Checked)
            {
                if ((currentElement as Ellipse).Point1 == PointF.Empty)
                    (currentElement as Ellipse).Point1 = new PointF(e.X, e.Y);
                else if ((currentElement as Ellipse).Point1 != PointF.Empty)
                {
                    (currentElement as Ellipse).Point2 = new PointF(e.X, e.Y);
                    EndElement();
                }
            }
            else if (btnEraser.Checked)
            {
                (currentElement as Eraser).Sections.Last().Add(new PointF(e.X, e.Y));
            }
            panel.Invalidate();
        }

        private void EndElement()
        {
            currentElement.EndElement();
            elements.Add(currentElement);
            currentElement = null;
            foreach (var btn in toolStrip.Items)
                (btn as ToolStripButton).Checked = false;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            panel.Focus();
            if (currentElement == null || currentElement.Finished) return;

            if (btnPen.Checked)
            {
                if (e.Button == MouseButtons.Left)
                    (currentElement as PenPoints).Sections.Last().Add(new PointF(e.X, e.Y));
                else
                    (currentElement as PenPoints).PrepareNextSection();
            }
            else if (btnLine.Checked)
            {
                if ((currentElement as Line).Point1 != PointF.Empty)
                    (currentElement as Line).Point2 = new PointF(e.X, e.Y);
            }
            else if (btnComplexLine.Checked)
            {
                (currentElement as ComplexLine).ActivePoint = new PointF(e.X, e.Y);
            }
            else if (btnText.Checked)
            {
                toolTip.SetToolTip(panel, (currentElement as Text).TextString);
                toolTip.Show((currentElement as Text).TextString, this);
            }
            else if (btnRect.Checked)
            {
                if ((currentElement as SimpleRectangle).Point1 != PointF.Empty)
                    (currentElement as SimpleRectangle).Point2 = new PointF(e.X, e.Y);
            }
            else if (btnEllipse.Checked)
            {
                if ((currentElement as Ellipse).Point1 != PointF.Empty)
                    (currentElement as Ellipse).Point2 = new PointF(e.X, e.Y);
            }
            else if (btnCircle.Checked)
            {
                if ((currentElement as Circle).Point1 != PointF.Empty)
                    (currentElement as Circle).Point2 = new PointF(e.X, e.Y);
            }
            else if (btnEraser.Checked)
            {
                if (e.Button == MouseButtons.Left)
                    (currentElement as Eraser).Sections.Last().Add(new PointF(e.X, e.Y));
                else
                    (currentElement as Eraser).PrepareNextSection();
            }
            panel.Invalidate();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            if (image != null) 
                e.Graphics.DrawImage(image, 0, 0);

            foreach (var element in elements)
                element.Draw(e.Graphics);

            if (currentElement != null)
                currentElement.Draw(e.Graphics);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!panel.Focused) return;

            if (btnComplexLine.Checked)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        EndElement();
                        break;
                    case Keys.Escape:
                        if ((currentElement as ComplexLine).Points.Any())
                            (currentElement as ComplexLine).Points.Remove((currentElement as ComplexLine).Points.Last());
                        break;
                }
            }
            else if ((btnPen.Checked || btnEraser.Checked) && e.KeyCode == Keys.Escape)
            {
                EndElement();
            }
            panel.Invalidate();
        }

        #endregion

        #region Line, Color and Font

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = fillColor;
            if (dialog.ShowDialog() == DialogResult.OK)
                fillColor = dialog.Color;
            panelFillColor.BackColor = fillColor;
        }

        private void btnLineColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = lineColor;
            if (dialog.ShowDialog() == DialogResult.OK)
                lineColor = dialog.Color;
            panelLineColor.BackColor = lineColor;
        }

        private void btnFontSettings_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.Font = font;
            if (dialog.ShowDialog() == DialogResult.OK)
                font = dialog.Font;
            labelFont.Text = font.Name + ": " + font.Size + " (" + font.Style + ")";
        }

        private void cbLineWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            lineWidth = int.Parse(cbLineWidth.SelectedItem.ToString());
        }

        #endregion
    }
}