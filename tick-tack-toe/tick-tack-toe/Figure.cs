using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tick_tack_toe
{
    class Figure
    {
        protected List<Point> pList;

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
