using System;
using System.Collections.Generic;
using System.Text;

namespace some_test
{
    class ListEmployee
    {
        List<Employee> list = new List<Employee>();
        public void InputEmployee()
        {
            Employee emp = new Employee();
            emp.Input();
            list.Add(emp);
        }
    }
}
