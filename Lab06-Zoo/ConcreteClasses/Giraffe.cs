using Lab06_Zoo.AbstractClasses;
namespace Lab06_Zoo.Classes
{
    //concrete class child class of parent class mammal 
	public class Giraffe : Mammal
	{
        //overrides and uses virtual and abstract properties and methods of parent class
        public override string Color { get; set; } = "orange";
        public new string FavFood = "leaves";
        public override string Name { get; set; } = "Giraffe";

        public Giraffe() { }

        public Giraffe(string name)
        {
            Name = name;
        }

        public override void Speak()
        {
            Console.WriteLine($"The giraffe says {Sound}");
        }

        public new void Eat()
        {
            Console.WriteLine($"Nom Nom. Yummy {FavFood}");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{Name} dreams about eating {FavFood}.");
        }

        public override void Move()
        {
            Console.WriteLine("Walks very carefully");
        }

    }
}

