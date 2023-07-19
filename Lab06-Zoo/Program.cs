using Lab06_Zoo.Classes;
namespace Lab06_Zoo;

class Program
{
    static void Main(string[] args)
    {
        BabySeal seal = new BabySeal();
        seal.Speak();
        seal.Eat();
        seal.Sleep();

        Giraffe giraffe = new Giraffe();
        giraffe.Speak();
        giraffe.Eat();
        giraffe.Sleep();

        Lion leo = new Lion();
        leo.Speak();
        leo.Eat();
        leo.Sleep();

        Raven squaks = new Raven();
        squaks.Speak();
        squaks.Hunt();
        squaks.Eat();
        squaks.Sleep();
        squaks.Move();

        Snake slippy = new Snake();
        slippy.Speak();
        slippy.Eat();
        slippy.Sleep();
        Console.WriteLine($"Slippy has {slippy.NumOfLegs} legs");

        Console.ReadKey();
    }
}

