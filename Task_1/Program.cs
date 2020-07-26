using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.c);
            a.c = 10;
            Console.WriteLine(a.c);
            B b = new B();
            Console.WriteLine(a.c);
            a.c = 10;
            Console.WriteLine(a.c);
            Console.ReadLine();
        }
    }
}
