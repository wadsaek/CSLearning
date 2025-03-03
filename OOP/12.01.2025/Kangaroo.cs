using System.Drawing;

namespace _12._01._2025;

class Kangaroo : Animal, IJump {
    public Kangaroo(string name, Color color, double age, double jumpHeight) : base(name, color, age) {
        this.jumpHeight = jumpHeight;
    }
    public Kangaroo(string name, Color color, double age, double jumpHeight, Kangaroo pouch) : base(name, color, age) {
        this.jumpHeight = jumpHeight;
        this.pouch = pouch;
    }

    public double jumpHeight {get;set;}
    public Kangaroo? pouch {get; set;}
    new public string NameTypeString() {
        return ($"I am a kangaroo and my name is {name}");
    }
}
