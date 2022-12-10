using System;

namespace Assignment_2
{
    public class Edge
    {
        public Edge(Vertex startVertex, Vertex endVertex, float distance, float maxSpeed)
        {
            this.StartVertex = startVertex;
            this.EndVertex = endVertex;
            this.Distance = distance;
            this.MaxSpeed = maxSpeed;
            this.Time = distance / maxSpeed * 60;
        }

        private Vertex _startVertex;
        private Vertex _endVertex;

        private float _distance;
        private float _maxSpeed;
        private float _time;

        public Vertex StartVertex
        {
            get => _startVertex;
            set => _startVertex = (value ?? throw new ArgumentNullException());
        }

        public Vertex EndVertex
        {
            get => _endVertex;
            set => _endVertex = (value ?? throw new ArgumentNullException());
        }

        public float Distance
        {
            get => _distance;
            set => _distance = (value != -1 ? value : throw new ArgumentNullException());
        }

        public float MaxSpeed
        {
            get => _maxSpeed;
            set => _maxSpeed = (value != 0 ? value : throw new ArgumentNullException());
        }

        public float Time
        {
            get => _time;
            set => _time = (value != 0 ? value : throw new ArgumentNullException());
        }
    }
}
