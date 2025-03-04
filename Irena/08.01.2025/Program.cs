using System;
using Unit4.CollectionsLib;

namespace _08._01._2025;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hello, World!");
    }

    static Node<RangeNode> RangeList(Node<int> list) {
        int first = list.GetValue();
        list = list.GetNext();
        Node<RangeNode> head = new Node<RangeNode>(new RangeNode(first, first));
        Node<RangeNode> tail = head;

        while (list != null) {
            int current = list.GetValue();
            RangeNode currentRange = tail.GetValue();
            if (current == currentRange.to + 1) {
                currentRange.to = current;
            } else {
                RangeNode nextRange = new RangeNode(current, current);
                tail.SetNext(new Node<RangeNode>(nextRange));
                tail = tail.GetNext();
            }
            list = list.GetNext();
        }
        return head;
    }

}
