using System;
using System.Net;

namespace Assignment_1
{
    internal class Employee
    {
        public Employee(string name, int empID)
        {
            Name = name;
            EmployeeID = empID;
        }

        private string _name;
        private int _empID;

        public string Name
        {
            get => _name;
            set => _name = (value ?? throw new ArgumentNullException());
        }

        public int EmployeeID
        {
            get => _empID;
            set => _empID = (value != 0 ? value : throw new ArgumentNullException());
        }

        public override string ToString()
        {
            return $"\n-------- Employee ---->  [ {Name} ] \n" +
                $"ID Number: {_empID}\n";
        }
    }
}
