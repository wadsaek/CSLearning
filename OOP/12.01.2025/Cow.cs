using System.Drawing;
namespace _12._01._2025;

class Cow : Animal {
    public Cow(double milkCap) : base("Cow", 5) {
        this.milkCap = milkCap;
    }
    public Cow(string name, Color color, double age, double milkCap) : base(name, color, age) {
        this.milkCap = milkCap;
    }

    public double milkCap;

    public override string? ToString() {
        return $"{base.ToString()}\nmilkCap: {milkCap}";
    }
    new public string NameTypeString() {
        return ($"I am a cow and my name is {name}");
    }
}
