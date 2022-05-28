using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    abstract class Figure
    {
        const int LENGTH = 4;
        public Point[] Points = new Point[LENGTH];

        public abstract void Rotate(Point[] pList);

        internal Result TryMove(Direction dir)
        {
            Hide();

            var clone = Clone();
            Move(clone, dir);

            var result = VerifyPosition(clone);
            if (result == Result.SUCCESS)
                Points = clone;

            Draw();
            return result;
        }

        internal Result TryRotate()
        {
            Hide();

            var clone = Clone();
            Rotate(clone);

            var result = VerifyPosition(clone);
            if (result == Result.SUCCESS)
                Points = clone;

            Draw();
            return result;
        }

        private Result VerifyPosition(Point[] pList)
        {
            foreach(var p in pList)
            {
                if (p.Y >= Field.Height)
                    return Result.DOWN_BORDER_STRIKE;

                if (p.X >= Field.Width - 1 || p.X < 0 || p.Y < 0)
                    return Result.BORDER_STRIKE;

                if (Field.CheckStrike(p))
                    return Result.HEAP_STRIKE;
            }

            return Result.SUCCESS;
        }

        private Point[] Clone()
        {
            var newPoints = new Point[LENGTH];
            for (int i = 0; i < LENGTH; i++)
            {
                newPoints[i] = new Point(Points[i]);
            }
            return newPoints;
        }

        public void Move(Point[] pList, Direction dir)
        {
            foreach(var p in pList)
            {
                p.Move(dir);
            }
        }

        public void Hide()
        {
            foreach (Point p in Points)
            {
                p.Hide();
            }
        }
        
        public void Draw()
        {
            foreach (Point p in Points)
            {
                p.Draw();
            }
        }
    }
}
