using System;
using System.Collections.Generic;
using System.Linq;
//using ConsoleApp.BreadthFirstSearch;
//using BFS = ConsoleApp.BreadthFirstSearch;
//using BS = ConsoleApp.BubbleSort;
using SS = ConsoleApp.SelectionSort;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Linear search
            //List<int> items = new() { 5, 2, 3, 7, 9, 10, 2, 1, 7, 8 };
            //int indexOf = LinearSearch.Execute(items, 7);
            //Console.WriteLine(indexOf);
            #endregion

            #region Binary search
            //List<int> items = new() { 1, 5, 8, 11, 15, 19, 24, 29, 33, 36, 39, 40, 44, 85, 95, 97};
            //int indexOf = BinarySearch.Execute(items, 19);
            //Console.WriteLine("\nSearched value is on index " + indexOf);
            //indexOf = BinarySearch.ExecuteRecursive(items, 19);
            //Console.WriteLine("\nSearched value is on index " + indexOf);
            #endregion

            #region Depth first search
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

            #region Breadth first search
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

            #region Bubble sort
            List<int> list = new() { 9, 8, 7, 5, 3, 5, 2, 4, 1 };
            SS.SelectionSort.Execute(list);
            Console.WriteLine(string.Join(", ", list));
            #endregion

            Console.ReadLine();
        }
    }
}
