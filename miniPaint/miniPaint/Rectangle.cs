using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPaint
{
    class Rectangle: Figure
    {
        public Rectangle()
        {

        }

        public override void Draw(Pen drawingPen, Graphics graph, int startX, int startY, int x, int y)
        {
            if (startX < x && startY < y)
                graph.DrawRectangle(drawingPen, startX, startY, x - startX, y - startY);
            else if (startX < x && startY > y)
                graph.DrawRectangle(drawingPen, startX, y, x - startX, startY - y);
            else if (startX > x && startY > y)
                graph.DrawRectangle(drawingPen, x, y, startX - x, startY - y);
            else if (startX > x && startY < y)
                graph.DrawRectangle(drawingPen, x, startY, startX - x, y - startY);
        }

        public override void DrawMove(Pen drawingPen, Graphics graph, int startX, int startY, int x, int y)
        {
            //throw new NotImplementedException();
        }
    }
}
