using System;
using Unit4.CollectionsLib;

namespace Library {
    internal class Program {
        static void Main(string[] args) {
            int[] arr = { 1, 2, 54, 76, 80 };
            int[] arr2 = { 1, 4, 54, 80 };
            Node<int> node = arr.BuildList();
            Console.WriteLine(node.ToStringRecursive());
            node.Delete(node.GetNext().GetNext());
            Console.WriteLine("delete third element");
            Console.WriteLine(node.ToStringRecursive());


            Console.WriteLine(arr.BuildList().StringFromTo(1, 3));
            Console.WriteLine(node.Previous(node.GetNext().GetNext().GetNext()).ToStringRecursive());

            Console.WriteLine(arr.BuildList().Intersection(arr2.BuildList()).ToStringRecursive());
        }
    }
}
