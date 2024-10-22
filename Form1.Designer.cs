namespace WinFormsPaint
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            defaultToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            colorsToolStripMenuItem = new ToolStripMenuItem();
            invertToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            Canvas = new PictureBox();
            StatusBar = new Label();
            newDialog = new PageSetupDialog();
            SelectButton = new Button();
            penButton = new Button();
            panel1 = new Panel();
            LineButton = new Button();
            panel2 = new Panel();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, imageToolStripMenuItem, colorsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(990, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, newToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(180, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save as...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, defaultToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.Size = new Size(127, 22);
            zoomInToolStripMenuItem.Text = "Zoom in";
            zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.Size = new Size(127, 22);
            zoomOutToolStripMenuItem.Text = "Zoom out";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(127, 22);
            defaultToolStripMenuItem.Text = "Default";
            defaultToolStripMenuItem.Click += defaultToolStripMenuItem_Click;
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(52, 20);
            imageToolStripMenuItem.Text = "Image";
            // 
            // colorsToolStripMenuItem
            // 
            colorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { invertToolStripMenuItem });
            colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            colorsToolStripMenuItem.Size = new Size(53, 20);
            colorsToolStripMenuItem.Text = "Colors";
            // 
            // invertToolStripMenuItem
            // 
            invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            invertToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            invertToolStripMenuItem.Size = new Size(141, 22);
            invertToolStripMenuItem.Text = "Invert";
            invertToolStripMenuItem.Click += invertToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // Canvas
            // 
            Canvas.Location = new Point(190, 115);
            Canvas.Margin = new Padding(5);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(800, 485);
            Canvas.TabIndex = 1;
            Canvas.TabStop = false;
            Canvas.MouseDown += pictureBox1_MouseDown;
            Canvas.MouseMove += pictureBox1_MouseMove;
            Canvas.MouseUp += Canvas_MouseUp;
            // 
            // StatusBar
            // 
            StatusBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StatusBar.AutoSize = true;
            StatusBar.Location = new Point(190, 529);
            StatusBar.Name = "StatusBar";
            StatusBar.Size = new Size(38, 15);
            StatusBar.TabIndex = 2;
            StatusBar.Text = "label1";
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(42, 52);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(75, 23);
            SelectButton.TabIndex = 4;
            SelectButton.Text = "Select";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Click += SelectButton_Click;
            // 
            // penButton
            // 
            penButton.Location = new Point(42, 23);
            penButton.Name = "penButton";
            penButton.Size = new Size(75, 23);
            penButton.TabIndex = 5;
            penButton.Text = "Pen";
            penButton.UseVisualStyleBackColor = true;
            penButton.Click += penButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(LineButton);
            panel1.Controls.Add(penButton);
            panel1.Controls.Add(SelectButton);
            panel1.Location = new Point(14, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 417);
            panel1.TabIndex = 6;
            // 
            // LineButton
            // 
            LineButton.Location = new Point(42, 81);
            LineButton.Name = "LineButton";
            LineButton.Size = new Size(75, 23);
            LineButton.TabIndex = 6;
            LineButton.Text = "Line";
            LineButton.UseVisualStyleBackColor = true;
            LineButton.Click += button12_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(14, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(3601, 80);
            panel2.TabIndex = 7;
            panel2.Click += panel2_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 128, 255);
            button11.Location = new Point(244, 45);
            button11.Name = "button11";
            button11.Size = new Size(29, 28);
            button11.TabIndex = 10;
            button11.UseVisualStyleBackColor = false;
            button11.Click += panel2_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Fuchsia;
            button10.Location = new Point(244, 12);
            button10.Name = "button10";
            button10.Size = new Size(29, 28);
            button10.TabIndex = 9;
            button10.UseVisualStyleBackColor = false;
            button10.Click += panel2_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(128, 128, 255);
            button9.Location = new Point(209, 45);
            button9.Name = "button9";
            button9.Size = new Size(29, 28);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.Click += panel2_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Blue;
            button8.Location = new Point(209, 12);
            button8.Name = "button8";
            button8.Size = new Size(29, 28);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += panel2_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(128, 255, 255);
            button7.Location = new Point(174, 45);
            button7.Name = "button7";
            button7.Size = new Size(29, 28);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += panel2_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Cyan;
            button6.Location = new Point(174, 12);
            button6.Name = "button6";
            button6.Size = new Size(29, 28);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += panel2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 255, 128);
            button5.Location = new Point(139, 45);
            button5.Name = "button5";
            button5.Size = new Size(29, 28);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += panel2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Location = new Point(139, 12);
            button4.Name = "button4";
            button4.Size = new Size(29, 28);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += panel2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(104, 45);
            button3.Name = "button3";
            button3.Size = new Size(29, 28);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += panel2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(104, 12);
            button2.Name = "button2";
            button2.Size = new Size(29, 28);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += panel2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(32, 12);
            button1.Name = "button1";
            button1.Size = new Size(66, 61);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(800, 600);
            ClientSize = new Size(784, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(StatusBar);
            Controls.Add(Canvas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem colorsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private PictureBox Canvas;
        private ToolStripMenuItem newToolStripMenuItem;
        private Label StatusBar;
        private PageSetupDialog newDialog;
        private Button SelectButton;
        private Button penButton;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button LineButton;
        private ToolStripMenuItem invertToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem defaultToolStripMenuItem;
    }
}
