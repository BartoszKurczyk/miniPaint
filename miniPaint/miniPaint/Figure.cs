using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace miniPaint
{
    abstract class Figure
    {
        public Figure()
        {
        }

        public abstract void Draw(Pen drawingPen, Graphics graph, int startX, int startY, int x, int y);
        public abstract void DrawMove(Pen drawingPen, Graphics graph, int startX, int startY, int x, int y);
    }
}
