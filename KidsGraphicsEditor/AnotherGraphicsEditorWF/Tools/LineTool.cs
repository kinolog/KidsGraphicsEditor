using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnotherGraphicsEditorWF.Tools
{
    class LineTool : ITool
    {
        Pen linePen;

        public LineTool(int width)
        {
            linePen = new Pen(Color.Black, width);
        }

        public void Draw(Graphics g, Color setColor, int width, ref int x1, ref int y1, ref int x2, ref int y2)
        {
            linePen.Color = setColor;
            linePen.Width = width;
            g.DrawLine(linePen, x1, y1, x2, y2);            
        }
    }
}
