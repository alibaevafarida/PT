using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.models
{
    public class Snake : Drawer
    {
        public Snake()
        {
            color = ConsoleColor.Blue;
            figure = 'o';
        }
        public void move (int dx, int dy) {
               for( int i=body.Count-1; i>0; i--) 
               {
                    body[i].x=body[i-1].x;
                    body[i].y=body[i-1].y;
               }
            body[0].x+=dx;
            body[0].y+=dy;
            if(body[0].x==Game.Food.body[0].x &&
                body[0].y==Game.Food.body[0].y)
            {
                body.Add(new Coordinate (0, 0);
                Game.Food.NewRandomPosition();
            }
            for (int i=Game.Wall.body.Count-1; i>0; i--) {
                   if (body[0].x==Game.Wall.body[i].x &&
                       body[0].y==Game.Wall.body[i].y)
                   {
                       Game.GameOver=true;
                   }
            }
        }
    
            

    }
}
