using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.models
{
    class Game 
    {
        public static Food food = new Food();
        public static Snake snake = new Snake();
        public static Wall wall = new Wall();
        public static bool GameOver = false;

        public Game()
        {
            Init();
            Play();
        }
        public void Init()
        {
            food.NewRandomPosition();
            snake.body.Add(new Coordinate(10, 10));
        }
        public void Draw()
        {
            Console.Clear();
            food.Draw();
            snake.Draw();
            wall.Draw();
        }
        public void Play(){

            }
}
