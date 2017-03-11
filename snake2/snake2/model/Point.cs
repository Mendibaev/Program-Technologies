using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake.Model
{
    [Serializable]
    public class Point
    {
        public int x;
        public int y;

        public Point(int Newx, int y)
        {
            x = Newx;
            this.y = y;
        }
    }
}