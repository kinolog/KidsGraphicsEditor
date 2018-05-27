using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnotherGraphicsEditorWF.Tools
{
    class RectangleTool : ITool
    {
        Pen rectpen;
        public RectangleTool(Color setColor, int width)
        {
            rectpen.Color = setColor;
            rectpen.Width = width;
        }

        public void Draw(Graphics g, Color setColor, int width, ref int x1, ref int y1, ref int x2, ref int y2)
        { }
    }
}
