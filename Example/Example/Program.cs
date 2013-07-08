using Cheng.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Dijsktra.Graph("Graph Name");

            graph.AddNode(new Dijsktra.Graph.Vertex("node 1", 0, 0));
            graph.AddNode(new Dijsktra.Graph.Vertex("node 2", 3, 2));
            graph.AddNode(new Dijsktra.Graph.Vertex("node 3", 2, 5));
            graph.AddNode(new Dijsktra.Graph.Vertex("node 4", 5, 3));
            graph.AddEdge("node 1", "node 2", 3);
            graph.AddEdge("node 1", "node 3", 4);
            graph.AddEdge("node 2", "node 3", 2);
            graph.AddEdge("node 2", "node 4", 1);
            graph.AddEdge("node 3", "node 4", 1);

            var shortestPath = new Dijsktra();
            shortestPath.analyze(graph, "node 1", "node 4");

            Console.WriteLine("Shortest path: {0}\nTotal Distant: {1}", string.Join(" -> ", shortestPath.Path.Select(p=>p.Name).ToList()), shortestPath.Min);

            Console.ReadKey();
        }
    }
}
