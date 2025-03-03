using System.Drawing;
namespace _12._01._2025;

class Animal{
    public string name;
    Color color;
    double age;

    public Animal(string name, double age){
        this.age = (age);
        this.name = (name);
        this.color = (Color.Black);
    }

    public Animal(string name, Color color, double age) {
        this.name = name;
        this.color = color;
        this.age = age;
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
    public string NameTypeStringType(){
        return ($"I am a {this.GetType().Name}");
    }
    public string NameTypeString(){
        return ($"I am a {this.GetType().Name} and my name is {name}");
    }
}
