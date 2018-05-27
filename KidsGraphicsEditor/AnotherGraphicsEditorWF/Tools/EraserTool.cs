using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AnotherGraphicsEditorWF.Tools
{
    class EraserTool : ITool
    {
        Pen eraser;

        public EraserTool(int width)
        {
            eraser = new Pen(Color.White, width);
        }

        public void Draw(Graphics g, Color setColor, int width, ref int x1, ref int y1, ref int x2, ref int y2)
        {            
            eraser.Width = width;
            g.DrawRectangle(eraser, x1, y1, eraser.Width, eraser.Width);
            x1 = x2;
            y1 = y2;
        }
    }
}
