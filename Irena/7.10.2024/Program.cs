namespace _7._10._2024;

class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[4];
        for(int i = 0; i<4; i++){
            a[i]=i+1;
        }

        Console.WriteLine(FindRecursive(a,-4));
    }

    static int FindRecursive<T>(Span<T> span, T target)
    where T:IEquatable<T>{
        if(span.IsEmpty){
            return -1;
        }
        if(span[0].Equals(target)){
            return 0;
        }
        int result = FindRecursive(span.Slice(1),target);
        return result != -1 ? 1 + result : -1;
    }
}
