using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            //int[] nums1 = new int[5];
            //nums1[0] = 1;
            //nums1[1] = 2;

            //foreach(int i in nums1)
            //{
            //    Console.WriteLine(i);
            //}


            //for(int i = 0; i < nums1.Length; i++)
            //{
            //    Console.WriteLine(nums1[i]);
            //}

            Point[] points = new Point[3];
            points[0] = new Point(1, 2, '*');
            points[1] = new Point(3, 4, '#');
            points[2] = new Point(4, 5, '*');

            foreach(Point p in points)
            {
                p.Draw();
            }
            

            Console.ReadKey();
        }
    }
}
