using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Employee firstEmployee = new Employee("Ihor", "Dzhemesiuk", DateTime.Now, "Unemployed", "Study", 2500);
            
            Assert.AreEqual("Ihor Dzhemesiuk", firstEmployee.GetFullName());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Employee firstEmployee = new Employee("Ihor", "Dzhemesiuk", DateTime.Now, "Unemployed", "Study", 2500);
            Console.WriteLine(firstEmployee);



            int number1 = 0;

            while (number1 < 3)
            {
                int number2 = 10;
                while (number2 > 5)
                {
                    Console.WriteLine($"Outer{number1}\tInner {number2}");

                    number2--;
                }

                number1++;

            }
            Assert.AreEqual("Dzhemesiuk,Ihor", firstEmployee.GetNameForSorting());
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<int> myList = new List<int>() { 1, 2, 3 };
            myList.Add(Convert.ToInt32("9"));
            myList.Add(3);
            myList.Add(3);
            myList.Add(3);
            myList.Add(3);
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(myList.Count);
            Console.WriteLine(myList.Capacity);
            ArrayList my = new ArrayList();
        }

        [TestMethod]
        public void TestMethod4()
        {
            Employee firstEmployee = new Employee("Ihor", "Dzhemesiuk", DateTime.Now, "Unemployed", "Study", 2500);
            firstEmployee.AbstractMethod();
            firstEmployee.NotAbstractMethod();
            firstEmployee.ToString();
        }


    }
}

