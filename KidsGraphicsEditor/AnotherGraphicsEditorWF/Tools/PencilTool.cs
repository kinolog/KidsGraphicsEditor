using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnotherGraphicsEditorWF.Tools
{
    class PencilTool : ITool
    {
        Pen pencilPen;

        public PencilTool(int width)
        {
            pencilPen = new Pen(Color.Black, width);
        }

        public void Draw(Graphics g, Color setColor, int width, ref int x1, ref int y1, ref int x2, ref int y2)
        {
            pencilPen.Color = setColor;
            pencilPen.Width = width;
            g.DrawLine(pencilPen, x1, y1, x2, y2);
            x1 = x2;
            y1 = y2;
        }
    }
}
