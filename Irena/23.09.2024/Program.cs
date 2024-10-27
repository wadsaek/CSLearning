namespace _23._09._2024;

class Program {
    static void Main(string[] args) {
        Console.WriteLine(SmallestDigit(1234));
        Console.WriteLine(SmallestDigit(4321));
        Console.WriteLine(SmallestDigit(33313));
        Console.WriteLine(SmallestDigit(111111));
        Console.WriteLine(SmallestDigit(0));
    }
    static uint SumOfDigits(uint num) {
        if(num<10) return num;
        byte remainder = (byte)(num%10);
        return remainder + SumOfDigits(num/10);
    }

    static bool AllDigitsEven(uint num) {
        if(num<10) return num%2==0;
        bool remainderEven = num%2 == 0;
        return remainderEven && AllDigitsEven(num/10);
    }

    static byte SmallestDigit(uint num) {
        if(num<10) return ((byte)num);
        return Math.Min(((byte)(num%10)),SmallestDigit(num/10));
    }


}
