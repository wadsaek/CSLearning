using _30._09_2024.Classes;

namespace _30._09_2024;

class Program
{
    static void Main(string[] args){
        double a = new Temperature()
            .SetKelvin(4) // same Temperature;
            .GetFahrenheit();
        /*Console.WriteLine(a);*/

        Temperature t1 = new Temperature().SetFahrenheit(100);
        Temperature t2 = new Temperature().SetCelsius(65);
        (t1, t2) = (t2, t1);
        Console.WriteLine($"t1 in C = {t1.GetCelsius()}");
        Console.WriteLine($"t2 in C = {t2.GetCelsius()}");

        int i1 = 4;
        int i2 = 5;
        /*int temp = i2;*/
        /*i2 = i1;*/
        /*i1 = temp;*/
        (i2, i1) = (i1, i2);
        Console.WriteLine($"i1, i2 = {i1}, {i2}");
    }
}


