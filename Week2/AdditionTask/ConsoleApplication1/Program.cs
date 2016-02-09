using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Farida\Desktop\PT_labs"; //указываем путь
            DirectoryInfo dir = new DirectoryInfo(path); //создаем поток 



            int index = 0;
            List<FileSystemInfo> F = new List<FileSystemInfo>();

            F.AddRange(dir.GetDirectories());
            F.AddRange(dir.GetFiles());
            bool Info = false;

            while (true) //создаем бесконечный цикл
            {
                if (Info == false)
                {

                    for (int i = 0; i < F.Count; ++i)  //пробегаемся по длине вектора
                    {
                        if (i == index)
                        {
                            if (F[i].GetType() == typeof(DirectoryInfo))
                            {

                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Green; //kursor
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                        }

                        else
                        {
                            if (F[i].GetType() == typeof(FileInfo)) //  elementy tipa faila zapisyvaet s chernym shriftom
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.BackgroundColor = ConsoleColor.Black;
                            }
                        }
                        Console.WriteLine(F[i].Name);  // 
                    }

                }


                ConsoleKeyInfo pressedKey = Console.ReadKey(); // запоминает ввод с консоля как pressedKey
                switch (pressedKey.Key)  //выражение
                {
                    case ConsoleKey.UpArrow: //если верхнее выражение совподает со значением данного случая,
                        Console.Clear();
                        if (index > 0)  //выполняется этот блок, затем останавливается
                            index--;
                        break;
                    case ConsoleKey.DownArrow:
                    Console.Clear();
                        if (index < F.Count - 1)
                            index++;
                        break;
                    case ConsoleKey.Enter:
                        if (F[index].GetType() == typeof(FileInfo))
                        {

                            Console.Clear();
                            FileStream f = new FileStream(F[index].FullName, FileMode.OpenOrCreate, FileAccess.Read);
                            StreamReader sr = new StreamReader(f);
                            Console.Write(sr.ReadToEnd());
                            sr.Close();
                            f.Close();
                            Info = true;
                        }
                        else
                        {
                            Console.Clear();
                            path = F[index].FullName;
                            dir = new DirectoryInfo(path);
                            F.Clear();
                            F.AddRange(dir.GetDirectories());
                            F.AddRange(dir.GetFiles());
                            index = 0;
                        }



                        break;
                    case ConsoleKey.Escape:
                        Info = false;
                        Console.Clear();
                        break;

                }
            }
        }
    }
}


