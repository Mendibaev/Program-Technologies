﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake.Model
{
    [Serializable]
    public class Game
    {
        public static bool GameOver;
        public static Snake snake;
        public static Food food;
        public static Wall wall;
        public static int curLevel = 1;
        public static int curPoint = 0;

        public static void Init()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(70, 35);

            GameOver = false;

            // snake init
            List<Point> snake_body = new List<Point>();
            snake_body.Add(new Point(10, 10));
            snake_body.Add(new Point(9, 10));
            snake = new Snake(ConsoleColor.Yellow, '0', snake_body);

            // food init
            List<Point> food_body = new List<Point>();
            food_body.Add(new Point(0, 0));
            food = new Food(ConsoleColor.Green, '$', food_body);

            // wall init
            List<Point> wall_body = new List<Point>();
            wall = new Wall(ConsoleColor.Red, '#', wall_body);
        }

        public static void Draw()
        {
            Console.Clear();
            snake.Draw();
            food.Draw();
            wall.Draw();
            Drawer.PanelDraw();
        }

        // TODO: The Save function for all classes like Draw() above
        public static void Save()
        {
            snake.Save();
            food.Save();
            wall.Save();
        }

        // TODO: The Resume function for all classes like Draw() above
        public static void Resume()
        {
            snake.Resume();
            food.Resume();
            wall.Resume();
        }



    }
}