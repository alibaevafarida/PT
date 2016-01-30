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
        private double GPA;
        private string ID;
        private bool Grant;

        public Student(string Name, int Age, double GPA, string ID, bool Grant)
        {
            this.Name = Name;
            this.Age = Age;
            this.GPA = GPA;
            this.ID = ID;
            this.Grant = Grant;
        }
        public override string ToString()
        {
            return this.Name + "\n " + ID +" \n " + Age + "years old \n " + "GPA is " + GPA;
        }
        public void  IsGrant()
        {
            if (Grant == true)
                Console.WriteLine(this.Name + " has Grant \n ");
            else
                Console.WriteLine(this.Name + " has no Grant \n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student newSt1 = new Student("Arlen Maratov" , 18 , 3.9 , "15BD02055" , false);
            Student newSt2 = new Student ("Nurai Kim" , 17 , 4, "15BD02056" , true );
            Console.WriteLine(newSt1.ToString());
            newSt1.IsGrant();
            Console.WriteLine(newSt2.ToString());
            newSt2.IsGrant();

            Console.ReadKey();

        }
    }
}
