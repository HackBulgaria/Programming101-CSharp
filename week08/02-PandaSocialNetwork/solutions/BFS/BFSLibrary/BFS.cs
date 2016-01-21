using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSLibrary
{
    public static class BFS
    {
        public static List<GraphNode<T>> FindConnections<T>(GraphNode<T> startNode)
        {
            var visited = new List<GraphNode<T>>();
            var queue = new Queue<GraphNode<T>>();

            visited.Add(startNode);
            queue.Enqueue(startNode);

            while(queue.Count > 0)
            {
                var node = queue.Dequeue();

                foreach(var neighbour in node.Neighbours)
                {
                    if(!visited.Contains(neighbour))
                    {
                        visited.Add(neighbour);
                        queue.Enqueue(neighbour);
                    }
                }
            }

            return visited;
        }

        public static int FindConnectionLevel<T>(GraphNode<T> startNode, GraphNode<T> endNode)
        {
            var visited = new List<GraphNode<T>>();
            var queue = new Queue<GraphNodeWithLevel<T>>();

            visited.Add(startNode);
            queue.Enqueue(new GraphNodeWithLevel<T>()
            {
                Node = startNode,
                Level = 0
            });

            while (queue.Count > 0)
            {
                var nodeWithLevel = queue.Dequeue();

                if(nodeWithLevel.Node == endNode)
                {
                    return nodeWithLevel.Level;
                }

                foreach (var neighbour in nodeWithLevel.Node.Neighbours)
                {
                    if (!visited.Contains(neighbour))
                    {
                        visited.Add(neighbour);
                        queue.Enqueue(new GraphNodeWithLevel<T>()
                        {
                            Node = neighbour,
                            Level = nodeWithLevel.Level + 1
                        });
                    }
                }
            }

            return -1;
        }

        private class GraphNodeWithLevel<T>
        {
            public GraphNode<T> Node { get; set; }
            public int Level { get; set; }
        }
    }
}
