namespace _30._09_2024.Classes;

struct Vector2{

    public int x;
    public int y;

    public Vector2(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    
    public static Vector2 operator -(Vector2 vec){
        return new Vector2(-vec.x,-vec.y);
    }

    public static Vector2 operator +(Vector2 lhs, Vector2 rhs){
        return new Vector2(lhs.x+rhs.x,lhs.y+rhs.y);
    }
    public static Vector2 operator -(Vector2 lhs, Vector2 rhs){
        return lhs + (-rhs);
    }

    /*public static Vector2 operator<T> *(Vector2 vec, T scalar) {*/
    /*    return new Vector2(*/
    /*            (int)(vec.x * scalar)*/
    /*            (int)(vec.y * scalar)*/
    /*            );*/
    /*}*/
    /**/
    public static implicit operator (int,int)(Vector2 v) => (v.x,v.y);

    public static double Distance(Vector2 one, Vector2 other){
        var difX = one.x - other.x;
        var difY = one.y - other.y;
        return Math.Sqrt(
            difX*difX + difY*difY
        );
    }
    
    ///<returns>
    /// the slope of two vectors, or <c>double.PositiveInfinity</c>, if the 
    /// two vectors share the same <c>x</c> coordinate
    ///</returns>
    public static double Slope(Vector2 one, Vector2 other){
        if(one.x == other.x) return double.PositiveInfinity;
        return ((double)(one.y - other.y))/ (one.x - other.x);
    }

    public static Vector2 Zero = new Vector2(0,0);
    public static Vector2 UnitX = new Vector2(1,0);
    public static Vector2 UnitY = new Vector2(0,1);
}

class Triange{

    Vector2 point1;
    Vector2 point2;
    Vector2 point3;

    private Triange Create(Vector2 point1, Vector2 point2, Vector2 point3){
        if(!ValidTriangle(point1,point2,point3)){
            return new Triange();
        }
        return new Triange(point1, point2, point3);
    }
    private Triange(){}

    public Triange(Vector2 point1, Vector2 point2, Vector2 point3){
            this.point1 = point1; 
            this.point2 = point2;
            this.point3 = point3;
    }

    public Vector2 GetPoint(byte number){
        switch(number){
            case 1:
                return point1;
            case 2:
                return point2;
            case 3: 
                return point3;
            default:
                return Vector2.Zero;
        }
    }
    private Vector2[] Points() {return new Vector2[]{point1, point2, point3};}

    public void Translate(Vector2 translation){
        Vector2[] points = Points();
        var translatedPoints = points.Select((p)=>p+translation).ToArray();
        if(translatedPoints.All(ValidPoint)){
            point1 = translatedPoints[0];
            point2 = translatedPoints[1];
            point3 = translatedPoints[2];
        }
    } 

    /*public void Scale(double scalar){*/
    /*    Vector2[] points = Points();*/
    /*    var scaled_points = points.Select((p)=>p*scalar)*/
    /*}*/
    /**/
    private bool ValidX(Vector2 point){
        return point.x >= 0 && point.x <1024;
    }

    private bool ValidY(Vector2 point){
        return point.y >= 0 && point.y < 768;
    }

    private bool ValidPoint(Vector2 point){
        return ValidX(point) && ValidY(point);
    }

    private bool ValidTriangle(Vector2 first, Vector2 second, Vector2 third){
        var points = new Vector2[3]{first, second, third};
        if (!points.All(ValidPoint))
            return false;
        
        if(Vector2.Slope(first,second) == Vector2.Slope(first,third))
            return false;

        return true;
    }
}
