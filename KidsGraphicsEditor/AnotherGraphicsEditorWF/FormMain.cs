using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnotherGraphicsEditorWF.Tools;

namespace AnotherGraphicsEditorWF
{
    public partial class FormMain : Form
    {
        bool isImageSaved;

        bool templateShown;
        bool isTemplateOn;
        int curTemplateSize, curTemplateStep;
                
        bool mouseDown;
        int x1, y1, x2, y2; //coordinates of the mouse

        Bitmap snapshot;
        Bitmap tempDraw;
        Bitmap backPic;
        Image loadPic;

        bool clearFlag;
        bool loadPicFlag;

        int width;        
        Color color;
        string activeToolControlName;
        Control labelToolPrev;
        string activeColorControlName;
        Control labelColorPrev;
                
        Dictionary<string, ITool> toolsList;
        EraserTool eraser;
        PencilTool pencil;
        RectangleTool rect;
        LineTool line;
        EllipseTool ellipse;
        FillTool fill;

        FormLoadTemplate loadTemplate;
        List<string> templateFiles = null;
        string templateBackground = null;
        string templateName = null;

        public FormMain()
        {                      
            InitializeComponent();
            //WindowState = FormWindowState.Maximized;
            openImageDialog.Title = "Открыть изображение";
            saveImageDialog.Title = "Сохранить изображение";

            templateShown = false;
            isTemplateOn = false;            
            curTemplateSize = -1;
            curTemplateStep = -1;
            BackgroundImage = null; //is it correct way to clear BackgroundImage of the form?
            templatePanel.Enabled = false;
            templatePanel.Visible = false;            
            
            isImageSaved = false;
            
            snapshot = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            backPic = new Bitmap(mainImagePanel.Width, mainImagePanel.Height);
            loadPic = null;

            mouseDown = false;
            clearFlag = false;
            loadPicFlag = false;
            activeToolControlName = null;
            activeColorControlName = null;
            width = lineThicknessTrackBar.Value;

            eraser = new EraserTool(width);
            pencil = new PencilTool(width);
            rect = new RectangleTool( width);
            line = new LineTool(width);
            ellipse = new EllipseTool(width);
            fill = new FillTool();

            toolsList = new Dictionary<string, ITool>();
            toolsList.Add("labelPencil", pencil);
            toolsList.Add("labelEraser", eraser);
            toolsList.Add("labelRect", rect);
            toolsList.Add("labelLine", line);
            toolsList.Add("labelEllipse", ellipse);
            toolsList.Add("labelFill", fill);

            loadTemplate = new FormLoadTemplate();
            
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog()== DialogResult.OK)
            {
                loadPic = new Bitmap(openImageDialog.FileName);                               
                loadPicFlag = true;
                mainPictureBox.Invalidate();
                mainPictureBox.Update();
            }            
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = saveImageDialog.ShowDialog();
            ImageFormat imformat = ImageFormat.Png;
            if (res == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveImageDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                    case ".jpeg":
                        imformat = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        imformat = ImageFormat.Bmp;
                        break;
                }

