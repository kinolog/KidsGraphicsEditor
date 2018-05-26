using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AnotherGraphicsEditorWF.Tools
{
    class Eraser : ITool
    {
        Pen eraser;

        public Eraser(int width)
        {
            Pen eraser = new Pen(Color.White, width);
        }

        public void Draw(object sender, MouseEventArgs e, Graphics g, int x1, int y1)
        {

        }
    }
}
