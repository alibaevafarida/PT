using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryTree(@"C:\Users\Farida\Desktop\PT_labs\testfolder");


        }
        static void DirectoryTree(string path)
        {
            Stack<string> st = new Stack<string>();
            Console.WriteLine("In folder with path: " + path  + " there are " + Directory.GetFiles(path).Length + "files");
            st.Push(path);

            while (st.Count > 0)
            {
                string[] subfolders = Directory.GetDirectories(st.Pop());
                foreach (string s in subfolders)
                {
                    Console.WriteLine("In Folder with path :" + s + " there is" + Directory.GetFiles(s).Length + " file");
                    st.Push(s);
                    Console.ReadKey();
                }
            }
        }
    
   }
}
