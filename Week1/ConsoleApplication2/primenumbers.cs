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
            string numb; //создаем строку в которой записаны числа(через пробел)
            numb = Console.ReadLine();// считываем с консоли эту строку
            string[] data = numb.Split(); // создаем отдельный массив data в котором сохраняем числа как элементы(отделяя их Split()
            foreach (string a in data) // по циклу каждый элемент массива data записывается как а;
            {
                int cnt = 0;  // при каждом новом элементе счетчик = 0
                for(int i=1; i<=Convert.ToInt16(a); i++) { // создаем цикл от 1 до самого числа а (конвертируем в инт потому что он изначально явл строкой
                    if (Convert.ToInt32(a) % i == 0) // если а кратно 1 и себе
                    {
                        cnt++; // счетчик прибавляется
                    }
                }
                if (cnt == 2) // если а простое 
                {
                    Console.WriteLine(a); // выводим на экран а
                }
           }
            Console.ReadKey(); // позволяет видеть наш вывод 



        }
    }
}
