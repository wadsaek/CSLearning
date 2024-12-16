using System;
using Unit4.CollectionsLib;

namespace Library {
    internal class Program {
        static void Main(string[] args) {
            int[] arr = { 1, 68, 2, 56, 2, 5, 2, 54, 56, 76, 80 };
            int[] arr2 = { 1, 4, 54, 80 };
            Node<int> node = arr.BuildList();
            Console.WriteLine(node.ToStringRecursive());

            node = node.NewSorted();
            Console.WriteLine(node.ToStringRecursive());

            Console.WriteLine("new sorted array:");
            Console.WriteLine(node.ToStringRecursive());


            Node<int>sortedNewWithout = node.WithoutDuplicates();
            Console.WriteLine(sortedNewWithout.ToStringRecursive());

            node.RemoveDuplicates();
            Console.WriteLine(node.ToStringRecursive());
        }
    }
}
