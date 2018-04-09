namespace AnotherGraphicsEditorWF
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsAndColorsPanel = new System.Windows.Forms.Panel();
            this.lineWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.colorsPanel = new System.Windows.Forms.Panel();
            this.labelBlack = new System.Windows.Forms.Label();
            this.labelWhite = new System.Windows.Forms.Label();
            this.labelPink = new System.Windows.Forms.Label();
            this.labelViolet = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelSkyBlue = new System.Windows.Forms.Label();
            this.labelDarkGreen = new System.Windows.Forms.Label();
            this.labelLightGreen = new System.Windows.Forms.Label();
            this.labelBrown = new System.Windows.Forms.Label();
            this.labelYellow = new System.Windows.Forms.Label();
            this.labelOrange = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.toolsAndColorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidthTrackBar)).BeginInit();
            this.colorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.templateToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1354, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.openFileToolStripMenuItem.Text = "Открыть файл";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveFileToolStripMenuItem.Text = "Сохранить файл";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // templateToolStripMenuItem
            // 
            this.templateToolStripMenuItem.Name = "templateToolStripMenuItem";
            this.templateToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.templateToolStripMenuItem.Text = "Шаблоны";
            // 
            // toolsAndColorsPanel
            // 
            this.toolsAndColorsPanel.Controls.Add(this.label1);
            this.toolsAndColorsPanel.Controls.Add(this.lineWidthTrackBar);
            this.toolsAndColorsPanel.Controls.Add(this.colorsPanel);
            this.toolsAndColorsPanel.Controls.Add(this.toolsPanel);
            this.toolsAndColorsPanel.Location = new System.Drawing.Point(0, 24);
            this.toolsAndColorsPanel.Name = "toolsAndColorsPanel";
            this.toolsAndColorsPanel.Size = new System.Drawing.Size(186, 616);
            this.toolsAndColorsPanel.TabIndex = 1;
            // 
            // lineWidthTrackBar
            // 
            this.lineWidthTrackBar.Location = new System.Drawing.Point(22, 138);
            this.lineWidthTrackBar.Name = "lineWidthTrackBar";
            this.lineWidthTrackBar.Size = new System.Drawing.Size(104, 45);
            this.lineWidthTrackBar.TabIndex = 2;
            // 
            // colorsPanel
            // 
            this.colorsPanel.Controls.Add(this.labelBlack);
            this.colorsPanel.Controls.Add(this.labelWhite);
            this.colorsPanel.Controls.Add(this.labelPink);
            this.colorsPanel.Controls.Add(this.labelViolet);
            this.colorsPanel.Controls.Add(this.labelBlue);
            this.colorsPanel.Controls.Add(this.labelSkyBlue);
            this.colorsPanel.Controls.Add(this.labelDarkGreen);
            this.colorsPanel.Controls.Add(this.labelLightGreen);
            this.colorsPanel.Controls.Add(this.labelBrown);
            this.colorsPanel.Controls.Add(this.labelYellow);
            this.colorsPanel.Controls.Add(this.labelOrange);
            this.colorsPanel.Controls.Add(this.labelRed);
            this.colorsPanel.Location = new System.Drawing.Point(26, 189);
            this.colorsPanel.Name = "colorsPanel";
            this.colorsPanel.Size = new System.Drawing.Size(140, 302);
            this.colorsPanel.TabIndex = 1;
            // 
            // labelBlack
            // 
            this.labelBlack.BackColor = System.Drawing.Color.Black;
            this.labelBlack.Location = new System.Drawing.Point(67, 250);
            this.labelBlack.Name = "labelBlack";
            this.labelBlack.Size = new System.Drawing.Size(70, 50);
            this.labelBlack.TabIndex = 11;
            this.labelBlack.Click += new System.EventHandler(this.labelBlack_Click);
            // 
            // labelWhite
            // 
            this.labelWhite.Location = new System.Drawing.Point(-3, 250);
            this.labelWhite.Name = "labelWhite";
            this.labelWhite.Size = new System.Drawing.Size(70, 50);
            this.labelWhite.TabIndex = 10;
            this.labelWhite.Click += new System.EventHandler(this.labelWhite_Click);
            // 
            // labelPink
            // 
            this.labelPink.BackColor = System.Drawing.Color.Magenta;
            this.labelPink.Location = new System.Drawing.Point(67, 200);
            this.labelPink.Name = "labelPink";
            this.labelPink.Size = new System.Drawing.Size(70, 50);
            this.labelPink.TabIndex = 9;
            this.labelPink.Click += new System.EventHandler(this.labelPink_Click);
            // 
            // labelViolet
            // 
            this.labelViolet.BackColor = System.Drawing.Color.BlueViolet;
            this.labelViolet.Location = new System.Drawing.Point(-3, 200);
            this.labelViolet.Name = "labelViolet";
            this.labelViolet.Size = new System.Drawing.Size(70, 50);
            this.labelViolet.TabIndex = 8;
            this.labelViolet.Click += new System.EventHandler(this.labelViolet_Click);
            // 
            // labelBlue
            // 
            this.labelBlue.BackColor = System.Drawing.Color.Blue;
            this.labelBlue.Location = new System.Drawing.Point(67, 150);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(70, 50);
            this.labelBlue.TabIndex = 7;
            this.labelBlue.Click += new System.EventHandler(this.labelBlue_Click);
            // 
            // labelSkyBlue
            // 
            this.labelSkyBlue.BackColor = System.Drawing.Color.Cyan;
            this.labelSkyBlue.Location = new System.Drawing.Point(-3, 150);
            this.labelSkyBlue.Name = "labelSkyBlue";
            this.labelSkyBlue.Size = new System.Drawing.Size(70, 50);
            this.labelSkyBlue.TabIndex = 6;
            this.labelSkyBlue.Click += new System.EventHandler(this.labelSkyBlue_Click);
            // 
            // labelDarkGreen
            // 
            this.labelDarkGreen.BackColor = System.Drawing.Color.Green;
            this.labelDarkGreen.Location = new System.Drawing.Point(67, 100);
            this.labelDarkGreen.Name = "labelDarkGreen";
            this.labelDarkGreen.Size = new System.Drawing.Size(70, 50);
            this.labelDarkGreen.TabIndex = 5;
            this.labelDarkGreen.Click += new System.EventHandler(this.labelDarkGreen_Click);
            // 
            // labelLightGreen
            // 
            this.labelLightGreen.BackColor = System.Drawing.Color.Lime;
            this.labelLightGreen.Location = new System.Drawing.Point(-3, 100);
            this.labelLightGreen.Name = "labelLightGreen";
            this.labelLightGreen.Size = new System.Drawing.Size(70, 50);
            this.labelLightGreen.TabIndex = 4;
            this.labelLightGreen.Click += new System.EventHandler(this.labelLightGreen_Click);
            // 
            // labelBrown
            // 
            this.labelBrown.BackColor = System.Drawing.Color.Brown;
            this.labelBrown.Location = new System.Drawing.Point(67, 50);
            this.labelBrown.Name = "labelBrown";
            this.labelBrown.Size = new System.Drawing.Size(70, 50);
            this.labelBrown.TabIndex = 3;
            this.labelBrown.Click += new System.EventHandler(this.labelBrown_Click);
            // 
            // labelYellow
            // 
            this.labelYellow.BackColor = System.Drawing.Color.Yellow;
            this.labelYellow.Location = new System.Drawing.Point(0, 50);
            this.labelYellow.Name = "labelYellow";
            this.labelYellow.Size = new System.Drawing.Size(70, 50);
            this.labelYellow.TabIndex = 2;
            this.labelYellow.Click += new System.EventHandler(this.labelYellow_Click);
            // 
            // labelOrange
            // 
            this.labelOrange.BackColor = System.Drawing.Color.Orange;
            this.labelOrange.Location = new System.Drawing.Point(67, 0);
            this.labelOrange.Name = "labelOrange";
            this.labelOrange.Size = new System.Drawing.Size(70, 50);
            this.labelOrange.TabIndex = 1;
            this.labelOrange.Click += new System.EventHandler(this.labelOrange_Click);
            // 
            // labelRed
            // 
            this.labelRed.BackColor = System.Drawing.Color.Red;
            this.labelRed.Location = new System.Drawing.Point(0, 0);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(70, 50);
            this.labelRed.TabIndex = 0;
            this.labelRed.Click += new System.EventHandler(this.labelRed_Click);
            // 
            // toolsPanel
            // 
            this.toolsPanel.Location = new System.Drawing.Point(26, 32);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(100, 52);
            this.toolsPanel.TabIndex = 0;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(187, 24);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(1167, 616);
            this.mainPictureBox.TabIndex = 2;
            this.mainPictureBox.TabStop = false;
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            this.openImageDialog.Filter = "Изображения|*.jpg; *.jpeg; *.png; *.bmp";
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.Filter = "Изображения|*.jpg; *.jpeg; *.png; *.bmp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Толщина";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 642);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.toolsAndColorsPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "FormMain";
            this.Text = "Рисовалочка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolsAndColorsPanel.ResumeLayout(false);
            this.toolsAndColorsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidthTrackBar)).EndInit();
            this.colorsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem templateToolStripMenuItem;
        private System.Windows.Forms.Panel toolsAndColorsPanel;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.Panel colorsPanel;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelDarkGreen;
        private System.Windows.Forms.Label labelLightGreen;
        private System.Windows.Forms.Label labelBrown;
        private System.Windows.Forms.Label labelYellow;
        private System.Windows.Forms.Label labelOrange;
        private System.Windows.Forms.Label labelBlack;
        private System.Windows.Forms.Label labelWhite;
        private System.Windows.Forms.Label labelPink;
        private System.Windows.Forms.Label labelViolet;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelSkyBlue;
        private System.Windows.Forms.TrackBar lineWidthTrackBar;
        private System.Windows.Forms.Label label1;
    }
}

