using System;
using Unit4.CollectionsLib;

namespace Library {
    internal class Program {
        static void Main(string[] args) {
            int[] a = [6,4,3,56,2,6];
            var b = ListExtension.BuildList(a);
            Console.WriteLine(b.ToStringRecursive());
            Spend(b);
            Console.WriteLine(b.ToStringRecursive());

        }
        static void Spend(Node<int> node){
            while(node is not null)
                node = node.GetNext();
        }
    }
}

namespace NotLibrary{
    internal class Huh{
        static void Run(){
            Queue<int> q = new Queue<int>();
        }
    }
}
