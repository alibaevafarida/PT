using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string numb;
            numb = Console.ReadLine();
            string[] data = numb.Split();
            foreach (string a in data)
            {
                int cnt = 0;
                for(int i=1; i<Convert.ToInt16(a); i++) {
                    if (Convert.ToInt32(a) % i == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt <= 1)
                {
                    Console.WriteLine(a);
                }
           }
            Console.ReadKey();



        }
    }
}
