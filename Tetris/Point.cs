using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
        }

        public Point(int a, int b)
        {
            X = a;
            Y = b;
        }
        public Point() { }

        internal void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.LEFT:
                    X -= 1;
                    break;
                case Direction.RIGHT:
                    X += 1;
                    break;
                case Direction.DOWN:
                    Y += 1;
                    break;
                case Direction.UP:
                    Y-= 1;
                    break;
            }
        }

        internal void Hide()
        {
            DrawerProvider.Drawer.HidePoint(X, Y);
        }

        public void Draw()
        {
            DrawerProvider.Drawer.DrawPoint(X, Y);
        }

    }
}