                Bitmap picToSave = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
                mainPictureBox.DrawToBitmap(picToSave, new Rectangle(0, 0, backPic.Width, backPic.Height));
                // as we got transparent background - have to change it to white
                ReplaceTransparentWithWhite(ref picToSave);
                picToSave.Save(saveImageDialog.FileName, imformat);
                isImageSaved = true;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isImageSaved)
            {
                DialogResult res = MessageBox.Show("Может быть, вы хотите сохранить картинку перед тем, как закрыть Рисовалочку?", "Сохранить картинку?", MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        {
                            DialogResult resDialog = saveImageDialog.ShowDialog();
                            ImageFormat imformat = ImageFormat.Png;
                            if (resDialog == DialogResult.OK)
                            {
                                string ext = System.IO.Path.GetExtension(saveImageDialog.FileName);
                                switch (ext)
                                {
                                    case ".jpg":
                                    case ".jpeg":
                                        imformat = ImageFormat.Jpeg;
                                        break;
                                    case ".bmp":
                                        imformat = ImageFormat.Bmp;
                                        break;
                                }
                                
                                Bitmap picToSave = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
                                mainPictureBox.DrawToBitmap(picToSave, new Rectangle(0, 0, backPic.Width, backPic.Height));                                
                                // as we got transparent background - have to change it to white
                                ReplaceTransparentWithWhite(ref picToSave);
                                picToSave.Save(saveImageDialog.FileName, imformat);
                                isImageSaved = true;
                            }
                        }
                        break;

                    case DialogResult.No:
                        break;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        #region settingColor
        private void labelRed_Click(object sender, EventArgs e)
        {
            color = Color.Red;
            labelColorPrev = colorsPanel.Controls[activeColorControlName];
            if (labelColorPrev != null)
                ((Label)labelColorPrev).BorderStyle = BorderStyle.None;
            activeColorControlName = "labelRed";             
            labelRed.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelOrange_Click(object sender, EventArgs e)
        {
            color = Color.Orange;
            labelColorPrev = colorsPanel.Controls[activeColorControlName];
            if (labelColorPrev != null)
                ((Label)labelColorPrev).BorderStyle = BorderStyle.None;
            activeColorControlName = "labelOrange";            
            labelOrange.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelYellow_Click(object sender, EventArgs e)
        {
            color = Color.Yellow;
            labelColorPrev = colorsPanel.Controls[activeColorControlName];
            if (labelColorPrev != null)
                ((Label)labelColorPrev).BorderStyle = BorderStyle.None;
            activeColorControlName = "labelYellow";            
            labelYellow.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelBrown_Click(object sender, EventArgs e)
        {
            color = Color.Brown;
            labelColorPrev = colorsPanel.Controls[activeColorControlName];
            if (labelColorPrev != null)
                ((Label)labelColorPrev).BorderStyle = BorderStyle.None;
            activeColorControlName = "labelBrown";
            labelBrown.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelLightGreen_Click(object sender, EventArgs e)
        {
            color = Color.Lime;
            labelColorPrev = colorsPanel.Controls[activeColorControlName];
            if (labelColorPrev != null)
                ((Label)labelColorPrev).BorderStyle = BorderStyle.None;
            activeColorControlName = "labelLightGreen";
            labelLightGreen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelDarkGreen_Click(object sender, EventArgs e)
        {
            color = Color.Green;
            labelColorPrev = colorsPanel.Controls[activeColorControlName];
            if (labelColorPrev != null)
                ((Label)labelColorPrev).BorderStyle = BorderStyle.None;
            activeColorControlName = "labelDarkGreen";
            labelDarkGreen.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelSkyBlue_Click(object sender, EventArgs e)
        {
            color = Color.Cyan;
            labelColorPrev = colorsPanel.Controls[activeColorControlName];
            if (labelColorPrev != null)
                ((Label)labelColorPrev).BorderStyle = BorderStyle.None;
            activeColorControlName = "labelSkyBlue";
            labelSkyBlue.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelBlue_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
            labelColorPrev = colorsPanel.Controls[activeColorControlName];
            if (labelColorPrev != null)
                ((Label)labelColorPrev).BorderStyle = BorderStyle.None;
            activeColorControlName = "labelBlue";
            labelBlue.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelViolet_Click(object sender, EventArgs e)
        {
            color = Color.BlueViolet;
            labelColorPrev = colorsPanel.Controls[activeColorControlName];
            if (labelColorPrev != null)
                ((Label)labelColorPrev).BorderStyle = BorderStyle.None;
            activeColorControlName = "labelViolet";
            labelViolet.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelPink_Click(object sender, EventArgs e)
        {
            color = Color.Magenta;
            labelColorPrev = colorsPanel.Controls[activeColorControlName];
            if (labelColorPrev != null)
                ((Label)labelColorPrev).BorderStyle = BorderStyle.None;
            activeColorControlName = "labelPink";
            labelPink.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelWhite_Click(object sender, EventArgs e)
        {
            color = Color.White;
            labelColorPrev = colorsPanel.Controls[activeColorControlName];
            if (labelColorPrev != null)
                ((Label)labelColorPrev).BorderStyle = BorderStyle.None;
            activeColorControlName = "labelWhite";
            labelWhite.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelBlack_Click(object sender, EventArgs e)
        {
            color = Color.Black;
            labelColorPrev = colorsPanel.Controls[activeColorControlName];
            if (labelColorPrev != null)
                ((Label)labelColorPrev).BorderStyle = BorderStyle.None;
            activeColorControlName = "labelBlack";
            labelBlack.BorderStyle = BorderStyle.Fixed3D;
        }
        #endregion

        #region settingTool
        private void labelPencil_Click(object sender, EventArgs e)
        {            
            labelToolPrev = toolsPanel.Controls[activeToolControlName];
            if (labelToolPrev != null)
                ((Label)labelToolPrev).BorderStyle = BorderStyle.None;
            activeToolControlName = "labelPencil";
            labelPencil.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelEraser_Click(object sender, EventArgs e)
        {
            labelToolPrev = toolsPanel.Controls[activeToolControlName];
            if (labelToolPrev != null)
                ((Label)labelToolPrev).BorderStyle = BorderStyle.None;
            activeToolControlName = "labelEraser";
            labelEraser.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelFill_Click(object sender, EventArgs e)
        {
            labelToolPrev = toolsPanel.Controls[activeToolControlName];
            if (labelToolPrev != null)
                ((Label)labelToolPrev).BorderStyle = BorderStyle.None;
            activeToolControlName = "labelFill";
            labelFill.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelLine_Click(object sender, EventArgs e)
        {
            labelToolPrev = toolsPanel.Controls[activeToolControlName];
            if (labelToolPrev != null)
                ((Label)labelToolPrev).BorderStyle = BorderStyle.None;
            activeToolControlName = "labelLine";
            labelLine.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelRect_Click(object sender, EventArgs e)
        {
            labelToolPrev = toolsPanel.Controls[activeToolControlName];
            if (labelToolPrev != null)
                ((Label)labelToolPrev).BorderStyle = BorderStyle.None;
            activeToolControlName = "labelRect";
            labelRect.BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelEllipse_Click(object sender, EventArgs e)
        {
            labelToolPrev = toolsPanel.Controls[activeToolControlName];
            if (labelToolPrev != null)
                ((Label)labelToolPrev).BorderStyle = BorderStyle.None;
            activeToolControlName = "labelEllipse";
            labelEllipse.BorderStyle = BorderStyle.Fixed3D;
        }
        #endregion

        private void buttonTemplateClose_Click(object sender, EventArgs e)
        {
            isTemplateOn = false;
            BackgroundImage = null; //is it correct way to clear BackgroundImage of the form?
            templatePanel.Enabled = false;
            templatePanel.Visible = false;
            templateFiles = null;
            templateBackground = null;
            templateName = null;
        }

        private void buttonStepBack_Click(object sender, EventArgs e)
        {

        }

        private void buttonStepForward_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowHideTemp_Click(object sender, EventArgs e)
        {
            if (!templateShown)
            {
                mainImagePanel.BackgroundImage = backPic;
                templateShown = true;
            }
            else
            {
                mainImagePanel.BackgroundImage = null;
                templateShown = false;
            }

        }

        private void mainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (loadPicFlag)
            {
                snapshot = (Bitmap)loadPic;
                e.Graphics.DrawImageUnscaled(snapshot, 0, 0);
                loadPicFlag = false;
            }
            else

            if (tempDraw != null && activeToolControlName != null && color != null)
            {
                if (clearFlag)
                {
                    for (int i = 0; i < mainPictureBox.Width; i++)
                    {
                        for (int j = 0; j < mainPictureBox.Height; j++)
                        {
                            snapshot.SetPixel(i, j, Color.Transparent);
                        }
                    }
                    e.Graphics.DrawImageUnscaled(snapshot, 0, 0);
                    clearFlag = false;
                }

                else
                {
                    // don't need to fix the changes immediately, only when button is released
                    if (activeToolControlName != "labelPencil" && activeToolControlName != "labelEraser")
                        tempDraw = (Bitmap)snapshot.Clone();
                    Graphics g = Graphics.FromImage(tempDraw);

                    // special signature for fill
                    if (activeToolControlName == "labelFill")
                        ((FillTool)toolsList[activeToolControlName]).Draw(tempDraw, tempDraw.GetPixel(x1, y1), color, x1, y1);
                    else
                        if (activeToolControlName == "labelEraser")
                        ((EraserTool)toolsList[activeToolControlName]).Draw(ref tempDraw, width, ref x1, ref y1, ref x2, ref y2);
                    else
                        toolsList[activeToolControlName].Draw(g, color, width, ref x1, ref y1, ref x2, ref y2);

                    e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
                    g.Dispose();
                }
            }
        }

        // order: mouseDown -> mouseClick -> mouseUp
        #region mouseEventHandlers
        private void mainPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((activeToolControlName == "labelFill"))
            {
                x1 = e.X;
                y1 = e.Y;

                mainPictureBox.Invalidate();
                mainPictureBox.Update();
            }
        }

        private void mainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            x1 = e.X;
            y1 = e.Y;
            tempDraw = (Bitmap)snapshot.Clone();
        }

        private void mainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // avoid unnecessary redrawing
            if ((mouseDown) && (activeToolControlName != "labelFill"))
            {
                x2 = e.X;
                y2 = e.Y;
                mainPictureBox.Invalidate();
                mainPictureBox.Update();
            }
        }

        private void mainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            snapshot = (Bitmap)tempDraw.Clone();            
        }
        #endregion

        // tracking the change of width
        private void lineThicknessTrackBar_ValueChanged(object sender, EventArgs e)
        {
            width = lineThicknessTrackBar.Value;
        }

        private void showTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //показать диалог
            DialogResult res = loadTemplate.ShowDialog();
            if (res == DialogResult.OK)
            {
                templateFiles = loadTemplate.TemplateFiles;
                templateBackground = loadTemplate.TemplateBackground;
                templateName = loadTemplate.TemplateName;
                labelTemplateName.Text = templateName;

                //string template = openTemplateDialog.FileName;    //unnecessary line
                //открыть выбранный шаблон
                isTemplateOn = true;
                templatePanel.Enabled = true;
                Image img = new Bitmap(templateFiles[0]);
                backPic = new Bitmap(templateFiles[templateFiles.Count - 2]);

                // size reminder
                //if ((backPic.Height !=600) || (backPic.Width!=1100)) 
                //if ((img.Height !=250) || (img.Width!=200))

                templateShown = true;
                templatePreviewBox.BackgroundImage = img;
                mainImagePanel.BackgroundImage = backPic;

                templatePanel.Visible = true;
            }           
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFlag = true;
            mainPictureBox.Invalidate();
            mainPictureBox.Update();
        }

        private void ReplaceTransparentWithWhite(ref Bitmap b)
        {
            for (int x = 0; x<b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                    if (b.GetPixel(x, y) == Color.Transparent)
                        b.SetPixel(x, y, Color.White);
            }
        }
    }
}