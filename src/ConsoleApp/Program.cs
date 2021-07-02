using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp.BreadthFirstSearch;
using BFS = ConsoleApp.BreadthFirstSearch;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinearSearch
            //List<int> items = new() { 5, 2, 3, 7, 9, 10, 2, 1, 7, 8 };
            //int indexOf = LinearSearch.Execute(items, 7);
            //Console.WriteLine(indexOf);
            #endregion

            #region BinarySearch
            //List<int> items = new() { 1, 5, 8, 11, 15, 19, 24, 29, 33, 36, 39, 40, 44, 85, 95, 97};
            //int indexOf = BinarySearch.Execute(items, 19);
            //Console.WriteLine("\nSearched value is on index " + indexOf);
            //indexOf = BinarySearch.ExecuteRecursive(items, 19);
            //Console.WriteLine("\nSearched value is on index " + indexOf);
            #endregion

            #region DepthFirstSearch
            //GraphNode root = new GraphNode(1, new List<GraphNode>()
            //{
            //    new GraphNode(2, new List<GraphNode>() 
            //    { 
            //        new GraphNode(3),
            //        new GraphNode(4)
            //    }),
            //    new GraphNode(5, new List<GraphNode>() 
            //    {
            //        new GraphNode(6, new List<GraphNode>()
            //        {
            //            new GraphNode(7),
            //            new GraphNode(8)
            //        }),
            //        new GraphNode(9)
            //    })
            //});

            //IList<int> output = DepthFirstSearch.Execute(root);
            //Console.WriteLine(string.Join(", ", output));

            #endregion

            #region BreadthFirstSearch
            //GraphNode root = new GraphNode(1, new List<GraphNode>()
            //{
            //    new GraphNode(2, new List<GraphNode>()
            //    {
            //        new GraphNode(3),
            //        new GraphNode(4)
            //    }),
            //    new GraphNode(5, new List<GraphNode>()
            //    {
            //        new GraphNode(6, new List<GraphNode>()
            //        {
            //            new GraphNode(7),
            //            new GraphNode(8)
            //        }),
            //        new GraphNode(9)
            //    })
            //});

            //IList<int> output = BFS.BreadthFirstSearch.Execute(root);
            //Console.WriteLine(string.Join(", ", output));

            #endregion

            Console.ReadLine();
        }
    }
}
