namespace KangarooNamespace;

class Program
{
    public static void Main() {
        Kangaroo newKangaroo = new Kangaroo("Olga", 15, 54.12, 9, 9, false);
        Kangaroo child = new Kangaroo("Arkadiy", 3.5, 54.13, 10,1, true);
        newKangaroo.SetPocketContents(child);
        Console.WriteLine(newKangaroo);
    }
}