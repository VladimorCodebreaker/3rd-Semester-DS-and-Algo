using System;

namespace DS_and_Algo_3_Homework
{
    internal class Department : IName, ICount
    {
        public Department(string name, int numberOfEmployees, string manager)
        {
            Name = name;
            NumberOfEmployees = numberOfEmployees;
            Manager = new(manager);
        }

        private string _name;

        public string Name
        {
            get => _name;
            set => _name = (value ?? throw new ArgumentNullException());
        }

        public int NumberOfEmployees { get; set; }
        public Manager Manager { get; set; }
    }

    internal class Manager : IName
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = (value ?? throw new ArgumentNullException());
        }

        public Manager(string name)
        {
            Name = name;
        }
    }
}