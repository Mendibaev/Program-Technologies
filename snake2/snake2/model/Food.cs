using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake.Model
{
    [Serializable]
    public class Food : Drawer
    {
        public Food(ConsoleColor color, char sign, List<Point> body) : base(color, sign, body)
        {
            SetRandomPosition();
        }

        public void SetRandomPosition()
        {
            Point newPoint = new Point(new Random().Next(0, 70), new Random().Next(0, 35));


            body[0] = newPoint;
        }
    }
}