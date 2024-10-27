namespace _17._09._24;

class Program
{
    static void Main(string[] args)
    {
	new int[] {1,2,3,4,5,6,7,8,9,10}
	.Select(Fibbonacci)
	.Select(a=>{Console.WriteLine(a);return a;})
	.ToArray();
    }
    static int Fibbonacci(int index){
	return index switch{
	    <=2 => index-1,
	    _ => Fibbonacci(index-1) + Fibbonacci(index - 2)
	};
    }
}
