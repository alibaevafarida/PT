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
            StreamWriter sw = new StreamWriter(file1); //создаем потоковый писатель
            for (int i = 1; i <= 10; i++)//исываем при помощи цикла цифры от одного до десяти
            {
              sw.Write(i + ",");
            };
            StreamReader sr=new StreamReader(file1); 
            Console.WriteLine( sr.ReadToEnd()); //читать  до конца
            sw.Close(); 
           sr.Close(); // закрываем потоки 
            Console.ReadKey();

            

        
        }
        



    }
}
