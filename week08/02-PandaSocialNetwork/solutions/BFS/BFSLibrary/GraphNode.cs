using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSLibrary
{
    public class GraphNode<T>
    {
        T Value { get; set; }
        public List<GraphNode<T>> Neighbours { get; private set; }

        public GraphNode(T value)
        {
            Value = value;
            Neighbours = new List<GraphNode<T>>();
        }
    }
}
