namespace _05._11._2024;

class Program
{
    static void Main(string[] args) {
        LinkedListNode<int> n = new LinkedListNode<int>(5);      
        ref int val = ref n.ValueRef;
        val = 6;
        Console.WriteLine(n.Value);
    }
}
