using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public FormMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            openImageDialog.Title = "Открыть изображение";
            saveImageDialog.Title = "Сохранить изображение";
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog()== DialogResult.OK)
            {
                mainPictureBox.Image = new Bitmap(openImageDialog.FileName);
            }
            
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveImageDialog.ShowDialog();
            DialogResult res = saveImageDialog.ShowDialog();
            if (res==DialogResult.OK)
            {

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
                            saveImageDialog.ShowDialog();
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
    }
}
