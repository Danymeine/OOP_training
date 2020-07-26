using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class A
    {
        private int a;
        private int b;
        public int c

        {
            get { return a * b; }
            set { a = value; }
        }
        public A() { a = 6; b = 10; }

    }
    class B : A
    {
        private int d;
        public int c2
        {
            get { return c * ; }
            set {  = value; }
        }
        public B(int m) : base() { c = m }
        public B() : this() {d = }
    }
}
