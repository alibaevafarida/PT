using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FileStream file1 = new FileStream("file1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); // создаем поток файлов
            FileStream file2 = new FileStream("file2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(file2); //создаем потоковый писатель
             StreamReader sr=new StreamReader(file1);

            /* for (int i = 1; i <= 10; i++)//исываем при помощи цикла цифры от одного до десяти
            {
              sw.Write(i + ",");
            };
             */ 

            string[] numb = sr.ReadLine().Split(',');
            int min = Convert.ToInt32(numb[0]);
            int max = Convert.ToInt32(numb[0]);
            
            foreach (string s in numb)
            {
                

                if (int.Parse(s) < min)
                {
                    min = int.Parse(s);
                }
                if (int.Parse(s) > max)
                {
                    max = int.Parse(s);
                }
            }

            Console.WriteLine("minimum = {0} , maximum = {1}" ,min, max);


           
            sw.Close(); 
           sr.Close();
           file1.Close();
           file2.Close();// закрываем потоки 
            Console.ReadKey();



            

        
        }
        



    }
}
