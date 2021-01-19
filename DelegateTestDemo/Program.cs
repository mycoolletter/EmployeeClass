using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void Procedure();

namespace DelegateTestDemo
{
    class Program
    {
        class DelegateDemo
        {
            public static void StaticMethod()
            {
                Console.WriteLine("This is Static Method delegation");
            }
            public void RegularMethod()
            {
                Console.WriteLine("This is Regular Method delegation");
            }
        }
        delegate int del(int i, int g);
        static void Main(string[] args)
        {
            Procedure someProced = null;
            someProced += new Procedure(DelegateDemo.StaticMethod);

            DelegateDemo demo = new DelegateDemo();
            someProced += new Procedure(demo.RegularMethod);
            someProced();
            del myDelegate =(x ,d)=> x * d;
            int j = myDelegate(5,2);
            Console.WriteLine(j);

        }
    }
}
