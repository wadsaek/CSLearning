using System.Drawing;
namespace _12._01._2025;
class Program {
    static void Main(string[] args) {
        Animal[] arr = new Animal[2];
        arr[0] = new Cow("moomoo", Color.Red, 12, 19);
        arr[1] = new Frog("froggy", Color.Green, 0.5, 1.2);
        foreach (Animal an in arr) {
            string output = an switch {
                Cow c => c.NameTypeString(),
                Frog f => f.NameTypeString(),
                Kangaroo k => k.NameTypeString(),
                _ => an.NameTypeString()
            };
            Console.WriteLine(output);
        }
    }
}
