using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Farida\Desktop"; //указываем путь
            DirectoryInfo dir = new DirectoryInfo(path); //создаем поток 

            List<FileSystemInfo> items = new List<FileSystemInfo>(); //создаем вектор 
            items.AddRange(dir.GetDirectories());  //добавляем в конец списка 
            items.AddRange(dir.GetFiles()); 

            int index = 0;

            while (true) //создаем бесконечный цикл
            {
                for (int i = 0; i < items.Count; ++i)  //пробегаемся по длине вектора
                {
                    if (i == index)  
                    {
                        Console.BackgroundColor = ConsoleColor.Red; //kursor
                    }
                    if (items[i].GetType() == typeof(FileInfo)) //  elementy tipa faila zapisyvaet s chernym shriftom
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine(items[i].Name);  // 
                    Console.BackgroundColor = ConsoleColor.Blue; 
                    Console.ForegroundColor = ConsoleColor.White; // другие белым шрифтом
                }


                ConsoleKeyInfo pressedKey = Console.ReadKey(); // запоминает ввод с консоля как pressedKey
                switch (pressedKey.Key)  //выражение
                {
                    case ConsoleKey.UpArrow: //если верхнее выражение совподает со значением данного случая,
                        if (index > 0)  //выполняется этот блок, затем останавливается
                            index--;
                        break;          
                    case ConsoleKey.DownArrow: // и так далее
                        if (index < items.Count - 1) 
                            index++;
                        break;
                    case ConsoleKey.Enter:
                        if (items[index].GetType() == typeof(DirectoryInfo))
                        {
                            path = items[index].FullName;
                            dir = new DirectoryInfo(path);
                            items.Clear();
                            items.AddRange(dir.GetDirectories());
                            items.AddRange(dir.GetFiles());
                            index = 0;
                        }
                        break;
                }
                Console.Clear(); 
            }
        }
    }
}
