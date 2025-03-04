using System;
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

    public static Node<int> IntersectionSorted(this Node<int> first, Node<int> second) {
        Node<int> head = new Node<int>(0);
        Node<int> tail = head;
        while (first != null && second != null) {
            int firstValue = first.GetValue();
            int secondValue = second.GetValue();

            if (firstValue == secondValue) {
                tail.SetNext(new Node<int>(first.GetValue()));
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
        if (end == 0) { return $"({node.GetValue()})"; }
        string rest = StringFromTo(node.GetNext(), 0, end - 1);
        return $"({node.GetValue()}, {rest})";
    }

    public static void Reverse<T>(ref Node<T> node) {
        Node<T> previous = null;
        Node<T> current = node;
        while (current != null) {
            Node<T> next = current.GetNext();
            current.SetNext(previous);
            previous = current;
            current = next;
        }
        node = current;
    }

    public static bool IsSorted(this Node<int> node) {
        if (node == null) return true;
        if (node.GetNext() == null) return true;

        Node<int> next = node.GetNext();
        if (next.GetValue() > node.GetValue()) return next.IsAscending();
        if (next.GetValue() < node.GetValue()) return next.IsDescending();
        return true;
    }

    public static bool IsAscending(this Node<int> node) {
        if (node == null) return true;
        if (node.GetNext() == null) return true;

        Node<int> next = node.GetNext();
        if (next.GetValue() >= node.GetValue()) return next.IsAscending(); else return false;
    }

    public static bool IsDescending(this Node<int> node) {
        if (node == null) return true;
        if (node.GetNext() == null) return true;

        Node<int> next = node.GetNext();
        if (next.GetValue() <= node.GetValue()) return next.IsDescending(); else return false;
    }

    public static void InsertSorted(ref Node<int> node, int value) {
        if (node == null) return;

        if (node.GetValue() >= value) {
            Node<int> temp = new Node<int>(value, node);
            node = temp;
            return;
        }
        Node<int> next = node.GetNext();

        if (next == null || next.GetValue() >= value) {
            node.SetNext(new Node<int>(value, next));
            return;
        }
        InsertSorted(ref next, value);

    }

    public static Node<int> NewSorted(this Node<int> node) {
        Node<int> temp = new Node<int>(node.GetValue());
        node = node.GetNext();
        while (node != null) {
            InsertSorted(ref temp, node.GetValue());
            node = node.GetNext();
        }
        return temp;
    }

    public static void RemoveDuplicates(this Node<int> node) {
        Node<int> next = node.GetNext();
        if (next == null) return;
        if (next.GetValue() == node.GetValue()) {
            node.SetNext(next.GetNext());
            RemoveDuplicates(node);
        } else {
            RemoveDuplicates(next);
        }
    }

    public static Node<int> WithoutDuplicates(this Node<int> node) {
        int lastValue = node.GetValue();
        Node<int> list = new Node<int>(lastValue);
        node = node.GetNext();

        while (node != null) {
            int nextValue = node.GetValue();
            if (nextValue != lastValue) {
                list.SetNext(new Node<int>(nextValue));
            }
            node = node.GetNext();
        }
        return list;
    }

    public static Node<int> JoinWith(this Node<int> node1, Node<int> node2) {
        if (node1.IsAscending()) {
            return node1.JoinWithAscending(node2);
        }
        return node1.JoinWithDescending(node2);
    }

    public static Node<int> JoinWithAscending(this Node<int> node1, Node<int> node2) {
        Node<int> head;
        if (node1.GetValue() <= node2.GetValue()) {
            head = new Node<int>(node1.GetValue());
            node1 = node1.GetNext();
        } else {
            head = new Node<int>(node2.GetValue());
            node2 = node1.GetNext();
        }
        Node<int> returned = head;

        while (node1 != null && node2 != null) {
            if (node1 != null && (node2 != null || node1.GetValue() <= node2.GetValue())) {
                head.SetNext(new Node<int>(node1.GetNext().GetValue()));
                head = head.GetNext();
                node1 = node1.GetNext();
            } else {
                head.SetNext(new Node<int>(node2.GetNext().GetValue()));
                head = head.GetNext();
                node2 = node2.GetNext();
            }
        }
        return returned;
    }
    public static Node<int> JoinWithDescending(this Node<int> node1, Node<int> node2) {
        Node<int> head;
        if (node1.GetValue() >= node2.GetValue()) {
            head = new Node<int>(node1.GetValue());
            node1 = node1.GetNext();
        } else {
            head = new Node<int>(node2.GetValue());
            node2 = node1.GetNext();
        }
        Node<int> returned = head;

        while (node1 != null && node2 != null) {
            if (node1 != null && (node2 != null || node1.GetValue() >= node2.GetValue())) {
                head.SetNext(new Node<int>(node1.GetNext().GetValue()));
                head = head.GetNext();
                node1 = node1.GetNext();
            } else {
                head.SetNext(new Node<int>(node2.GetNext().GetValue()));
                head = head.GetNext();
                node2 = node2.GetNext();
            }
        }
        return returned;
    }

    public static bool Contains<T>(this Node<T> node, Func<Node<T>, bool> predicate) {
        for (; node is not null; node = node.GetNext()) {
            if (predicate(node)) {
                return true;
            }
        }
        return false;
    }
    public static bool Contains<T>(this Node<T> node, T target)
    where T : IEquatable<T> {
        return node.Contains(p => p.GetValue().Equals(target));
    }

    public static Node<int> Intersection(this Node<int> node, Node<int> other) {
        Node<int> head = new Node<int>(0);
        Node<int> tail = head;

        while (node is not null) {
            if (other.Contains(p => p.GetValue() == node.GetValue())) {
                tail.SetNext(new Node<int>(node.GetValue()));
                tail = tail.GetNext();
                node = node.GetNext();
            }
        }
        head = head.GetNext();
        return head;
    }
}
