using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexF
{
    class Complex
    {
        public int a, b;

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            int k = c1.b * c2.b; //bolim
            int s = c1.b * c2.a + c2.b * c1.a;  //alym
            if (k > s)
            {
                for (int i = s; i > 1; i--)
                {
                    if (k % i == 0 && s % i == 0)
                    {
                        k /= i;
                        s /= i;
                        break;
                    }
                }
            }
            else {
                for (int i = k; i > 1; i--)
                {
                    if (k % i == 0 && s % i == 0)
                    {
                        k /= i;
                        s /= i;
                        break;
                    }
                }
            }
            Complex c3 = new Complex(s, k);
            return c3;
        }

       


        class Program
        {
            static void Main(string[] args)
            {
                Complex c = new Complex(3, 6);
                Complex d = new Complex(2, 3);
                Complex w = c + d;
                Console.WriteLine(w);
                Console.ReadKey();
            }
        }
    }
}
