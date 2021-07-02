using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BreadthFirstSearch
{
    public static class BreadthFirstSearch
    {
        public static IList<int> Execute(GraphNode root)
        {
            List<int> output = new();
            List<GraphNode> queued = new() { root };

            while (queued.Count > 0)
            {
                var curr = queued[0];
                curr.State = GraphNodeState.Closed;
                queued.RemoveAt(0);
                foreach (var child in curr.Childs)
                {
                    if (child.State == GraphNodeState.Open)
                    {
                        queued.Add(child);
                        child.State = GraphNodeState.Queued;
                    }
                }
                
                output.Add(curr.Value);
            }
            return output;
        }
    }

    public enum GraphNodeState
    {
        Open,
        Queued,
        Closed
    }

    public class GraphNode
    {
        public int Value { get; set; }
        public IEnumerable<GraphNode> Childs { get; set; }
        public GraphNodeState State { get; set; } = GraphNodeState.Open;

        public GraphNode(int value, IEnumerable<GraphNode> childs = null)
        {
            Value = value;
            Childs = childs ?? new List<GraphNode>();
        }
    }
}
