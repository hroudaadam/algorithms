using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DepthFirstSearch
{
    public static class DepthFirstSearch
    {
        public static IList<int> Execute(GraphNode rootNode)
        {
            List<int> output = new List<int>();

            if (rootNode.State == GraphNodeState.Open)
            {
                output.Add(rootNode.Value);
            }
            rootNode.State = GraphNodeState.Progress;

            foreach (var child in rootNode.Childs)
            {
                if (child.State == GraphNodeState.Open)
                {
                    output.AddRange(Execute(child));
                }
            }

            rootNode.State = GraphNodeState.Closed;
            return output;
        }
    }

    public enum GraphNodeState
    {
        Open,
        Progress,
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
