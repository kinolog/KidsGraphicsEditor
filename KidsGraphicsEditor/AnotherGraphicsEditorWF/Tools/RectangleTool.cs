﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnotherGraphicsEditorWF.Tools
{
    class RectangleTool : ITool
    {
        Pen rectPen;

        public RectangleTool(int width)
        {
            rectPen = new Pen(Color.Black, width);            
        }

        public void Draw(Graphics g, Color setColor, int width, ref int x1, ref int y1, ref int x2, ref int y2)
        {
            rectPen.Color = setColor;
            rectPen.Width = width;
            int xmin = x1 > x2 ? x2 : x1;
            int ymin = y1 > y2 ? y2 : y1;
            g.DrawRectangle(rectPen, xmin, ymin, Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
    }
}
