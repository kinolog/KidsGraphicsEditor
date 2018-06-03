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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsAndColorsPanel = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.toolsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelEraser = new System.Windows.Forms.Label();
            this.labelFill = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.labelEllipse = new System.Windows.Forms.Label();
            this.labelRect = new System.Windows.Forms.Label();
            this.labelPencil = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
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
            this.buttonShowHideTemp = new System.Windows.Forms.Button();
            this.buttonTemplateClose = new System.Windows.Forms.Button();
            this.buttonTemplateMinimize = new System.Windows.Forms.Button();
            this.buttonStepBack = new System.Windows.Forms.Button();
            this.buttonStepForward = new System.Windows.Forms.Button();
            this.templatePreviewBox = new System.Windows.Forms.PictureBox();
            this.labelTemplateName = new System.Windows.Forms.Label();
            this.openTemplateDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainImagePanel = new System.Windows.Forms.Panel();
            this.templatePanelMinimized = new System.Windows.Forms.Panel();
            this.buttonTempCloseMinimized = new System.Windows.Forms.Button();
            this.buttonTemplateMaximize = new System.Windows.Forms.Button();
            this.buttonShowHideMinimized = new System.Windows.Forms.Button();
            this.labelTemplateNameMinimized = new System.Windows.Forms.Label();
            this.toolTipHelper = new System.Windows.Forms.ToolTip(this.components);
            this.mainMenuStrip.SuspendLayout();
            this.toolsAndColorsPanel.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineThicknessTrackBar)).BeginInit();
            this.colorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.templatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templatePreviewBox)).BeginInit();
            this.mainImagePanel.SuspendLayout();
            this.templatePanelMinimized.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.templateToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1297, 24);
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
            this.showTemplateToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.showTemplateToolStripMenuItem.Text = "Загрузить шаблон";
            this.showTemplateToolStripMenuItem.Click += new System.EventHandler(this.showTemplateToolStripMenuItem_Click);
            // 
            // toolsAndColorsPanel
            // 
            this.toolsAndColorsPanel.Controls.Add(this.buttonClear);
            this.toolsAndColorsPanel.Controls.Add(this.toolsPanel);
            this.toolsAndColorsPanel.Controls.Add(this.labelWidth);
            this.toolsAndColorsPanel.Controls.Add(this.lineThicknessTrackBar);
            this.toolsAndColorsPanel.Controls.Add(this.colorsPanel);
            this.toolsAndColorsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolsAndColorsPanel.Location = new System.Drawing.Point(0, 24);
            this.toolsAndColorsPanel.Name = "toolsAndColorsPanel";
            this.toolsAndColorsPanel.Size = new System.Drawing.Size(188, 646);
            this.toolsAndColorsPanel.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClear.Location = new System.Drawing.Point(28, 602);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(128, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Очистить рисунок";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // toolsPanel
            // 
            this.toolsPanel.ColumnCount = 2;
            this.toolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.toolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.toolsPanel.Controls.Add(this.labelEraser, 1, 0);
            this.toolsPanel.Controls.Add(this.labelFill, 0, 1);
            this.toolsPanel.Controls.Add(this.labelLine, 1, 1);
            this.toolsPanel.Controls.Add(this.labelEllipse, 1, 2);
            this.toolsPanel.Controls.Add(this.labelRect, 0, 2);
            this.toolsPanel.Controls.Add(this.labelPencil, 0, 0);
            this.toolsPanel.Location = new System.Drawing.Point(22, 21);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.RowCount = 3;
            this.toolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.toolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.toolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.toolsPanel.Size = new System.Drawing.Size(137, 178);
            this.toolsPanel.TabIndex = 4;
            // 
            // labelEraser
            // 
            this.labelEraser.AutoSize = true;
            this.labelEraser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEraser.Image = ((System.Drawing.Image)(resources.GetObject("labelEraser.Image")));
            this.labelEraser.Location = new System.Drawing.Point(71, 0);
            this.labelEraser.Name = "labelEraser";
            this.labelEraser.Size = new System.Drawing.Size(63, 59);
            this.labelEraser.TabIndex = 1;
            this.toolTipHelper.SetToolTip(this.labelEraser, "Ластик");
            this.labelEraser.Click += new System.EventHandler(this.labelEraser_Click);
            // 
            // labelFill
            // 
            this.labelFill.AutoSize = true;
            this.labelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFill.Image = ((System.Drawing.Image)(resources.GetObject("labelFill.Image")));
            this.labelFill.Location = new System.Drawing.Point(3, 59);
            this.labelFill.Name = "labelFill";
            this.labelFill.Size = new System.Drawing.Size(62, 59);
            this.labelFill.TabIndex = 5;
            this.toolTipHelper.SetToolTip(this.labelFill, "Заливка");
            this.labelFill.Click += new System.EventHandler(this.labelFill_Click);
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLine.Image = ((System.Drawing.Image)(resources.GetObject("labelLine.Image")));
            this.labelLine.Location = new System.Drawing.Point(71, 59);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(63, 59);
            this.labelLine.TabIndex = 2;
            this.toolTipHelper.SetToolTip(this.labelLine, "Линия");
            this.labelLine.Click += new System.EventHandler(this.labelLine_Click);
            // 
            // labelEllipse
            // 
            this.labelEllipse.AutoSize = true;
            this.labelEllipse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEllipse.Image = ((System.Drawing.Image)(resources.GetObject("labelEllipse.Image")));
            this.labelEllipse.Location = new System.Drawing.Point(71, 118);
            this.labelEllipse.Name = "labelEllipse";
            this.labelEllipse.Size = new System.Drawing.Size(63, 60);
            this.labelEllipse.TabIndex = 4;
            this.toolTipHelper.SetToolTip(this.labelEllipse, "Кружок/Овал");
            this.labelEllipse.Click += new System.EventHandler(this.labelEllipse_Click);
            // 
            // labelRect
            // 
            this.labelRect.AutoSize = true;
            this.labelRect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRect.Image = ((System.Drawing.Image)(resources.GetObject("labelRect.Image")));
            this.labelRect.Location = new System.Drawing.Point(3, 118);
            this.labelRect.Name = "labelRect";
            this.labelRect.Size = new System.Drawing.Size(62, 60);
            this.labelRect.TabIndex = 3;
            this.toolTipHelper.SetToolTip(this.labelRect, "Прямоугольник");
            this.labelRect.Click += new System.EventHandler(this.labelRect_Click);
            // 
            // labelPencil
            // 
            this.labelPencil.AutoSize = true;
            this.labelPencil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPencil.Image = ((System.Drawing.Image)(resources.GetObject("labelPencil.Image")));
            this.labelPencil.Location = new System.Drawing.Point(3, 0);
            this.labelPencil.Name = "labelPencil";
            this.labelPencil.Size = new System.Drawing.Size(62, 59);
            this.labelPencil.TabIndex = 0;
            this.toolTipHelper.SetToolTip(this.labelPencil, "Карандаш");
            this.labelPencil.Click += new System.EventHandler(this.labelPencil_Click);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(63, 211);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(53, 13);
            this.labelWidth.TabIndex = 3;
            this.labelWidth.Text = "Толщина";
            // 
            // lineThicknessTrackBar
            // 
            this.lineThicknessTrackBar.Location = new System.Drawing.Point(19, 227);
            this.lineThicknessTrackBar.Maximum = 15;
            this.lineThicknessTrackBar.Minimum = 3;
            this.lineThicknessTrackBar.Name = "lineThicknessTrackBar";
            this.lineThicknessTrackBar.Size = new System.Drawing.Size(144, 45);
            this.lineThicknessTrackBar.TabIndex = 2;
            this.lineThicknessTrackBar.TickFrequency = 3;
            this.lineThicknessTrackBar.Value = 3;
            this.lineThicknessTrackBar.ValueChanged += new System.EventHandler(this.lineThicknessTrackBar_ValueChanged);
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
            this.colorsPanel.Location = new System.Drawing.Point(22, 284);
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
            this.toolTipHelper.SetToolTip(this.labelBlack, "Чёрный");
            this.labelBlack.Click += new System.EventHandler(this.labelBlack_Click);
            // 
            // labelWhite
            // 
            this.labelWhite.Location = new System.Drawing.Point(-3, 250);
            this.labelWhite.Name = "labelWhite";
            this.labelWhite.Size = new System.Drawing.Size(70, 50);
            this.labelWhite.TabIndex = 10;
            this.toolTipHelper.SetToolTip(this.labelWhite, "Белый");
            this.labelWhite.Click += new System.EventHandler(this.labelWhite_Click);
            // 
            // labelPink
            // 
            this.labelPink.BackColor = System.Drawing.Color.Magenta;
            this.labelPink.Location = new System.Drawing.Point(67, 200);
            this.labelPink.Name = "labelPink";
            this.labelPink.Size = new System.Drawing.Size(70, 50);
            this.labelPink.TabIndex = 9;
            this.toolTipHelper.SetToolTip(this.labelPink, "Розовый");
            this.labelPink.Click += new System.EventHandler(this.labelPink_Click);
            // 
            // labelViolet
            // 
            this.labelViolet.BackColor = System.Drawing.Color.BlueViolet;
            this.labelViolet.Location = new System.Drawing.Point(-3, 200);
            this.labelViolet.Name = "labelViolet";
            this.labelViolet.Size = new System.Drawing.Size(70, 50);
            this.labelViolet.TabIndex = 8;
            this.toolTipHelper.SetToolTip(this.labelViolet, "Фиолетовый");
            this.labelViolet.Click += new System.EventHandler(this.labelViolet_Click);
            // 
            // labelBlue
            // 
            this.labelBlue.BackColor = System.Drawing.Color.Blue;
            this.labelBlue.Location = new System.Drawing.Point(67, 150);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(70, 50);
            this.labelBlue.TabIndex = 7;
            this.toolTipHelper.SetToolTip(this.labelBlue, "Синий");
            this.labelBlue.Click += new System.EventHandler(this.labelBlue_Click);
            // 
            // labelSkyBlue
            // 
            this.labelSkyBlue.BackColor = System.Drawing.Color.Cyan;
            this.labelSkyBlue.Location = new System.Drawing.Point(-3, 150);
            this.labelSkyBlue.Name = "labelSkyBlue";
            this.labelSkyBlue.Size = new System.Drawing.Size(70, 50);
            this.labelSkyBlue.TabIndex = 6;
            this.toolTipHelper.SetToolTip(this.labelSkyBlue, "Бирюзовый");
            this.labelSkyBlue.Click += new System.EventHandler(this.labelSkyBlue_Click);
            // 
            // labelDarkGreen
            // 
            this.labelDarkGreen.BackColor = System.Drawing.Color.Green;
            this.labelDarkGreen.Location = new System.Drawing.Point(67, 100);
            this.labelDarkGreen.Name = "labelDarkGreen";
            this.labelDarkGreen.Size = new System.Drawing.Size(70, 50);
            this.labelDarkGreen.TabIndex = 5;
            this.toolTipHelper.SetToolTip(this.labelDarkGreen, "Тёмно-зелёный");
            this.labelDarkGreen.Click += new System.EventHandler(this.labelDarkGreen_Click);
            // 
            // labelLightGreen
            // 
            this.labelLightGreen.BackColor = System.Drawing.Color.Lime;
            this.labelLightGreen.Location = new System.Drawing.Point(-3, 100);
            this.labelLightGreen.Name = "labelLightGreen";
            this.labelLightGreen.Size = new System.Drawing.Size(70, 50);
            this.labelLightGreen.TabIndex = 4;
            this.toolTipHelper.SetToolTip(this.labelLightGreen, "Светло-зелёный");
            this.labelLightGreen.Click += new System.EventHandler(this.labelLightGreen_Click);
            // 
            // labelBrown
            // 
            this.labelBrown.BackColor = System.Drawing.Color.Brown;
            this.labelBrown.Location = new System.Drawing.Point(67, 50);
            this.labelBrown.Name = "labelBrown";
            this.labelBrown.Size = new System.Drawing.Size(70, 50);
            this.labelBrown.TabIndex = 3;
            this.toolTipHelper.SetToolTip(this.labelBrown, "Коричневый");
            this.labelBrown.Click += new System.EventHandler(this.labelBrown_Click);
            // 
            // labelYellow
            // 
            this.labelYellow.BackColor = System.Drawing.Color.Yellow;
            this.labelYellow.Location = new System.Drawing.Point(0, 50);
            this.labelYellow.Name = "labelYellow";
            this.labelYellow.Size = new System.Drawing.Size(70, 50);
            this.labelYellow.TabIndex = 2;
            this.toolTipHelper.SetToolTip(this.labelYellow, "Жёлтый");
            this.labelYellow.Click += new System.EventHandler(this.labelYellow_Click);
            // 
            // labelOrange
            // 
            this.labelOrange.BackColor = System.Drawing.Color.Orange;
            this.labelOrange.Location = new System.Drawing.Point(67, 0);
            this.labelOrange.Name = "labelOrange";
            this.labelOrange.Size = new System.Drawing.Size(70, 50);
            this.labelOrange.TabIndex = 1;
            this.toolTipHelper.SetToolTip(this.labelOrange, "Оранжевый");
            this.labelOrange.Click += new System.EventHandler(this.labelOrange_Click);
            // 
            // labelRed
            // 
            this.labelRed.BackColor = System.Drawing.Color.Red;
            this.labelRed.Location = new System.Drawing.Point(0, 0);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(70, 50);
            this.labelRed.TabIndex = 0;
            this.toolTipHelper.SetToolTip(this.labelRed, "Красный");
            this.labelRed.Click += new System.EventHandler(this.labelRed_Click);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.mainPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(1100, 600);
            this.mainPictureBox.TabIndex = 2;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPictureBox_Paint);
            this.mainPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseClick);
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
            this.saveImageDialog.FilterIndex = 2;
            // 
            // templatePanel
            // 
            this.templatePanel.BackColor = System.Drawing.Color.PeachPuff;
            this.templatePanel.Controls.Add(this.buttonShowHideTemp);
            this.templatePanel.Controls.Add(this.buttonTemplateClose);
            this.templatePanel.Controls.Add(this.buttonTemplateMinimize);
            this.templatePanel.Controls.Add(this.buttonStepBack);
            this.templatePanel.Controls.Add(this.buttonStepForward);
            this.templatePanel.Controls.Add(this.templatePreviewBox);
            this.templatePanel.Controls.Add(this.labelTemplateName);
            this.templatePanel.Location = new System.Drawing.Point(818, 3);
            this.templatePanel.Name = "templatePanel";
            this.templatePanel.Size = new System.Drawing.Size(280, 347);
            this.templatePanel.TabIndex = 3;
            // 
            // buttonShowHideTemp
            // 
            this.buttonShowHideTemp.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonShowHideTemp.FlatAppearance.BorderSize = 0;
            this.buttonShowHideTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowHideTemp.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowHideTemp.Image")));
            this.buttonShowHideTemp.Location = new System.Drawing.Point(130, 5);
            this.buttonShowHideTemp.Name = "buttonShowHideTemp";
            this.buttonShowHideTemp.Size = new System.Drawing.Size(30, 25);
            this.buttonShowHideTemp.TabIndex = 9;
            this.toolTipHelper.SetToolTip(this.buttonShowHideTemp, "Показать/Скрыть шаблон");
            this.buttonShowHideTemp.UseVisualStyleBackColor = false;
            this.buttonShowHideTemp.Click += new System.EventHandler(this.buttonShowHideTemp_Click);
            // 
            // buttonTemplateClose
            // 
            this.buttonTemplateClose.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonTemplateClose.FlatAppearance.BorderSize = 0;
            this.buttonTemplateClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemplateClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemplateClose.Image")));
            this.buttonTemplateClose.Location = new System.Drawing.Point(237, 4);
            this.buttonTemplateClose.Name = "buttonTemplateClose";
            this.buttonTemplateClose.Size = new System.Drawing.Size(30, 25);
            this.buttonTemplateClose.TabIndex = 8;
            this.toolTipHelper.SetToolTip(this.buttonTemplateClose, "Закрыть");
            this.buttonTemplateClose.UseVisualStyleBackColor = false;
            this.buttonTemplateClose.Click += new System.EventHandler(this.buttonTemplateClose_Click);
            // 
            // buttonTemplateMinimize
            // 
            this.buttonTemplateMinimize.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonTemplateMinimize.FlatAppearance.BorderSize = 0;
            this.buttonTemplateMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemplateMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemplateMinimize.Image")));
            this.buttonTemplateMinimize.Location = new System.Drawing.Point(195, 4);
            this.buttonTemplateMinimize.Name = "buttonTemplateMinimize";
            this.buttonTemplateMinimize.Size = new System.Drawing.Size(30, 25);
            this.buttonTemplateMinimize.TabIndex = 7;
            this.toolTipHelper.SetToolTip(this.buttonTemplateMinimize, "Свернуть");
            this.buttonTemplateMinimize.UseVisualStyleBackColor = false;
            this.buttonTemplateMinimize.Click += new System.EventHandler(this.buttonTemplateMinimize_Click);
            // 
            // buttonStepBack
            // 
            this.buttonStepBack.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonStepBack.FlatAppearance.BorderSize = 0;
            this.buttonStepBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStepBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonStepBack.Image")));
            this.buttonStepBack.Location = new System.Drawing.Point(40, 305);
            this.buttonStepBack.Name = "buttonStepBack";
            this.buttonStepBack.Size = new System.Drawing.Size(75, 23);
            this.buttonStepBack.TabIndex = 6;
            this.buttonStepBack.UseVisualStyleBackColor = false;
            this.buttonStepBack.Click += new System.EventHandler(this.buttonStepBack_Click);
            // 
            // buttonStepForward
            // 
            this.buttonStepForward.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonStepForward.FlatAppearance.BorderSize = 0;
            this.buttonStepForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStepForward.Image = ((System.Drawing.Image)(resources.GetObject("buttonStepForward.Image")));
            this.buttonStepForward.Location = new System.Drawing.Point(165, 305);
            this.buttonStepForward.Name = "buttonStepForward";
            this.buttonStepForward.Size = new System.Drawing.Size(75, 23);
            this.buttonStepForward.TabIndex = 5;
            this.buttonStepForward.UseVisualStyleBackColor = false;
            this.buttonStepForward.Click += new System.EventHandler(this.buttonStepForward_Click);
            // 
            // templatePreviewBox
            // 
            this.templatePreviewBox.BackColor = System.Drawing.Color.White;
            this.templatePreviewBox.Location = new System.Drawing.Point(40, 36);
            this.templatePreviewBox.Name = "templatePreviewBox";
            this.templatePreviewBox.Size = new System.Drawing.Size(200, 250);
            this.templatePreviewBox.TabIndex = 1;
            this.templatePreviewBox.TabStop = false;
            // 
            // labelTemplateName
            // 
            this.labelTemplateName.AutoSize = true;
            this.labelTemplateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemplateName.Location = new System.Drawing.Point(3, 10);
            this.labelTemplateName.Name = "labelTemplateName";
            this.labelTemplateName.Size = new System.Drawing.Size(108, 20);
            this.labelTemplateName.TabIndex = 0;
            this.labelTemplateName.Text = "ИмяШаблона";
            // 
            // mainImagePanel
            // 
            this.mainImagePanel.AutoScroll = true;
            this.mainImagePanel.BackColor = System.Drawing.Color.Transparent;
            this.mainImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainImagePanel.Controls.Add(this.templatePanelMinimized);
            this.mainImagePanel.Controls.Add(this.templatePanel);
            this.mainImagePanel.Controls.Add(this.mainPictureBox);
            this.mainImagePanel.Location = new System.Drawing.Point(187, 24);
            this.mainImagePanel.Name = "mainImagePanel";
            this.mainImagePanel.Size = new System.Drawing.Size(1100, 600);
            this.mainImagePanel.TabIndex = 4;
            // 
            // templatePanelMinimized
            // 
            this.templatePanelMinimized.BackColor = System.Drawing.Color.PeachPuff;
            this.templatePanelMinimized.Controls.Add(this.buttonTempCloseMinimized);
            this.templatePanelMinimized.Controls.Add(this.buttonTemplateMaximize);
            this.templatePanelMinimized.Controls.Add(this.buttonShowHideMinimized);
            this.templatePanelMinimized.Controls.Add(this.labelTemplateNameMinimized);
            this.templatePanelMinimized.Location = new System.Drawing.Point(818, 3);
            this.templatePanelMinimized.Name = "templatePanelMinimized";
            this.templatePanelMinimized.Size = new System.Drawing.Size(280, 35);
            this.templatePanelMinimized.TabIndex = 10;
            // 
            // buttonTempCloseMinimized
            // 
            this.buttonTempCloseMinimized.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonTempCloseMinimized.FlatAppearance.BorderSize = 0;
            this.buttonTempCloseMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTempCloseMinimized.Image = ((System.Drawing.Image)(resources.GetObject("buttonTempCloseMinimized.Image")));
            this.buttonTempCloseMinimized.Location = new System.Drawing.Point(237, 4);
            this.buttonTempCloseMinimized.Name = "buttonTempCloseMinimized";
            this.buttonTempCloseMinimized.Size = new System.Drawing.Size(30, 25);
            this.buttonTempCloseMinimized.TabIndex = 12;
            this.toolTipHelper.SetToolTip(this.buttonTempCloseMinimized, "Закрыть");
            this.buttonTempCloseMinimized.UseVisualStyleBackColor = false;
            this.buttonTempCloseMinimized.Click += new System.EventHandler(this.buttonTempCloseMinimized_Click);
            // 
            // buttonTemplateMaximize
            // 
            this.buttonTemplateMaximize.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonTemplateMaximize.FlatAppearance.BorderSize = 0;
            this.buttonTemplateMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemplateMaximize.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemplateMaximize.Image")));
            this.buttonTemplateMaximize.Location = new System.Drawing.Point(195, 4);
            this.buttonTemplateMaximize.Name = "buttonTemplateMaximize";
            this.buttonTemplateMaximize.Size = new System.Drawing.Size(30, 25);
            this.buttonTemplateMaximize.TabIndex = 11;
            this.toolTipHelper.SetToolTip(this.buttonTemplateMaximize, "Развернуть");
            this.buttonTemplateMaximize.UseVisualStyleBackColor = false;
            this.buttonTemplateMaximize.Click += new System.EventHandler(this.buttonTemplateMaximize_Click);
            // 
            // buttonShowHideMinimized
            // 
            this.buttonShowHideMinimized.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonShowHideMinimized.FlatAppearance.BorderSize = 0;
            this.buttonShowHideMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowHideMinimized.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowHideMinimized.Image")));
            this.buttonShowHideMinimized.Location = new System.Drawing.Point(130, 5);
            this.buttonShowHideMinimized.Name = "buttonShowHideMinimized";
            this.buttonShowHideMinimized.Size = new System.Drawing.Size(30, 25);
            this.buttonShowHideMinimized.TabIndex = 10;
            this.toolTipHelper.SetToolTip(this.buttonShowHideMinimized, "Показать/Скрыть шаблон");
            this.buttonShowHideMinimized.UseVisualStyleBackColor = false;
            this.buttonShowHideMinimized.Click += new System.EventHandler(this.buttonShowHideMinimized_Click);
            // 
            // labelTemplateNameMinimized
            // 
            this.labelTemplateNameMinimized.AutoSize = true;
            this.labelTemplateNameMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemplateNameMinimized.Location = new System.Drawing.Point(3, 10);
            this.labelTemplateNameMinimized.Name = "labelTemplateNameMinimized";
            this.labelTemplateNameMinimized.Size = new System.Drawing.Size(108, 20);
            this.labelTemplateNameMinimized.TabIndex = 1;
            this.labelTemplateNameMinimized.Text = "ИмяШаблона";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 670);
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
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineThicknessTrackBar)).EndInit();
            this.colorsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.templatePanel.ResumeLayout(false);
            this.templatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templatePreviewBox)).EndInit();
            this.mainImagePanel.ResumeLayout(false);
            this.templatePanelMinimized.ResumeLayout(false);
            this.templatePanelMinimized.PerformLayout();
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
        private System.Windows.Forms.Label labelWidth;
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
        private System.Windows.Forms.Label labelPencil;
        private System.Windows.Forms.Label labelEraser;
        private System.Windows.Forms.Label labelFill;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label labelEllipse;
        private System.Windows.Forms.Label labelRect;
        private System.Windows.Forms.ToolTip toolTipHelper;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonShowHideTemp;
        private System.Windows.Forms.Panel templatePanelMinimized;
        private System.Windows.Forms.Button buttonTempCloseMinimized;
        private System.Windows.Forms.Button buttonTemplateMaximize;
        private System.Windows.Forms.Button buttonShowHideMinimized;
        private System.Windows.Forms.Label labelTemplateNameMinimized;
    }
}

