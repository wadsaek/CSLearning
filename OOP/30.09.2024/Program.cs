using _30._09_2024.Classes;

namespace _30._09_2024;

class Program
{
    static void Main(string[] args){
        Malben[] arr = new Malben[3];
        for(int i = 0; i<3; i++){
            Console.WriteLine("enter the data for Rectangle #{0}",i);
            #nullable disable
            Console.Write("Length: ");
            double len = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            #nullable enable

            arr[i] = new Malben(len,width);
        }

        for(int i = 0; i<3; i++){
            Console.WriteLine(arr[i]);
        }
    }
}


