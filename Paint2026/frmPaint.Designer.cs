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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox = new PictureBox();
            mnuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            pnlRibbon = new Panel();
            toolStrip4 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            черныйToolStripMenuItem = new ToolStripMenuItem();
            красныйToolStripMenuItem = new ToolStripMenuItem();
            зеленыйToolStripMenuItem = new ToolStripMenuItem();
            синийToolStripMenuItem = new ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            mnuStrip.SuspendLayout();
            pnlRibbon.SuspendLayout();
            toolStrip4.SuspendLayout();
            toolStrip3.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.ButtonHighlight;
            pictureBox.Location = new Point(0, 84);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1073, 528);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
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
            pnlRibbon.Paint += pnlRibbon_Paint_1;
            // 
            // toolStrip4
            // 
            toolStrip4.AutoSize = false;
            toolStrip4.Dock = DockStyle.None;
            toolStrip4.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip4.ImageScalingSize = new Size(48, 48);
            toolStrip4.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip4.Location = new Point(272, -2);
            toolStrip4.Name = "toolStrip4";
            toolStrip4.Size = new Size(79, 50);
            toolStrip4.TabIndex = 3;
            toolStrip4.Text = "toolStrip4";
            toolStrip4.ItemClicked += toolStrip4_ItemClicked_1;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.AutoSize = false;
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { черныйToolStripMenuItem, красныйToolStripMenuItem, зеленыйToolStripMenuItem, синийToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(60, 47);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // черныйToolStripMenuItem
            // 
            черныйToolStripMenuItem.Name = "черныйToolStripMenuItem";
            черныйToolStripMenuItem.Size = new Size(180, 22);
            черныйToolStripMenuItem.Text = "Черный";
            // 
            // красныйToolStripMenuItem
            // 
            красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            красныйToolStripMenuItem.Size = new Size(180, 22);
            красныйToolStripMenuItem.Text = "Красный";
            // 
            // зеленыйToolStripMenuItem
            // 
            зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            зеленыйToolStripMenuItem.Size = new Size(180, 22);
            зеленыйToolStripMenuItem.Text = "Зеленый";
            // 
            // синийToolStripMenuItem
            // 
            синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            синийToolStripMenuItem.Size = new Size(180, 22);
            синийToolStripMenuItem.Text = "Синий";
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
            toolStrip3.ItemClicked += toolStrip3_ItemClicked_1;
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
            toolStrip1.Size = new Size(56, 48);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
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
            toolStripDropDownButton2.Click += toolStripDropDownButton2_Click;
            // 
            // оченьМаленькийToolStripMenuItem
            // 
            оченьМаленькийToolStripMenuItem.Name = "оченьМаленькийToolStripMenuItem";
            оченьМаленькийToolStripMenuItem.Size = new Size(180, 22);
            оченьМаленькийToolStripMenuItem.Text = "Очень маленький";
            // 
            // маленькийToolStripMenuItem
            // 
            маленькийToolStripMenuItem.Name = "маленькийToolStripMenuItem";
            маленькийToolStripMenuItem.Size = new Size(180, 22);
            маленькийToolStripMenuItem.Text = "Маленький";
            // 
            // среднийToolStripMenuItem
            // 
            среднийToolStripMenuItem.Name = "среднийToolStripMenuItem";
            среднийToolStripMenuItem.Size = new Size(180, 22);
            среднийToolStripMenuItem.Text = "Средний";
            // 
            // большойToolStripMenuItem
            // 
            большойToolStripMenuItem.Name = "большойToolStripMenuItem";
            большойToolStripMenuItem.Size = new Size(180, 22);
            большойToolStripMenuItem.Text = "Большой";
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
            label5.Click += label5_Click;
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
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1184, 646);
            Controls.Add(pnlRibbon);
            Controls.Add(pictureBox);
            Controls.Add(mnuStrip);
            MainMenuStrip = mnuStrip;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            pnlRibbon.ResumeLayout(false);
            toolStrip4.ResumeLayout(false);
            toolStrip4.PerformLayout();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
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
        private ToolStrip toolStrip4;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem черныйToolStripMenuItem;
        private ToolStripMenuItem красныйToolStripMenuItem;
        private ToolStripMenuItem зеленыйToolStripMenuItem;
        private ToolStripMenuItem синийToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem оченьМаленькийToolStripMenuItem;
        private ToolStripMenuItem маленькийToolStripMenuItem;
        private ToolStripMenuItem среднийToolStripMenuItem;
        private ToolStripMenuItem большойToolStripMenuItem;
    }
}