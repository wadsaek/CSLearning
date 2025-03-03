using System;
using Unit4.CollectionsLib;
namespace Library;

public static class QueueExtension {
    public static bool IsIn(this Queue<int> queue, int target) {
        if (queue.IsEmpty()) return false;
        if (queue.Head() == target) return true;

        queue.Remove();
        return IsIn(queue, target);
    }

    public static Queue<T> Clone<T>(this Queue<T> queue) {
        Queue<T> newQueue = new Queue<T>();
        Queue<T> copy = new Queue<T>();
        while (!queue.IsEmpty()) {
            T num = queue.Remove();
            newQueue.Insert(num);
            copy.Insert(num);
        }

        while (!copy.IsEmpty()) {
            queue.Insert(copy.Remove());
        }
        return newQueue;
    }

    public static bool IsABA(this Queue<char> queue) {
        Queue<char> clone = queue.Clone();
        int len = 0;
        while (!clone.IsEmpty()) {
            len++;
            clone.Remove();
        }

        if (len % 3 != 0) return false;
        var stack = new System.Collections.Generic.List<char>(len / 3);
        for (int i = 0; i < len / 3; i++) {
            char ch = queue.Remove();
            stack.Add(ch);
            clone.Insert(ch);
        }
        for (int i = 0; i < len / 3; i++) {
            char lastInStack = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            if (lastInStack != queue.Remove()) return false;
        }
        for (int i = 0; i < len / 3; i++) {
            if (queue.Remove() != clone.Remove()) return false;
        }
        return true;
    }

    public static Queue<T> Merge<T>(this Queue<T> queue, Queue<T> other)
    where T : IComparable {
        var clone1 = queue.Clone();
        var clone2 = other.Clone();
        var newQueue = new Queue<T>();

        while (!clone1.IsEmpty() && !clone2.IsEmpty()) {
            if (clone1.Head().CompareTo(clone2.Head()) < 0)
                newQueue.Insert(clone1.Remove());
            else
                newQueue.Insert(clone2.Remove());
        }

        Queue<T> notEmptyQueue = clone2.IsEmpty() ? clone1 : clone2;
        while (!notEmptyQueue.IsEmpty()) {
            newQueue.Insert(notEmptyQueue.Remove());
        }

        return newQueue;
    }
}
