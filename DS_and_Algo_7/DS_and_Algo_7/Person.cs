using System;

namespace DS_and_Algo_7
{
    public class Person
    {
        private string _name;
        private char _gender;

        public string Name
        {
            get => _name;
            set => _name = (value ?? throw new ArgumentNullException());
        }

        public char Gender
        {
            get => _gender;
            set => _gender = (value);
        }

        public List<Person> Children = new List<Person>();
    }
}
