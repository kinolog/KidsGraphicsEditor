using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnotherGraphicsEditorWF.Tools
{
    class EraserTool : ITool
    {  
        public EraserTool(int pensWidth) : base (pensWidth)
        { }

        public override void Draw(Graphics g, Color setColor, int width, ref int x1, ref int y1, ref int x2, ref int y2)
        {
            toolsPen.Width = width;
            g.DrawRectangle(toolsPen, x1, y1, toolsPen.Width, toolsPen.Width);
            x1 = x2;
            y1 = y2;
        }
    }
}
