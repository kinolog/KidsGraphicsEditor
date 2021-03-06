﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnotherGraphicsEditorWF.Tools
{
    class LineTool : ITool
    {        
        public LineTool(int pensWidth) : base(pensWidth)
        { }

        public override void Draw(Graphics g, Color setColor, int width, ref int x1, ref int y1, ref int x2, ref int y2)
        {
            toolsPen.Color = setColor;
            toolsPen.Width = width;
            g.DrawLine(toolsPen, x1, y1, x2, y2);            
        }
    }
}
