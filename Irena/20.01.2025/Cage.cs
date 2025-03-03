using System;

namespace _20._01._2025;

public class Cage {
    public Cage(string name, int id) {
        this.name = name;
        this.id = id;
    }

    public string name {get; set;}
    public int id {get; set;}

    public override bool Equals(object obj) {
        return obj is Cage cage &&
               name == cage.name &&
               id == cage.id;
    }

    public override int GetHashCode() {
        return HashCode.Combine(name, id);
    }

    public override string ToString() {
        return $"{name} with id {id}";
    }

    private string GetDebuggerDisplay() {
        return ToString();
    }
}
