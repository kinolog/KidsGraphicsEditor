using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotherGraphicsEditorWF
{
    public partial class FormLoadTemplate : Form
    {
        public FormLoadTemplate()
        {
            InitializeComponent();
            initTemplates();
        }

        private List<List<string>> templateFiles = new List<List<string>>();
        private List<string> templatePicture = new List<string>();
        private List<string> templateBackground = new List<string>();
        private List<string> templateNames = new List<string>();
        private List<Tuple<Point, Point>> coordinates;
        private int chosen_template = -1;
        private PictureBox[] pictures;

        public List<string> TemplateFiles
        {
            get { return chosen_template == -1 ? null : templateFiles[chosen_template]; }
        }
        public string TemplateBackground
        {
            get { return chosen_template == -1 ? null : templateBackground[chosen_template]; }
        }
        public string TemplateName
        {
            get { return chosen_template == -1 ? null : templateNames[chosen_template]; }
        }

        private void initTemplates()
        {
            var path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Templates";

            //получить список директорий в Templates
            var templates = Directory.GetDirectories(path);

            //в каждой директории получить список файлов
            foreach (var template in templates)
            {
                List<string> files = Directory.GetFiles(template).ToList();
                files.Sort();
                if (files.Count != 0)
                {
                    //в списке файлов: если есть файл icon.jpg, то записать его
                    //то же самое для фона
                    int iconIndex = files.IndexOf("icon.jpg");
                    int backIndex = files.IndexOf("background.jpg");
                    if (backIndex != -1)
                    {
                        templateBackground.Add(files[backIndex]);
                        files.RemoveAt(backIndex);
                    }
                    else
                        templateBackground.Add(null);

                    if (iconIndex != -1)
                    {
                        templatePicture.Add(files[iconIndex]);
                        files.RemoveAt(iconIndex);
                    }
                    else
                        templatePicture.Add(files[files.Count - 1]);
                    //если icon.jpg нет, то записать файл с лексикографически
                    //наибольшим именем

                    templateFiles.Add(files);
                    templateNames.Add(template.Remove(0, (Path.GetDirectoryName(template).Length)).Replace("\\", ""));                    
                    //templateNames.Add(Path.GetDirectoryName(template));
                }
            }

            //отображение картинок на самой форме
            int NCOL = 3;
            int NROW = templatePicture.Count / NCOL + (templatePicture.Count % NCOL == 0 ? 0 : 1);

            pictures = new PictureBox[templatePicture.Count];
            coordinates = new List<Tuple<Point, Point>>();

            int W = 10, y = -250;
            for (int i = 0; i < pictures.Length; i++)
            {
                pictures[i] = new PictureBox();
                pictures[i].MouseClick += new MouseEventHandler(pictureBox_MouseClick);
                this.Controls.Add(pictures[i]);

                if (i % 3 == 0)
                {
                    W = 10;
                    y = y + 260;
                }
                int x = (i % 3) * 200 + W * (i % 3 + 1);
                pictures[i].Location = new Point(x, y);
                Point p1 = new Point(x, y);
                Point p2 = new Point(x + 200, y + 250);
                coordinates.Add(new Tuple<Point, Point>(p1, p2));
                pictures[i].Size = new Size(200, 250);
                pictures[i].Image = Image.FromFile(templatePicture[i]);

            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (chosen_template != -1)
                this.Close();
            else
                MessageBox.Show("Сначала выберите шаблон!");
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            var pbox = (PictureBox)sender;
            var scroll = AutoScrollPosition;
            var formPos = new Point(pbox.Location.X - scroll.X + e.X, pbox.Location.Y - scroll.Y + e.Y);

            int ind = coordinates.FindIndex(el => el.Item1.X <= formPos.X && formPos.X <= el.Item2.X &&
                                        el.Item1.Y <= formPos.Y && formPos.Y <= el.Item2.Y);
            if (ind != -1)
            {
                if (chosen_template == -1)
                {
                    chosen_template = ind;
                    pictures[chosen_template].BorderStyle = BorderStyle.Fixed3D;
                }
                else if (chosen_template != ind)
                {
                    pictures[chosen_template].BorderStyle = BorderStyle.None;
                    chosen_template = ind;
                    pictures[chosen_template].BorderStyle = BorderStyle.Fixed3D;
                }
            }
        }
    }
}
