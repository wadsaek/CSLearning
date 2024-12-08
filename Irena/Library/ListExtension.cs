using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using Unit4.CollectionsLib;

namespace Library;

public static class ListExtension {
    public static Node<T> BuildList<T>(this T[] arr) {
        Node<T> head = new Node<T>(arr[0]);
        Node<T> tail = head;
        for (int i = 1; i < arr.Length; i++) {
            tail.SetNext(new Node<T>(arr[i]));
            tail = tail.GetNext();
        }
        return head;
    }

    public static Node<T> Insert<T>(this Node<T> p, T value) {
        if (p == null) {
            return new Node<T>(value);
        }
        Node<T> next = p.GetNext();
        Node<T> newNode = new Node<T>(value);
        p.SetNext(newNode);
        newNode.SetNext(next);
        return newNode;
    }

    public static string ToStringRecursive<T>(this Node<T> head) {
        string rest = head.GetNext() != null
            ? head.GetNext().ToStringRecursive()
            : "\b\b";

        return $"({head}, {rest})";
    }

    public static void Delete<T>(this Node<T> p, Node<T> target) {
        if (p.GetNext() == target) {
            p.SetNext(target.GetNext());
            return;
        }
        Delete(p.GetNext(), target);
    }

    public static Node<T> Previous<T>(this Node<T> list, Node<T> target) {
        if (list.GetNext() == null) return null;
        if (list.GetNext() == target) return list;

        return Previous(list.GetNext(), target);
    }

    public static int LengthToNull<T>(this Node<T> list) {
        if (list.GetNext() == null) return 0;
        return LengthToNull(list.GetNext()) + 1;
    }

    public static Node<int> Intersection(this Node<int> first, Node<int> second) {
        Node<int> head = new Node<int>(0);
        Node<int> tail = head;
        while (first != null && second != null) {
            int firstValue = first.GetInfo();
            int secondValue = second.GetInfo();

            if (firstValue == secondValue) {
                tail.SetNext(new Node<int>(first.GetInfo()));
                tail = tail.GetNext();

                first = first.GetNext();
                second = second.GetNext();
            } else if (firstValue > secondValue) {
                second = second.GetNext();
            } else {
                first = first.GetNext();
            }
        }
        return head.GetNext();
    }

    public static string StringFromTo(this Node<int> node, int start, int end) {
        if (start != 0) {
            return StringFromTo(node.GetNext(), start - 1, end - 1);
        }
        if (end == 0) { return $"({node.GetInfo()})"; }
        string rest = StringFromTo(node.GetNext(), 0, end - 1);
        return $"({node.GetInfo()}, {rest})";
    }
}
