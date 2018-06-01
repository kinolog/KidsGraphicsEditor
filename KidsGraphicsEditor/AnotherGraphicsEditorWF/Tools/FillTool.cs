using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnotherGraphicsEditorWF.Tools
{
    class FillTool : ITool
    {
        public FillTool() : base()
        { }

        public void Draw(Bitmap b, Color curColor, Color setColor, int x, int y)
        {
            toolsPen.Color = setColor;
            PixelSetQueue(b, curColor, setColor, x, y);
        }        

        private void PixelSetQueue(Bitmap b, Color curColor, Color setColor, int x, int y)
        {
            Queue<Point> q = new Queue<Point>();
            if (b.GetPixel(x, y) != curColor)
                return;
            q.Enqueue(new Point(x, y));
            int i, j;
            do
            {
                Point p = q.Dequeue();
                b.SetPixel(p.X, p.Y, setColor);
                // left 
                i = 1;
                while ((p.X - i > 0) && (b.GetPixel(p.X - i, p.Y) == curColor))
                {
                    b.SetPixel(p.X - i, p.Y, setColor);
                    i++;
                }
                // right
                j = 1;
                while ((p.X + j < b.Width) && (b.GetPixel(p.X + j, p.Y) == curColor))
                {
                    b.SetPixel(p.X + j, p.Y, setColor);
                    j++;
                }
                for (int k = p.X - i + 1; k < p.X + j - 1; k++)
                {
                    // up
                    if (p.Y > 1)
                        if (b.GetPixel(k, p.Y - 1) == curColor)
                            q.Enqueue(new Point(k, p.Y - 1));
                    // down
                    if (p.Y < b.Height - 1)
                        if (b.GetPixel(k, p.Y + 1) == curColor)
                            q.Enqueue(new Point(k, p.Y + 1));                    
                }
            } while (q.Count > 0);
        }
    }
}
