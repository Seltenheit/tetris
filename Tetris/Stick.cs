using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Stick : Figure
    {
        public Stick(int x, int y)
        {
            base.Points[0] = new Point(x, y);
            base.Points[1] = new Point(x, y + 1);
            base.Points[2] = new Point(x, y + 2);
            base.Points[3] = new Point(x, y + 3);
            Draw();
        }

        public override void Rotate()
        {
            if(base.Points[0].X == base.Points[1].X)
            {
                RotateHorisontal();
            }
            else
            {
                RotateVertical();
            }
        }

        private void RotateVertical()
        {
            for (int i = 0; i < base.Points.Length; i++)
            {
                base.Points[i].X = Points[0].X;
                Points[i].Y = Points[0].Y + i;
            }
        }

        private void RotateHorisontal()
        {
            for(int i = 0; i < Points.Length; i++)
            {
                Points[i].Y = Points[0].Y;
                Points[i].X = Points[0].X + i;
            }
        }
    }
}
