using System;

namespace Assignment_1
{
    internal class Manager
    {
        public Manager(string name)
        {
            Name = name;
        }

        private string _name;

        public string Name
        {
            get => _name;
            set => _name = (value ?? throw new ArgumentNullException());
        }
    }
}
