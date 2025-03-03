using System.Drawing;

namespace _12._01._2025;

class Frog : Animal, IJump {
    public Frog(string name, Color color, double age, double jumpHeight) : base(name, color, age) {
        this.jumpHeight = jumpHeight;
    }

    public double jumpHeight {get;set;}

    new public string NameTypeString() {
        return ($"I am a frog and my name is {name}");
    }
}
