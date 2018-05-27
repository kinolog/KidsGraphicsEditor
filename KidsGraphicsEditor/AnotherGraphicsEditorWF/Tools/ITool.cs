using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AnotherGraphicsEditorWF.Tools
{
    interface ITool
    {
        void Draw(Graphics g, Color setColor, int width,  ref int x1,  ref int y1,  ref int x2,  ref int y2);
    }
}
