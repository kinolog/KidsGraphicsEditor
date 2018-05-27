﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnotherGraphicsEditorWF.Tools
{
    class EraserTool : ITool
    {
        Pen eraserPen;

        public EraserTool(int width)
        {
            eraserPen = new Pen(Color.White, width);
        }

        public void Draw(Graphics g, Color setColor, int width, ref int x1, ref int y1, ref int x2, ref int y2)
        {
            eraserPen.Width = width;
            g.DrawRectangle(eraserPen, x1, y1, eraserPen.Width, eraserPen.Width);
            x1 = x2;
            y1 = y2;
        }
    }
}
