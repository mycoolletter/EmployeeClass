using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    abstract class MyBasedClass
    {
        public void NotAbstractMethod()
        {
            Console.WriteLine("Not abstract method in abstract class");
        }
        public abstract void AbstractMethod();

    }
}
