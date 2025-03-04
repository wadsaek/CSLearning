using Unit4.CollectionsLib;
namespace _27._01._2025;

public class BiList {
    public Node<int>? smaller;
    public Node<int>? bigger;
    public BiList() {
        smaller = null;
        bigger = null;
    }
}

public static class BiListExtension {
    public static BiList GenerateBiList(this Node<int> list) {
        Node<int> tail = list;
        Node<int> smallest = new Node<int>(0), sTail = smallest;
        Node<int> biggest = new Node<int>(0), bTail = biggest;
        int counter = 0;
        while (tail is not null) {
            counter++;
            tail = tail.GetNext();
        }
        int?[] arr = new int?[counter];
        tail = list;
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = tail.GetValue();
            tail = tail.GetNext();
        }
        for (int i = 0; i < arr.Length / 2; i++) {
            int biggestIndex = arr.Biggest();
            bTail.SetNext(new Node<int>(((int)arr[biggestIndex]!)));
            arr[biggestIndex] = null;

            int smallestIndex = arr.Smallest();
            bTail.SetNext(new Node<int>(((int)arr[biggestIndex]!)));
            arr[smallestIndex] = null;
        }
        BiList bl = new BiList();
        bl.bigger = biggest.GetNext();
        bl.smaller = smallest.GetNext();

        return bl;
    }
    static int Biggest(this int?[] arr) {
        int biggest = int.MinValue;
        int index = int.MinValue;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] is null) continue;
            if (arr[i] > biggest) {
                index = i;
                biggest = (int)(arr[i]!);
            }
        }
        return index;
    }
    static int Smallest(this int?[] arr) {
        int smallest = int.MaxValue;
        int index = int.MinValue;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] is null) continue;
            if (arr[i] < smallest) {
                index = i;
                smallest = ((int)arr[i]!);
            }
        }
        return index;
    }
}
