namespace _03._11._2024;

public class Point
{
    int x;
    int y;

    public Point(){}
    public Point(int x, int y){
        this.x = x;
        this.y = y;
    }

    public int GetX(){
        return x;
    }
    public Point SetX(int x){
        this.x = x;
        return this;
    }

    public int GetY(){
        return y;
    }
    public Point SetY(int y){
        this.y = y;
        return this;
    }

    public override string ToString()
        {
            return $"({x}, {y})";
        }
}

public static class PointArrExtension{
    public static string ArrToStr(this Point[] arr){
        string a = "[";
        foreach(Point i in arr){
            a+=$"{i} ";
        }
        a+="]";
        return a;
    }
}
