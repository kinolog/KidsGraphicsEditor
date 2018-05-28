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
        
        bool isTemplateOn;
        int curTemplateSize, curTemplateStep;
                
        bool mouseDown;
        int x1, y1, x2, y2; //coordinates of the mouse

        Bitmap snapshot;
        Bitmap tempDraw;
        Bitmap backPic;

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
        
        public FormMain()
        {                      
            InitializeComponent();
            //WindowState = FormWindowState.Maximized;
            openImageDialog.Title = "Открыть изображение";
            saveImageDialog.Title = "Сохранить изображение";
            
            isTemplateOn = false;
            curTemplateSize = -1;
            curTemplateStep = -1;
            BackgroundImage = null; //is it correct way to clear BackgroundImage of the form?
            templatePanel.Enabled = false;
            templatePanel.Visible = false;
            
            isImageSaved = true;

            backPic = null;
            snapshot = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            // cover all space with white
            Graphics g = Graphics.FromImage(snapshot);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, mainPictureBox.Width, mainPictureBox.Height);
            g.Dispose();

            mouseDown = false;
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
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog()== DialogResult.OK)
            {
                Image img = new Bitmap(openImageDialog.FileName);
                mainPictureBox.Height = Math.Max(img.Height, mainPictureBox.Height);
                mainPictureBox.Width = Math.Max(img.Width, mainPictureBox.Width);
                mainPictureBox.Image = img;
            }            
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = saveImageDialog.ShowDialog();
            ImageFormat format = ImageFormat.Png;
            if (res == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveImageDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                    case ".jpeg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                mainPictureBox.Image.Save(saveImageDialog.FileName, format);
                isImageSaved = true;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isImageSaved)
            {
                DialogResult res = MessageBox.Show("Может быть, ты хочешь сохранить картинку перед тем, как закроешь Рисовалочку?", "Сохранить картинку?", MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        {
                            DialogResult resDialog = saveImageDialog.ShowDialog();
                            ImageFormat format = ImageFormat.Png;
                            if (resDialog == DialogResult.OK)
                            {
                                string ext = System.IO.Path.GetExtension(saveImageDialog.FileName);
                                switch (ext)
                                {
                                    case ".jpg":
                                    case ".jpeg":
                                        format = ImageFormat.Jpeg;
                                        break;
                                    case ".bmp":
                                        format = ImageFormat.Bmp;
                                        break;
                                }
                                mainPictureBox.Image.Save(saveImageDialog.FileName, format);
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
        }

        private void buttonStepBack_Click(object sender, EventArgs e)
        {

        }

        private void buttonStepForward_Click(object sender, EventArgs e)
        {

        }

        private void mainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if ((tempDraw != null) && (activeToolControlName != null) && color != null)
            {
                // don't need to fix the changes immediately, only when button is released
                if (activeToolControlName != "labelPencil" && activeToolControlName != "labelEraser")
                    tempDraw = (Bitmap)snapshot.Clone();
                Graphics g = Graphics.FromImage(tempDraw);                
                // special signature for fill
                if (activeToolControlName == "labelFill")
                    toolsList[activeToolControlName].Draw(tempDraw, tempDraw.GetPixel(x1, y1), color, x1, y1);
                else
                    toolsList[activeToolControlName].Draw(g, color, width, ref x1, ref y1, ref x2, ref y2);
                e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
                g.Dispose();
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
            DialogResult res = openTemplateDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                string template = openTemplateDialog.FileName;
                //открыть выбранный шаблон
                isTemplateOn = true;
                templatePanel.Enabled = true;
                Image img = new Bitmap(openTemplateDialog.FileName);

                //if ((img.Height !=600) || (img.Width!=1100)) for the halftransparent
                //if ((img.Height !=250) || (img.Width!=200)) for the upper right corner

                templatePreviewBox.BackgroundImage = img;

                //backPic = new Bitmap(img);
                //mainPictureBox.Invalidate();
                //mainPictureBox.Update();

                //mainImagePanel.Controls.SetChildIndex(templatePanel, 0);
                //mainImagePanel.Controls.SetChildIndex(mainPictureBox, 1);
                //mainImagePanel.Controls.SetChildIndex(backPictureBox, 1);

                //mainImagePanel.BackgroundImage = img;
                //mainPictureBox.BackgroundImage = img;
                //mainPictureBox.BringToFront();

                //как сделать так, чтобы img отображалось только 1 раз на backgroundimage?
                templatePanel.Visible = true;
            }
        }

        private Bitmap CombineLayers()
        {
            tempDraw = (Bitmap)snapshot.Clone();            

            Bitmap res = new Bitmap(backPic);
            
            for (int i = 0; i < mainPictureBox.Width; i++)
            {
                for (int j = 0; j < mainPictureBox.Height; j++)
                {
                    if ((tempDraw.GetPixel(i, j) != Color.Transparent) && (tempDraw.GetPixel(i, j) != Color.White) && (tempDraw.GetPixel(i, j) != mainPictureBox.BackColor) &&
                        (tempDraw.GetPixel(i, j).A != 0) && (tempDraw.GetPixel(i, j).R != 0) && (tempDraw.GetPixel(i, j).G != 0) && (tempDraw.GetPixel(i, j).B != 0))
                        res.SetPixel(i, j, tempDraw.GetPixel(i, j));                    
                }
            }
            return res;
        }
    }
}