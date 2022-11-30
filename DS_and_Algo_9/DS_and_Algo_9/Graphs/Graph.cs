using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace DS_and_Algo_9.Graphs
{
    public class Graph
    {
        private static List<Link> links = new List<Link>();

        internal static void Init()
        {
            links.Add(new Link("Sofia", "Varna"));
            links.Add(new Link("Varna", "Burgas"));
            links.Add(new Link("Varna", "Dobrich"));
            links.Add(new Link("Sofia", "Burgas"));
            links.Add(new Link("Sofia", "Tirana"));
            links.Add(new Link("Tirana", "Duras"));
            links.Add(new Link("Tirana", "Kruja"));
            links.Add(new Link("Tirana", "Elbasan"));
            links.Add(new Link("Sofia", "Bucharest"));
            links.Add(new Link("Bucharest", "Constanca"));
            links.Add(new Link("Varna", "Constanca"));
            links.Add(new Link("Bucharest", "Timishoara"));
            links.Add(new Link("Constanca", "Braila"));
            links.Add(new Link("Bucharest", "Sinaj"));
            links.Add(new Link("Timishoara", "Budapest"));
            links.Add(new Link("Budapest", "Bratislava"));
            links.Add(new Link("Bratislava", "Viena"));
            links.Add(new Link("Budapest", "Viena"));
            links.Add(new Link("Budapest", "Debrecen"));

        }

        internal static List<string> GetNeighbours(string node)
        {
            List<string> result = new List<string>();

            foreach (Link link in links)
            {
                if (link.vertex_1 == node)
                {
                    result.Add(link.vertex_2);
                }
                if (link.vertex_2 == node)
                {
                    result.Add(link.vertex_1);
                }
            }

            return result;
        }

        internal static void PrintNeighbours(string str)
        {
            foreach (var neighbour in GetNeighbours(str))
            {
                Console.WriteLine(neighbour);
            }
        }


        internal static List<String> FindPath(String start, String end, List<String> visited)
        {
            if (visited.Contains(start))
                return null;

            visited.Add(start);
            List<string> neighbors = GetNeighbours(start);

            // check if any neighbor is the end, if yes, we found a path
            foreach (String neighbor in neighbors)
            {
                if (neighbor == end)
                {
                    List<string> result = new List<String>();
                    result.Add(end);
                    result.Add(start);
                    return result;
                }
            }

            // apply recursively to all neighbors
            foreach (String neighbor in neighbors)
            {
                List<String> path = FindPath(neighbor, end, visited);
                if (path != null)
                {
                    path.Add(start);
                    return path;
                }
            }

            // no path is found through the start node
            return null;
        }

        internal static List<string> BFS(string start, string end, List<string> visited)
        {
            if (visited.Contains(start)) return null;
            visited.Add(start);

            Queue<string> queue = new Queue<string>();

            queue.Enqueue(start);

            List<string> neighbours = GetNeighbours(start);

            while (queue.Count != 0)
            {
                string v = queue.Dequeue();

                if (v == end) break;
                else
                {
                    foreach (var neighbour in neighbours)
                    {
                        List<String> path = FindPath(neighbour, end, visited);
                        if (path != null)
                        {
                            path.Add(start);
                            return path;
                        }
                    }
                }
            }

            return null;
        }
    }
}
