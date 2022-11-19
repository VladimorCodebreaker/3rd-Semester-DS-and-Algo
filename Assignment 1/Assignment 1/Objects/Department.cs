using System;

namespace Assignment_1
{
    internal class Department
    {
        public Department(string name, string manager, List<Employee> listOfEmployees)
        {
            Name = name;
            Manager = new(manager);
            ListOfEmployees = new(listOfEmployees);
        }

        private string _name;

        public string Name
        {
            get => _name;
            set => _name = (value ?? throw new ArgumentNullException());
        }

        public List<Employee> ListOfEmployees { get; set; }
        public List<Department> ListOfDepartments { get; set; }
        public Manager Manager { get; set; }

        public override string ToString()
        {
            return $"\n-------- Department ---->  [ {Name} ] \n" +
                $"Manager: {Manager.Name} \n" +
                $"Number of Employees: {ListOfEmployees.Count + 1} \n" +
                $"Number of Departments: {ListOfDepartments.Count}";
        }
    }
}
