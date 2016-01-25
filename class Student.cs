using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Student
    {
        public string Name;
        public int Age;
        public double GPA;
        public string ID;

        public Student(string Name, int Age, double GPA, string ID)
        {
            this.Name = Name;
            this.Age = Age;
            this.GPA = GPA;
            this.ID = ID;
        }
        public override string ToString()
        {
            return this.Name + "\n " + ID +" \n " + Age + "years old \n " + "GPA is " + GPA;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student newSt1 = new Student("Arlen Maratov" , 18 , 3.9 , "15BD02055");
            Student newSt2 = new Student ("Nurai Kim" , 17 , 4, "15BD02056" );
            Console.WriteLine(newSt1.ToString());
            Console.WriteLine(newSt2.ToString());
            Console.ReadKey();

        }
    }
}
