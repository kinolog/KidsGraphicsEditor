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
        public EraserTool(int pensWidth) : base(pensWidth)
        { }

        public void Draw(ref Bitmap b, int width, ref int x1, ref int y1, ref int x2, ref int y2)
        {
            toolsPen.Width = width;
            for (int x = x1; x < x1 + width; x++)
            {
                for (int y = y1; y < y1 + width; y++)
                {
                    if ((b.GetPixel(x, y) != Color.Transparent) && (b.GetPixel(x, y) != Color.White) &&
                        !((b.GetPixel(x, y).A == 0) && (b.GetPixel(x, y).R == 0) && (b.GetPixel(x, y).G == 0) && (b.GetPixel(x, y).B == 0)))
                        b.SetPixel(x, y, Color.Transparent);
                }
            }
            x1 = x2;
            y1 = y2;
        }
    }
}
