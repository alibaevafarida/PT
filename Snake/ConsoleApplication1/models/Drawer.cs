using System;
using System. IO;
using System.Xml.Serialization; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.models
{
    public class Drawer
    {
        public ConsoleColor color; 
        public char figure;
        public List<Coordinate> body = new List<Coordinate>(); //vector coordinat
        public  Drawer () { } //?
        public  void Draw //function to draw
        { 
            Console.ForegroundColor = color;   
            foreach (Coordinate  c in body) //each point became figure
                {
                Console.SetCursorPosition(p.x, p.y); 
                Console.Write(figure);
                }
        }
        
    }
}
        


