using System;
using System.Collections.Generic;
using System.Text;

namespace some_test
{
    class Employee
    {
        public String name { get; set; }
        public String age { get; set; }
        public String salary { get; set; }
        public Employee(string name, string age, string salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
        public Employee()
        {

        }

        public void Input()
        {
            Console.WriteLine("In put your Employee");
            Console.WriteLine("In put name ");
             name = Console.ReadLine();
            Console.WriteLine("In put age");
            age = Console.ReadLine();
            Console.WriteLine("In put salary");
            salary = Console.ReadLine();
        }
       
       

    }
}
