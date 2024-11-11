namespace _30._09_2024.Classes;

class Malben
{
    private double length;
    private double width;

    public Malben()
    {
        length = 0;
        width = 0;
    }
    public Malben(double length, double width)
    {
        this.SetLen(length);
        SetWidth(width);
    }

    public void SetLen(double length)
    {
        if (length >= 0)
        {
            this.length = length;
        }
    }

    public double GetLen()
    { return length; }

    public void SetWidth(double width)
    {
        if (width >= 0)
        {
            this.width = width;
        }
    }

    public double GetWidth()
    { return length; }
    public double Area()
    {
        return width * length;
    }
    public double Perimeter()
    {
        return 2 * (width + length);
    }

    public override string ToString()
    {
        string s = string.Format(" w={0} l={1}", this.width, length);
        return s;
    }

    public override bool Equals(Object? obj)
    {
        return Object.Equals(null, obj) 
            || (
                    obj.GetType() == GetType() 
                    && ((Malben)obj).width == this.width 
                    && ((Malben)obj).length ==this.length
               );
    }

}

