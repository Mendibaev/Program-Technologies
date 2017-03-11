using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake.Model
{
    [Serializable]
    public class Snake : Drawer
    {
        public Snake(ConsoleColor color, char sign, List<Point> body) : base(color, sign, body) { }
        public static string direction;

        public void Move(int dx, int dy)
        {
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            if (body[0].x + dx == 75)
            {
                body[0].x = 0;
            } else
            {
                if (body[0].x + dx == 0)
                    body[0].x = 75;
                else
                    body[0].x += dx;

            }
            if (body[0].y + dy == 35)
            {
                body[0].y = 0;
            }
            else
            {
                if (body[0].y + dy == 0)
                    body[0].y = 35;
                else
                    body[0].y += dy;

            }
            body[0].x += dx;
            body[0].y += dy;




            // TODO: can snake eat?
            // TODO: check for collision with wall 
            for (int i = 0; i < Game.wall.body.Count; i++)
            {
                if (Game.wall.body[i].x == body[0].x && Game.wall.body[i].y == body[0].y)
                {
                    Console.Clear();
                    Console.SetCursorPosition(30, 15);
                    Console.Write("Game Over");
                    Console.ReadKey();

                }

            }
            // TODO: check for collision with itself (snake)
            for (int i=1; i<Game.snake.body.Count; i++)
            {
                if (Game.snake.body[i].x==body[0].x && Game.snake.body[i].y==body[0].y)
                {
                    Console.Clear();
                    Console.SetCursorPosition(30, 15);
                    Console.Write("Game Over");
                    Console.ReadKey();
                }
                
            }
            // TODO: check for collision with border (console border (maximum width and height))
            // TODO: if necessary, load new level of the wall
        }

        public bool CanEat(Food f)
        {
            if (body[0].x == f.body[0].x && body[0].y == f.body[0].y)
            {
                body.Add(new Point(f.body[0].x, f.body[0].y));
                return true;
            }
            return false;
        }
    
      
            }
        }

                   
