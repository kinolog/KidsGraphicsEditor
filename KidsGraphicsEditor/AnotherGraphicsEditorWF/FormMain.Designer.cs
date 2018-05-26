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
            this.showTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsAndColorsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lineThicknessTrackBar = new System.Windows.Forms.TrackBar();
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
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.templatePanel = new System.Windows.Forms.Panel();
            this.buttonTemplateClose = new System.Windows.Forms.Button();
            this.buttonTemplateMinimize = new System.Windows.Forms.Button();
            this.buttonStepBack = new System.Windows.Forms.Button();
            this.buttonStepForward = new System.Windows.Forms.Button();
            this.templatePreviewBox = new System.Windows.Forms.PictureBox();
            this.labelTemplateName = new System.Windows.Forms.Label();
            this.openTemplateDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainImagePanel = new System.Windows.Forms.Panel();
            this.toolsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenuStrip.SuspendLayout();
            this.toolsAndColorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineThicknessTrackBar)).BeginInit();
            this.colorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.templatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templatePreviewBox)).BeginInit();
            this.mainImagePanel.SuspendLayout();
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
            this.templateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTemplateToolStripMenuItem});
            this.templateToolStripMenuItem.Name = "templateToolStripMenuItem";
            this.templateToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.templateToolStripMenuItem.Text = "Шаблоны";
            // 
            // showTemplateToolStripMenuItem
            // 
            this.showTemplateToolStripMenuItem.Name = "showTemplateToolStripMenuItem";
            this.showTemplateToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.showTemplateToolStripMenuItem.Text = "Показать шаблон";
            this.showTemplateToolStripMenuItem.Click += new System.EventHandler(this.showTemplateToolStripMenuItem_Click);
            // 
            // toolsAndColorsPanel
            // 
            this.toolsAndColorsPanel.Controls.Add(this.toolsPanel);
            this.toolsAndColorsPanel.Controls.Add(this.label1);
            this.toolsAndColorsPanel.Controls.Add(this.lineThicknessTrackBar);
            this.toolsAndColorsPanel.Controls.Add(this.colorsPanel);
            this.toolsAndColorsPanel.Location = new System.Drawing.Point(0, 24);
            this.toolsAndColorsPanel.Name = "toolsAndColorsPanel";
            this.toolsAndColorsPanel.Size = new System.Drawing.Size(186, 616);
            this.toolsAndColorsPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Толщина";
            // 
            // lineThicknessTrackBar
            // 
            this.lineThicknessTrackBar.Location = new System.Drawing.Point(18, 202);
            this.lineThicknessTrackBar.Name = "lineThicknessTrackBar";
            this.lineThicknessTrackBar.Size = new System.Drawing.Size(144, 45);
            this.lineThicknessTrackBar.TabIndex = 2;
            this.lineThicknessTrackBar.TickFrequency = 2;
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
            this.colorsPanel.Location = new System.Drawing.Point(22, 261);
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
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.mainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(1167, 616);
            this.mainPictureBox.TabIndex = 2;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseDown);
            this.mainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseMove);
            this.mainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseUp);
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Изображения|*.jpg; *.jpeg; *.png; *.bmp";
            this.openImageDialog.InitialDirectory = ".";
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.DefaultExt = "png";
            this.saveImageDialog.Filter = "Изображения|*.jpg; *.jpeg; *.png; *.bmp";
            // 
            // templatePanel
            // 
            this.templatePanel.BackColor = System.Drawing.Color.PeachPuff;
            this.templatePanel.Controls.Add(this.buttonTemplateClose);
            this.templatePanel.Controls.Add(this.buttonTemplateMinimize);
            this.templatePanel.Controls.Add(this.buttonStepBack);
            this.templatePanel.Controls.Add(this.buttonStepForward);
            this.templatePanel.Controls.Add(this.templatePreviewBox);
            this.templatePanel.Controls.Add(this.labelTemplateName);
            this.templatePanel.Location = new System.Drawing.Point(950, 3);
            this.templatePanel.Name = "templatePanel";
            this.templatePanel.Size = new System.Drawing.Size(217, 236);
            this.templatePanel.TabIndex = 3;
            // 
            // buttonTemplateClose
            // 
            this.buttonTemplateClose.FlatAppearance.BorderSize = 0;
            this.buttonTemplateClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemplateClose.Location = new System.Drawing.Point(178, 4);
            this.buttonTemplateClose.Name = "buttonTemplateClose";
            this.buttonTemplateClose.Size = new System.Drawing.Size(27, 23);
            this.buttonTemplateClose.TabIndex = 8;
            this.buttonTemplateClose.Text = "c";
            this.buttonTemplateClose.UseVisualStyleBackColor = true;
            this.buttonTemplateClose.Click += new System.EventHandler(this.buttonTemplateClose_Click);
            // 
            // buttonTemplateMinimize
            // 
            this.buttonTemplateMinimize.FlatAppearance.BorderSize = 0;
            this.buttonTemplateMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemplateMinimize.Location = new System.Drawing.Point(134, 4);
            this.buttonTemplateMinimize.Name = "buttonTemplateMinimize";
            this.buttonTemplateMinimize.Size = new System.Drawing.Size(26, 23);
            this.buttonTemplateMinimize.TabIndex = 7;
            this.buttonTemplateMinimize.Text = "m";
            this.buttonTemplateMinimize.UseVisualStyleBackColor = true;
            // 
            // buttonStepBack
            // 
            this.buttonStepBack.FlatAppearance.BorderSize = 0;
            this.buttonStepBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStepBack.Location = new System.Drawing.Point(18, 203);
            this.buttonStepBack.Name = "buttonStepBack";
            this.buttonStepBack.Size = new System.Drawing.Size(75, 23);
            this.buttonStepBack.TabIndex = 6;
            this.buttonStepBack.Text = "шаг назад";
            this.buttonStepBack.UseVisualStyleBackColor = true;
            this.buttonStepBack.Click += new System.EventHandler(this.buttonStepBack_Click);
            // 
            // buttonStepForward
            // 
            this.buttonStepForward.FlatAppearance.BorderSize = 0;
            this.buttonStepForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStepForward.Location = new System.Drawing.Point(134, 203);
            this.buttonStepForward.Name = "buttonStepForward";
            this.buttonStepForward.Size = new System.Drawing.Size(75, 23);
            this.buttonStepForward.TabIndex = 5;
            this.buttonStepForward.Text = "шаг вперёд";
            this.buttonStepForward.UseVisualStyleBackColor = true;
            this.buttonStepForward.Click += new System.EventHandler(this.buttonStepForward_Click);
            // 
            // templatePreviewBox
            // 
            this.templatePreviewBox.BackColor = System.Drawing.Color.White;
            this.templatePreviewBox.Location = new System.Drawing.Point(36, 29);
            this.templatePreviewBox.Name = "templatePreviewBox";
            this.templatePreviewBox.Size = new System.Drawing.Size(148, 167);
            this.templatePreviewBox.TabIndex = 1;
            this.templatePreviewBox.TabStop = false;
            // 
            // labelTemplateName
            // 
            this.labelTemplateName.AutoSize = true;
            this.labelTemplateName.Location = new System.Drawing.Point(4, 4);
            this.labelTemplateName.Name = "labelTemplateName";
            this.labelTemplateName.Size = new System.Drawing.Size(74, 13);
            this.labelTemplateName.TabIndex = 0;
            this.labelTemplateName.Text = "ИмяШаблона";
            // 
            // mainImagePanel
            // 
            this.mainImagePanel.AutoScroll = true;
            this.mainImagePanel.Controls.Add(this.templatePanel);
            this.mainImagePanel.Controls.Add(this.mainPictureBox);
            this.mainImagePanel.Location = new System.Drawing.Point(184, 24);
            this.mainImagePanel.Name = "mainImagePanel";
            this.mainImagePanel.Size = new System.Drawing.Size(1170, 616);
            this.mainImagePanel.TabIndex = 4;
            // 
            // toolsPanel
            // 
            this.toolsPanel.ColumnCount = 2;
            this.toolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.toolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.toolsPanel.Location = new System.Drawing.Point(22, 23);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.RowCount = 3;
            this.toolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.toolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.toolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.toolsPanel.Size = new System.Drawing.Size(137, 134);
            this.toolsPanel.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 642);
            this.Controls.Add(this.mainImagePanel);
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
            ((System.ComponentModel.ISupportInitialize)(this.lineThicknessTrackBar)).EndInit();
            this.colorsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.templatePanel.ResumeLayout(false);
            this.templatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templatePreviewBox)).EndInit();
            this.mainImagePanel.ResumeLayout(false);
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
        private System.Windows.Forms.TrackBar lineThicknessTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem showTemplateToolStripMenuItem;
        private System.Windows.Forms.Panel templatePanel;
        private System.Windows.Forms.Label labelTemplateName;
        private System.Windows.Forms.PictureBox templatePreviewBox;
        private System.Windows.Forms.Button buttonTemplateClose;
        private System.Windows.Forms.Button buttonTemplateMinimize;
        private System.Windows.Forms.Button buttonStepBack;
        private System.Windows.Forms.Button buttonStepForward;
        private System.Windows.Forms.OpenFileDialog openTemplateDialog;
        private System.Windows.Forms.Panel mainImagePanel;
        private System.Windows.Forms.TableLayoutPanel toolsPanel;
    }
}

