using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tick_tack_toe
{
    class Map
    {
        List<Figure> mapList;

        public Map(int mapWidht, int mapHeight)
        {
            mapList = new List<Figure>();

            //внешние границы
            HorizontalLine upLine = new HorizontalLine(0, mapWidht - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidht - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidht -2, '+');

            //внутриние линии
            HorizontalLine Line1 = new HorizontalLine(0, mapWidht - 2, mapHeight - 11, '+');
            HorizontalLine Line2 = new HorizontalLine(0, mapWidht - 2, mapHeight - 6, '+');
            VerticalLine Line3 = new VerticalLine(0, mapHeight - 1, mapWidht - 16, '+');
            VerticalLine Line4 = new VerticalLine(0, mapHeight - 1, mapWidht - 9, '+');

            mapList.Add(upLine);
            mapList.Add(downLine);
            mapList.Add(leftLine);
            mapList.Add(rightLine);
            mapList.Add(Line1);
            mapList.Add(Line2);
            mapList.Add(Line3);
            mapList.Add(Line4);
        }

        public void Draw()
        {
            foreach (var map in mapList)
            {
                map.Drow();
            }
        }
    }
}
