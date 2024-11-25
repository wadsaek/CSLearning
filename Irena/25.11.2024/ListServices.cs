using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using Unit4.CollectionsLib;

namespace Library;

public static class ListServices
{
    public static Node<T> BuildList<T>(this T[] arr)
    {
        Node<T> head = new Node<T>(arr[0]);
        Node<T> tail = head;
        for (int i = 1; i < arr.Length; i++)
        {
            tail.SetNext(new Node<T>(arr[i]));
            tail = tail.GetNext();
        }
        return head;
    }

    public static Node<T> Insert<T>(this Node<T> p, T value)
    {
        if(p == null)
        {
            return new Node<T>(value);
        }
        Node<T> next = p.GetNext();
        Node<T> newNode = new Node<T>(value);
        p.SetNext(newNode);
        newNode.SetNext(next);
        return newNode;
    }

    public static string ToStringRecursive<T>(this Node<T> head)
    {
        string rest;
        if (head.GetNext() != null)
        {
            rest = head.GetNext().ToStringRecursive();
        }
        else
        {
            rest = "\b\b";
        }
        return $"({head}, {rest})";
    }

    public static void Delete<T>(this Node<T> p, Node<T> target)
    {
        if(p.GetNext() == target)
        {
            p.SetNext(target.GetNext());
            return;
        }
        Delete(p.GetNext(), target);
    }


}
