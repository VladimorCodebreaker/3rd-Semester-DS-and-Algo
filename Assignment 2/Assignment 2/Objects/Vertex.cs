using System;

namespace Assignment_2
{
    public class Vertex
    {
        public Vertex(string name)
        {
            this.Name = name;
        }

        private string _name;

        public string Name
        {
            get => _name;
            set => _name = (value ?? throw new ArgumentNullException());
        }
    }
}
