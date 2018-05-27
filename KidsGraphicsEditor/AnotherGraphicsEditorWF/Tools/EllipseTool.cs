using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnotherGraphicsEditorWF.Tools
{
    class EllipseTool : ITool
    {        
        public EllipseTool(int pensWidth) : base(pensWidth)
        { }

        public override void Draw(Graphics g, Color setColor, int width, ref int x1, ref int y1, ref int x2, ref int y2)
        {
            toolsPen.Color = setColor;
            toolsPen.Width = width;
            int xmin = x1 > x2 ? x2 : x1;
            int ymin = y1 > y2 ? y2 : y1;
            g.DrawEllipse(toolsPen, xmin, ymin, Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
    }
}
