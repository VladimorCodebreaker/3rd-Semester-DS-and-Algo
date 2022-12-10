using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Assignment_2
{
    public class Graph
    {
        private static Dictionary<Vertex, List<Edge>> _adjacencyList = new();
        private static Dictionary<Vertex, Vertex> _outerPrint;

        internal static void AddEdge(Vertex startVertex, Vertex endVertex, float distance, float maxSpeed)
        {
            if (_adjacencyList.ContainsKey(startVertex)) _adjacencyList[startVertex].Add(new Edge(startVertex, endVertex, distance, maxSpeed));
            else _adjacencyList.Add(startVertex, new List<Edge> { new Edge(startVertex, endVertex, distance, maxSpeed) });

            if (_adjacencyList.ContainsKey(endVertex)) _adjacencyList[endVertex].Add(new Edge(endVertex, startVertex, distance, maxSpeed));
            else _adjacencyList.Add(endVertex, new List<Edge> { new Edge(endVertex, startVertex, distance, maxSpeed) });
        }

        internal static void RemoveEdge(Vertex startVertex, Vertex endVertex)
        {
            if (_adjacencyList.ContainsKey(startVertex)) _adjacencyList.Remove(startVertex);
            if (_adjacencyList.ContainsKey(endVertex)) _adjacencyList.Remove(endVertex);
        }

        internal static Vertex GetVertex(string vertex)
        {
            return _adjacencyList.FirstOrDefault(v => v.Key.Name.Contains(vertex)).Key;
        }

        internal static float QuickestPath(Vertex startVertex, Vertex endVertex)
        {
            var quickestPath = DijkstrasQuickestPath(startVertex);
            return quickestPath[endVertex];
        }

        private static Dictionary<Vertex, float> DijkstrasQuickestPath(Vertex startVertex)
        {
            List<Node> pq = new List<Node>(_adjacencyList.Keys.Count);
            Dictionary<Vertex, Node> map = new();
            Dictionary<Vertex, float> costs = new();
            Dictionary<Vertex, Vertex> ancestors = new();
            HashSet<Vertex> dq = new();

            foreach (var vertex in _adjacencyList.Keys)
            {
                var node = new Node(vertex, 0);

                if (vertex.Name == startVertex.Name)
                {
                    map.Add(vertex, node);
                    pq.Add(node);
                }
                else
                {
                    node.Priority = int.MaxValue;
                    map.Add(vertex, node);
                    pq.Add(node);
                }
            }

            costs.Add(startVertex, 0);
            ancestors.Add(startVertex, null);

            while (pq.Count > 0)
            {
                pq.Sort((a, b) => a.Priority.CompareTo(b.Priority));

                var temp = pq[0];
                pq.RemoveAt(0);
                var current = temp.Vertex;
                var cost = temp.Priority;

                dq.Add(current);

                if (!costs.TryAdd(current, cost)) costs[current] = cost;

                foreach (var edge in _adjacencyList[current])
                {
                    var adj = edge.StartVertex.Name == current.Name ? edge.EndVertex : edge.StartVertex;

                    if (dq.Contains(adj)) continue;

                    float calcCost = costs[current] + edge.Time;
                    var adjNode = map[adj];
                    int adjCost = adjNode.Priority;

                    if (calcCost < adjCost)
                    {
                        map[adj].Priority = (int)calcCost;
                        pq.Find(n => n == adjNode).Priority = (int)calcCost;

                        if (!ancestors.TryAdd(adj, current)) ancestors[adj] = current;
                    }
                }
            }

            _outerPrint = ancestors;

            return costs;
        }

        internal static void PrintQuickestPath(Vertex startVertex, Vertex endVertex)
        {
            var path = DijkstrasQuickestPath(startVertex);
            PrintPath(endVertex, _outerPrint, path);
        }

        private static void PrintPath(Vertex vertex, Dictionary<Vertex, Vertex> ancestors, Dictionary<Vertex, float> path)
        {
            if (vertex == null || !ancestors.ContainsKey(vertex)) return;

            PrintPath(ancestors[vertex], ancestors, path);
            Console.Write($" -- ({path[vertex]}) min --> {vertex.Name}");
        }
    }
}
