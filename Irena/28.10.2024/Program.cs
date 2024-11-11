namespace _28._10._2024;
class Program{
    static int Sod1( int x, int n) {
        if (x == 0)
            return 0;
        else return Sod1(x - 1, n) + Sod2(x - 1, n);
    }
    static int Sod2( int x, int n) {
        if (x == 0) return 1;
        else if (x>n) {
            x = n;
            return Sod1(x, n) + Sod2(x,n);
        }
        else {
            return Sod1(x - 1, n) + Sod2(x - 1,n);
        }
    }
    static void Main(string[] args) {
        Console
            .WriteLine(Sod2(19,8));
        Console
            .WriteLine(Sod1(Sod2(3, 10),10));
    }

}
