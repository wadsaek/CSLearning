using System.Drawing;
namespace _12._01._2025;

class Animal{
    string name;
    Color color;
    double age;

    public Animal(string name, double age){
        SetAge(age);
        SetName(name);
        SetColor(Color.Black);
    }

    public Animal(string name, Color color, double age) {
        this.name = name;
        this.color = color;
        this.age = age;
    }

    public double GetAge(){
        return age;
    }
    public void SetAge(double age){
        this.age = age;
    }
    public Color GetColor(){
        return color;
    }
    public void SetColor(Color color){
        this.color = color;
    }
    public string GetName(){
        return name;
    }
    public void SetName(string name){
        this.name = name;
    }

    public override bool Equals(object? obj) {
        return base.Equals(obj);
    }

    public override int GetHashCode() {
        return base.GetHashCode();
    }

    public override string? ToString() {
        return $"{name}, {color}, age {age}";
    }
}
