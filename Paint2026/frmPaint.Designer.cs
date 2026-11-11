namespace PaintWinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ToolStrip toolStrip2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStripDropDownButton3 = new ToolStripDropDownButton();
            кругToolStripMenuItem = new ToolStripMenuItem();
            овалToolStripMenuItem = new ToolStripMenuItem();
            треугольникToolStripMenuItem = new ToolStripMenuItem();
            прямоугольникToolStripMenuItem = new ToolStripMenuItem();
            pctrBox = new PictureBox();
            mnuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            pnlRibbon = new Panel();
            toolStrip4 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            label3 = new Label();
            label1 = new Label();
            toolStrip5 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStrip3 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            оченьМаленькийToolStripMenuItem = new ToolStripMenuItem();
            маленькийToolStripMenuItem = new ToolStripMenuItem();
            среднийToolStripMenuItem = new ToolStripMenuItem();
            большойToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            toolStrip2 = new ToolStrip();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctrBox).BeginInit();
            mnuStrip.SuspendLayout();
            pnlRibbon.SuspendLayout();
            toolStrip4.SuspendLayout();
            toolStrip5.SuspendLayout();
            toolStrip3.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip2
            // 
            toolStrip2.AutoSize = false;
            toolStrip2.BackColor = SystemColors.ButtonHighlight;
            toolStrip2.Dock = DockStyle.None;
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton3 });
            toolStrip2.Location = new Point(432, 2);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(51, 50);
            toolStrip2.TabIndex = 3;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton3
            // 
            toolStripDropDownButton3.AutoSize = false;
            toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { кругToolStripMenuItem, овалToolStripMenuItem, треугольникToolStripMenuItem, прямоугольникToolStripMenuItem });
            toolStripDropDownButton3.Image = (Image)resources.GetObject("toolStripDropDownButton3.Image");
            toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            toolStripDropDownButton3.Size = new Size(49, 77);
            toolStripDropDownButton3.Text = "toolStripDropDownButton3";
            // 
            // кругToolStripMenuItem
            // 
            кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            кругToolStripMenuItem.Size = new Size(163, 22);
            кругToolStripMenuItem.Text = "Круг";
            кругToolStripMenuItem.Click += shapeToolStripMenuItem_Click;
            // 
            // овалToolStripMenuItem
            // 
            овалToolStripMenuItem.Name = "овалToolStripMenuItem";
            овалToolStripMenuItem.Size = new Size(163, 22);
            овалToolStripMenuItem.Text = "Овал";
            овалToolStripMenuItem.Click += shapeToolStripMenuItem_Click;
            // 
            // треугольникToolStripMenuItem
            // 
            треугольникToolStripMenuItem.Name = "треугольникToolStripMenuItem";
            треугольникToolStripMenuItem.Size = new Size(163, 22);
            треугольникToolStripMenuItem.Text = "Треугольник";
            треугольникToolStripMenuItem.Click += shapeToolStripMenuItem_Click;
            // 
            // прямоугольникToolStripMenuItem
            // 
            прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            прямоугольникToolStripMenuItem.Size = new Size(163, 22);
            прямоугольникToolStripMenuItem.Text = "Прямоугольник";
            прямоугольникToolStripMenuItem.Click += shapeToolStripMenuItem_Click;
            // 
            // pctrBox
            // 
            pctrBox.BackColor = SystemColors.ButtonHighlight;
            pctrBox.Location = new Point(0, 84);
            pctrBox.Name = "pctrBox";
            pctrBox.Size = new Size(1073, 528);
            pctrBox.TabIndex = 0;
            pctrBox.TabStop = false;
            pctrBox.MouseDown += pctrBox_MouseDown;
            pctrBox.MouseMove += pctrBox_MouseMove;
            pctrBox.MouseUp += pctrBox_MouseUP;
            // 
            // mnuStrip
            // 
            mnuStrip.BackColor = SystemColors.InactiveCaption;
            mnuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            mnuStrip.Location = new Point(0, 0);
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Size = new Size(1184, 24);
            mnuStrip.TabIndex = 1;
            mnuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // pnlRibbon
            // 
            pnlRibbon.BackColor = SystemColors.InactiveCaption;
            pnlRibbon.Controls.Add(toolStrip4);
            pnlRibbon.Controls.Add(label3);
            pnlRibbon.Controls.Add(label1);
            pnlRibbon.Controls.Add(toolStrip5);
            pnlRibbon.Controls.Add(toolStrip2);
            pnlRibbon.Controls.Add(toolStrip3);
            pnlRibbon.Controls.Add(toolStrip1);
            pnlRibbon.Controls.Add(panel1);
            pnlRibbon.Controls.Add(label5);
            pnlRibbon.Controls.Add(label4);
            pnlRibbon.Controls.Add(label2);
            pnlRibbon.Dock = DockStyle.Top;
            pnlRibbon.Location = new Point(0, 24);
            pnlRibbon.Name = "pnlRibbon";
            pnlRibbon.Size = new Size(1184, 63);
            pnlRibbon.TabIndex = 2;
            // 
            // toolStrip4
            // 
            toolStrip4.AutoSize = false;
            toolStrip4.Dock = DockStyle.None;
            toolStrip4.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip4.ImageScalingSize = new Size(64, 64);
            toolStrip4.Items.AddRange(new ToolStripItem[] { toolStripButton2 });
            toolStrip4.Location = new Point(280, 0);
            toolStrip4.Name = "toolStrip4";
            toolStrip4.Size = new Size(71, 48);
            toolStrip4.TabIndex = 5;
            toolStrip4.Text = "toolStrip4";
            toolStrip4.ItemClicked += toolStrip4_ItemClicked;
            // 
            // toolStripButton2
            // 
            toolStripButton2.AutoSize = false;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(70, 45);
            toolStripButton2.Text = "toolStripButton3";
            // 
            // label3
            // 
            label3.Location = new Point(432, 48);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 9;
            label3.Text = "Фигуры";
            // 
            // label1
            // 
            label1.Location = new Point(556, 48);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 8;
            label1.Text = "Кисть";
            // 
            // toolStrip5
            // 
            toolStrip5.AutoSize = false;
            toolStrip5.Dock = DockStyle.None;
            toolStrip5.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip5.ImageScalingSize = new Size(64, 64);
            toolStrip5.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip5.Location = new Point(556, 4);
            toolStrip5.Name = "toolStrip5";
            toolStrip5.Size = new Size(71, 48);
            toolStrip5.TabIndex = 4;
            toolStrip5.Text = "toolStrip5";
            toolStrip5.ItemClicked += toolStrip5_ItemClicked;
            // 
            // toolStripButton1
            // 
            toolStripButton1.AutoSize = false;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(70, 45);
            toolStripButton1.Text = "toolStripButton3";
            // 
            // toolStrip3
            // 
            toolStrip3.AutoSize = false;
            toolStrip3.Dock = DockStyle.None;
            toolStrip3.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip3.ImageScalingSize = new Size(64, 64);
            toolStrip3.Items.AddRange(new ToolStripItem[] { toolStripButton3 });
            toolStrip3.Location = new Point(146, 0);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(71, 48);
            toolStrip3.TabIndex = 3;
            toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton3
            // 
            toolStripButton3.AutoSize = false;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(70, 45);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.AccessibleRole = AccessibleRole.TitleBar;
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton2 });
            toolStrip1.Location = new Point(22, 2);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(51, 48);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.AutoSize = false;
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { оченьМаленькийToolStripMenuItem, маленькийToolStripMenuItem, среднийToolStripMenuItem, большойToolStripMenuItem });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(50, 50);
            toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // оченьМаленькийToolStripMenuItem
            // 
            оченьМаленькийToolStripMenuItem.Name = "оченьМаленькийToolStripMenuItem";
            оченьМаленькийToolStripMenuItem.Size = new Size(137, 22);
            оченьМаленькийToolStripMenuItem.Text = "Микро";
            оченьМаленькийToolStripMenuItem.Click += toolStripDropDownButton2_Click;
            // 
            // маленькийToolStripMenuItem
            // 
            маленькийToolStripMenuItem.Name = "маленькийToolStripMenuItem";
            маленькийToolStripMenuItem.Size = new Size(137, 22);
            маленькийToolStripMenuItem.Text = "Маленький";
            маленькийToolStripMenuItem.Click += toolStripDropDownButton2_Click;
            // 
            // среднийToolStripMenuItem
            // 
            среднийToolStripMenuItem.Name = "среднийToolStripMenuItem";
            среднийToolStripMenuItem.Size = new Size(137, 22);
            среднийToolStripMenuItem.Text = "Средний";
            среднийToolStripMenuItem.Click += toolStripDropDownButton2_Click;
            // 
            // большойToolStripMenuItem
            // 
            большойToolStripMenuItem.Name = "большойToolStripMenuItem";
            большойToolStripMenuItem.Size = new Size(137, 22);
            большойToolStripMenuItem.Text = "Большой";
            большойToolStripMenuItem.Click += toolStripDropDownButton2_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(110, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 61);
            panel1.TabIndex = 6;
            // 
            // label5
            // 
            label5.Location = new Point(295, 48);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 4;
            label5.Text = "Цвета";
            // 
            // label4
            // 
            label4.Location = new Point(156, 48);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Ластик";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.Location = new Point(22, 48);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Размер";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1184, 646);
            Controls.Add(pnlRibbon);
            Controls.Add(pctrBox);
            Controls.Add(mnuStrip);
            MainMenuStrip = mnuStrip;
            Name = "Form1";
            Text = "Form1";
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctrBox).EndInit();
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            pnlRibbon.ResumeLayout(false);
            toolStrip4.ResumeLayout(false);
            toolStrip4.PerformLayout();
            toolStrip5.ResumeLayout(false);
            toolStrip5.PerformLayout();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private PictureBox pctrBox;
        private MenuStrip mnuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private Panel pnlRibbon;
        private Label label5;
        private Label label4;
        private Label label2;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStrip toolStrip3;
        private ToolStripButton toolStripButton3;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem оченьМаленькийToolStripMenuItem;
        private ToolStripMenuItem маленькийToolStripMenuItem;
        private ToolStripMenuItem среднийToolStripMenuItem;
        private ToolStripMenuItem большойToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripMenuItem кругToolStripMenuItem;
        private ToolStripMenuItem овалToolStripMenuItem;
        private ToolStripMenuItem треугольникToolStripMenuItem;
        private ToolStripMenuItem прямоугольникToolStripMenuItem;
        private ToolStrip toolStrip5;
        private ToolStripButton toolStripButton1;
        private Label label1;
        private Label label3;
        private ToolStrip toolStrip4;
        private ToolStripButton toolStripButton2;
    }
}