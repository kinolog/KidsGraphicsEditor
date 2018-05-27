using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AnotherGraphicsEditorWF.Tools
{
    class PencilTool : ITool
    {
        Pen pencil;

        public PencilTool(Color setColor, int width)
        {
            pencil = new Pen(setColor, width);
        }

        public void Draw(Graphics g, Color setColor, int width, ref int x1, ref int y1, ref int x2, ref int y2)
        {
            pencil.Color = setColor;
            pencil.Width = width;
            g.DrawLine(pencil, x1, y1, x2, y2);
            x1 = x2;
            y1 = y2;
        }

       
    }
}
