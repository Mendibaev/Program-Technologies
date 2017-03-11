using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySnake.Model;
using System.Threading;

namespace MySnake
{
    class Program
    {

        static Thread First = new Thread(new ThreadStart(game));
        static Thread Second = new Thread(new ThreadStart(changeDirection));

        private static void changeDirection()
        {
            while(Game.GameOver == false)
            {
                Game.Draw();
                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        Snake.direction = "up";
                        break;
                    case ConsoleKey.DownArrow:
                        Snake.direction = "down";
                        break;
                    case ConsoleKey.LeftArrow:
                        Snake.direction = "left";
                        break;
                    case ConsoleKey.RightArrow:
                        Snake.direction = "right";
                        break;
                    case ConsoleKey.Escape:
                        Game.GameOver = true;
                        break;
                    case ConsoleKey.F2:
                        Game.Save();
                        break;
                    case ConsoleKey.F3:
                        Game.Resume();
                        break;

                }
                Thread.Sleep(200);
            }

        }

        private static void game()
        {
            Second.Start();
            Game.Init();

            while (!Game.GameOver)
            {
                Game.Draw();
                switch (Snake.direction)
                {
                    case "up":
                        Game.snake.Move(0, -1);
                        break;
                    case "down":
                        Game.snake.Move(0, 1);
                        break;
                    case "left":
                        Game.snake.Move(-1, 0);
                        break;
                    case "right":
                        Game.snake.Move(1, 0);
                        break;
                }
                // TODO: remove following expressions and put them in right Class
                if (Game.snake.CanEat(Game.food))
                {
                    Game.food.SetRandomPosition();
                    Game.curPoint++;
                }
                if (Game.curPoint == 3)
                {
                    Game.curPoint = 0;
                    Game.wall.LoadLevel(Game.curLevel);
                    Game.curLevel++;
                }

                Thread.Sleep(200);
            }
        }

        static void Main(string[] args)
        {
            First.Start();
        }
    }
}