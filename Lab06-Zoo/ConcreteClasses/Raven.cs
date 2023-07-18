using Lab06_Zoo.AbstractClasses;
namespace Lab06_Zoo.Classes
{
    //concrete class child class of parent class Bird
    public class Raven : Bird
	{
        //overrides and uses virtual and abstract properties and methods of parent class
        public new string Sound = "cawww";
        public new string FavFood = "roadkill";
        public override string Name { get; set; } = "Squawky McBeak";
        public override string Color { get; set; } = "Black";

        public Raven() { }

        public Raven(string name)
        {
            Name = name;
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the raven says {Sound}");
        }

        public new void Eat()
        {
            Console.WriteLine($"Nom Nom. Yummy {FavFood}");
        }
        public new void Sleep()
        {

            Console.WriteLine($"{Name} dreams about eating {FavFood}.");
        }

    }
}

