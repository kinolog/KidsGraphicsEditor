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

namespace AnotherGraphicsEditorWF
{
    public partial class FormMain : Form
    {
        bool isImageSaved = false;
        Color color = Color.Black;
        bool isTemplateOn = false;
        int curTemplateSize = -1, curTemplateStep = -1;
        
        public FormMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            openImageDialog.Title = "Открыть изображение";
            saveImageDialog.Title = "Сохранить изображение";

            isTemplateOn = false;
            BackgroundImage = null; //is it correct way to clear BackgroundImage of the form?
            templatePanel.Enabled = false;
            templatePanel.Visible = false;
            
            isImageSaved = true;
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
        }

        private void labelOrange_Click(object sender, EventArgs e)
        {
            color = Color.Orange;
        }

        private void labelYellow_Click(object sender, EventArgs e)
        {
            color = Color.Yellow;
        }

        private void labelBrown_Click(object sender, EventArgs e)
        {
            color = Color.Brown;
        }

        private void labelLightGreen_Click(object sender, EventArgs e)
        {
            color = Color.Lime;
        }

        private void labelDarkGreen_Click(object sender, EventArgs e)
        {
            color = Color.Green;
        }

        private void labelSkyBlue_Click(object sender, EventArgs e)
        {
            color = Color.Cyan;
        }

        private void labelBlue_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
        }

        private void labelPurple_Click(object sender, EventArgs e)
        {
            color = Color.BlueViolet;
        }

        private void labelViolet_Click(object sender, EventArgs e)
        {
            color = Color.BlueViolet;
        }

        private void labelPink_Click(object sender, EventArgs e)
        {
            color = Color.Magenta;
        }

        private void labelWhite_Click(object sender, EventArgs e)
        {
            color = Color.White;
        }

        private void labelBlack_Click(object sender, EventArgs e)
        {
            color = Color.Black;
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
                //mainPictureBox.BackgroundImage = img;
                mainImagePanel.BackgroundImage = img;
                
                //как сделать так, чтобы img отображалось только 1 раз на backgroundimage?
                templatePanel.Visible = true;
            }
        }
    }
}