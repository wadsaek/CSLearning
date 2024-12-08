namespace _08._12._2024;

class Program
{
    static void Main(string[] args)
    {
        ShoppingList list = new ShoppingList("Shufersal", new Date(2024, 12, 25));
        Item item = new Item("milk", 400.99, 5);
        list.Append(item);
        Console.WriteLine(item);
        Console.WriteLine(list);
        item.SetPricePerEach(5);
        Console.WriteLine();
        Console.WriteLine(item);
        Console.WriteLine(list);
    }
}
