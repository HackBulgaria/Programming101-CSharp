using BFSLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = GetGraph();

            var connections = BFS.FindConnections(graph[0]);
            var level = BFS.FindConnectionLevel(graph[0], graph[4]);
        }

        private static List<GraphNode<string>> GetGraph()
        {
            var node1 = new GraphNode<string>("node1");
            var node2 = new GraphNode<string>("node2");
            var node3 = new GraphNode<string>("node3");
            var node4 = new GraphNode<string>("node4");
            var node5 = new GraphNode<string>("node5");
            var node6 = new GraphNode<string>("node6");
            var node7 = new GraphNode<string>("node6");

            node1.Neighbours.Add(node3);

            node2.Neighbours.Add(node3);
            node2.Neighbours.Add(node4);

            node3.Neighbours.Add(node1);
            node3.Neighbours.Add(node2);
            node3.Neighbours.Add(node4);

            node4.Neighbours.Add(node2);
            node4.Neighbours.Add(node3);
            node4.Neighbours.Add(node5);

            node5.Neighbours.Add(node4);
            node5.Neighbours.Add(node6);
            node5.Neighbours.Add(node7);

            node6.Neighbours.Add(node5);

            node7.Neighbours.Add(node5);

            return new List<GraphNode<string>>()
            {
                node1, node2, node3, node4, node5, node6, node7
            };
        }
    }
}
