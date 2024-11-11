namespace _03._11._2024;

class Program
{
    static void Main(string[] args)
    {
        Point[] arr = new Point[4];

        Point p = new Point(1,2);
        arr[0] = new Point(5,6);
        arr[1] = p;
        arr[2] = new Point(
                arr[0].GetX(),
                arr[0].GetY()
                );
        Console.WriteLine(arr.ArrToStr());
    }
}
