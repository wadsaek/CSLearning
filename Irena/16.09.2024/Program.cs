namespace _16._09._2024;

class Program {
    static void Main(string[] args) {
      Console.WriteLine(Example.Example.MaxValue(new Span<int>(new int[]{1,2,3,4})));
    }
    static long Factorial(uint num) => num switch{
        0 => 1,
	>0 => num * Factorial(num-1)
    };
    static int MultiplyOOfN(int a, uint b) => b switch{
	0 => 0,
	>0 => a + MultiplyOOfN(a,b-1),
    };

    static int DivideRecurs(int numerator, int denominator){
      if(numerator< denominator) return 0;
      return 1+ DivideRecurs(numerator - denominator, denominator);
    }
    static int Mod(int numerator, int denominator){
      if(numerator< denominator) return numerator;
      return Mod(numerator - denominator, denominator);
    }

    static bool IsDivisible(int x, int y) => Mod(x,y)==0;

    static uint SumUpTo(uint n) {
	if(n < 1) return n;
	return n+SumUpTo(n-1);
    }

    static bool IsEven(int n)=> n%2==0;
    static bool IsOdd(int x)=> !IsEven(x);

    static uint SumOddUpTo(uint n){
	if(n <= 1) return n;
	if(IsEven(((int)n))) return SumOddUpTo(n-1);
	return n + n-2;
    }

    static byte NumOfDigits(uint n) {
        if(n==0) return 0;
        return (byte)(1 + NumOfDigits(n/10));
    }

}
