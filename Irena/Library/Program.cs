using System;
using Unit4.CollectionsLib;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 54, 2, 6 };
            Node<int> node = arr.BuildList();
            Console.WriteLine(node.ToStringRecursive());
            node.Delete(node.GetNext().GetNext());
            Console.WriteLine("delete third element");
            Console.WriteLine(node.ToStringRecursive());
            Console.WriteLine(node.Previous(node.GetNext().GetNext().GetNext()).ToStringRecursive());
        }
    }
}
