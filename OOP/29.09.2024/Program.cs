namespace _29._09._2024;

class Program {
    static void Main(string[] args) {
        Point[] points = new Point[5];
        for(int i =0; i<5; i++){
            
            //null checks are outside the scope of this exercise
            #nullable disable
            Console.WriteLine($"choose X for point {i+1}");
            int x = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"choose Y for point {i+1}");
            int y = int.Parse(Console.ReadLine());
            #nullable enable

            Point point = new Point(x,y);
            points[i] = point;
        }
        foreach(Point i in points){
            Console.WriteLine(i);
        }
    }
}

class Point{
    int x;
    int y;

    public Point(int x, int y)
    {
        SetX(x);
        SetY(y);
    }

    public void SetX(int value){
        if(value>0){
            this.x = value;
        }
    }
    public int GetX() => this.x;

    public void SetY(int value){
        if(value>0){
            this.y = value;
        }
    }
    public int GetY() => this.y;

    public override string ToString(){
        return $"({this.x}, {this.y})";
    }
}

