using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)

        {
           
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fr = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string[] numb = sr.ReadLine().Split();
            List<int> prime = new List<int>();

                int cnt = 0;
                for (int i = 0; i < numb.Length; i++)
                {
                    cnt = 0;
                    int a= int.Parse(numb[i]);
                    for(int j=1; j<=a; j++) {
                         if (a % j == 0)
                         {
                             cnt++;
                          }
                    }
                    if (cnt == 2)
                    {
                        prime.Add(a);
                    }
                }
                    int min = prime[0];
                    foreach (int k in prime)
                    {
                        if (k < min)
                        {
                            min = k;
                        }
                    }
                    StreamWriter sw = new StreamWriter(fr);
                    sw.WriteLine(min);
                    sw.Close();
                    fs.Close();
                    fr.Close();
                    sr.Close();
                    Console.WriteLine("the minimum is {0}", min);
               Console.ReadKey();
            }
           
        }

    
}
