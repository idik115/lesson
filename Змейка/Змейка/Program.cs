using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();

            #region нам это заменил class Point
            //int x1 = 1;
            //int y1 = 3;
            //char sym1 = '*';

            //Draw(x1, y1, sym1);


            //int x2 = 4;
            //int y2 = 6;
            //char sym2 = '#';
            #endregion

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';

            p2.Draw();



            Console.ReadLine();
        }
        #region нам это заменил class Point
        //static void Draw(int x, int y, char sym)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.WriteLine(sym);
        //}
        #endregion
    }
}
