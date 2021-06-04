namespace SimplePaint
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnPen = new System.Windows.Forms.ToolStripButton();
            this.btnLine = new System.Windows.Forms.ToolStripButton();
            this.btnComplexLine = new System.Windows.Forms.ToolStripButton();
            this.btnRect = new System.Windows.Forms.ToolStripButton();
            this.btnEllipse = new System.Windows.Forms.ToolStripButton();
            this.btnCircle = new System.Windows.Forms.ToolStripButton();
            this.btnText = new System.Windows.Forms.ToolStripButton();
            this.btnEraser = new System.Windows.Forms.ToolStripButton();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.cbFilled = new System.Windows.Forms.CheckBox();
            this.cbLineWidth = new System.Windows.Forms.ComboBox();
            this.panelLineColor = new System.Windows.Forms.Panel();
            this.panelFillColor = new System.Windows.Forms.Panel();
            this.labelFont = new System.Windows.Forms.Label();
            this.btnFontSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPen,
            this.btnLine,
            this.btnComplexLine,
            this.btnRect,
            this.btnEllipse,
            this.btnCircle,
            this.btnText,
            this.btnEraser});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnPen
            // 
            this.btnPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPen.Image = ((System.Drawing.Image)(resources.GetObject("btnPen.Image")));
            this.btnPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(23, 22);
            this.btnPen.Text = "Pen";
            this.btnPen.Click += new System.EventHandler(this.btnDrawingTool_Click);
            // 
            // btnLine
            // 
            this.btnLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(23, 22);
            this.btnLine.Text = "Line";
            this.btnLine.Click += new System.EventHandler(this.btnDrawingTool_Click);
            // 
            // btnComplexLine
            // 
            this.btnComplexLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnComplexLine.Image = ((System.Drawing.Image)(resources.GetObject("btnComplexLine.Image")));
            this.btnComplexLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnComplexLine.Name = "btnComplexLine";
            this.btnComplexLine.Size = new System.Drawing.Size(23, 22);
            this.btnComplexLine.Text = "Complex Line";
            this.btnComplexLine.Click += new System.EventHandler(this.btnDrawingTool_Click);
            // 
            // btnRect
            // 
            this.btnRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRect.Image = ((System.Drawing.Image)(resources.GetObject("btnRect.Image")));
            this.btnRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(23, 22);
            this.btnRect.Text = "Rectangle";
            this.btnRect.Click += new System.EventHandler(this.btnDrawingTool_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnEllipse.Image")));
            this.btnEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(23, 22);
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.Click += new System.EventHandler(this.btnDrawingTool_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCircle.Image = ((System.Drawing.Image)(resources.GetObject("btnCircle.Image")));
            this.btnCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(23, 22);
            this.btnCircle.Text = "Circle";
            this.btnCircle.Click += new System.EventHandler(this.btnDrawingTool_Click);
            // 
            // btnText
            // 
            this.btnText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnText.Image = ((System.Drawing.Image)(resources.GetObject("btnText.Image")));
            this.btnText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(23, 22);
            this.btnText.Text = "Text";
            this.btnText.Click += new System.EventHandler(this.btnDrawingTool_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEraser.Image = ((System.Drawing.Image)(resources.GetObject("btnEraser.Image")));
            this.btnEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(23, 22);
            this.btnEraser.Text = "Eraser";
            this.btnEraser.Click += new System.EventHandler(this.btnDrawingTool_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.cbFilled);
            this.panelSettings.Controls.Add(this.cbLineWidth);
            this.panelSettings.Controls.Add(this.panelLineColor);
            this.panelSettings.Controls.Add(this.panelFillColor);
            this.panelSettings.Controls.Add(this.labelFont);
            this.panelSettings.Controls.Add(this.btnFontSettings);
            this.panelSettings.Controls.Add(this.label2);
            this.panelSettings.Controls.Add(this.btnFillColor);
            this.panelSettings.Controls.Add(this.btnLineColor);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettings.Location = new System.Drawing.Point(0, 49);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(800, 66);
            this.panelSettings.TabIndex = 1;
            // 
            // cbFilled
            // 
            this.cbFilled.AutoSize = true;
            this.cbFilled.Location = new System.Drawing.Point(329, 7);
            this.cbFilled.Name = "cbFilled";
            this.cbFilled.Size = new System.Drawing.Size(50, 17);
            this.cbFilled.TabIndex = 6;
            this.cbFilled.Text = "Filled";
            this.cbFilled.UseVisualStyleBackColor = true;
            // 
            // cbLineWidth
            // 
            this.cbLineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLineWidth.FormattingEnabled = true;
            this.cbLineWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5",
            "8",
            "10",
            "12",
            "15",
            "20"});
            this.cbLineWidth.Location = new System.Drawing.Point(270, 5);
            this.cbLineWidth.Name = "cbLineWidth";
            this.cbLineWidth.Size = new System.Drawing.Size(50, 21);
            this.cbLineWidth.TabIndex = 5;
            this.cbLineWidth.SelectedIndexChanged += new System.EventHandler(this.cbLineWidth_SelectedIndexChanged);
            // 
            // panelLineColor
            // 
            this.panelLineColor.BackColor = System.Drawing.Color.Black;
            this.panelLineColor.Location = new System.Drawing.Point(93, 32);
            this.panelLineColor.Name = "panelLineColor";
            this.panelLineColor.Size = new System.Drawing.Size(110, 23);
            this.panelLineColor.TabIndex = 1;
            // 
            // panelFillColor
            // 
            this.panelFillColor.Location = new System.Drawing.Point(93, 3);
            this.panelFillColor.Name = "panelFillColor";
            this.panelFillColor.Size = new System.Drawing.Size(110, 23);
            this.panelFillColor.TabIndex = 0;
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(326, 37);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(73, 13);
            this.labelFont.TabIndex = 2;
            this.labelFont.Text = "Selected font:";
            // 
            // btnFontSettings
            // 
            this.btnFontSettings.Location = new System.Drawing.Point(212, 32);
            this.btnFontSettings.Name = "btnFontSettings";
            this.btnFontSettings.Size = new System.Drawing.Size(108, 23);
            this.btnFontSettings.TabIndex = 4;
            this.btnFontSettings.Text = "Font Settings";
            this.btnFontSettings.UseVisualStyleBackColor = true;
            this.btnFontSettings.Click += new System.EventHandler(this.btnFontSettings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Line width";
            // 
            // btnFillColor
            // 
            this.btnFillColor.Location = new System.Drawing.Point(12, 3);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(75, 23);
            this.btnFillColor.TabIndex = 1;
            this.btnFillColor.Text = "Fill color:";
            this.btnFillColor.UseVisualStyleBackColor = true;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // btnLineColor
            // 
            this.btnLineColor.Location = new System.Drawing.Point(12, 32);
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.Size = new System.Drawing.Size(75, 23);
            this.btnLineColor.TabIndex = 0;
            this.btnLineColor.Text = "Line color:";
            this.btnLineColor.UseVisualStyleBackColor = true;
            this.btnLineColor.Click += new System.EventHandler(this.btnLineColor_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100;
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 115);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 335);
            this.panel.TabIndex = 3;
            this.panel.TabStop = false;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Paint";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnPen;
        private System.Windows.Forms.ToolStripButton btnLine;
        private System.Windows.Forms.ToolStripButton btnRect;
        private System.Windows.Forms.ToolStripButton btnEllipse;
        private System.Windows.Forms.ToolStripButton btnCircle;
        private System.Windows.Forms.ToolStripButton btnComplexLine;
        private System.Windows.Forms.ToolStripButton btnEraser;
        private System.Windows.Forms.ToolStripButton btnText;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Button btnLineColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.Panel panelLineColor;
        private System.Windows.Forms.Panel panelFillColor;
        private System.Windows.Forms.Button btnFontSettings;
        private System.Windows.Forms.ComboBox cbLineWidth;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox cbFilled;
        private System.Windows.Forms.PictureBox panel;
    }
}

