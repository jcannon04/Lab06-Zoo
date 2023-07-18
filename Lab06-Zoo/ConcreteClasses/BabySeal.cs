using Lab06_Zoo.AbstractClasses;
namespace Lab06_Zoo.Classes
{
    //concrete class child class of mammal
	public class BabySeal : Mammal
	{
        // overides and uses abstract and virtual properties and methods of parent class
        public new string Sound = "bark";
        public override string Color { get; set; } = "Grey";
        public new string FavFood = "fish";
        public override string Name { get; set; } = "Baby Seal";
        public new int NumOfLegs { get; set; } = 0;

        public BabySeal() { }

        public BabySeal(string name)
        {
            Name = name;
        }

        public override void Speak()
        {
            Console.WriteLine($"The baby seal says {Sound}");
        }

        public override void Eat()
        {
            Console.WriteLine($"Nom Nom. Yummy {FavFood}");
        }
        public override void Sleep()
        {

            Console.WriteLine($"{Name} dreams about eating {FavFood}.");
        }

        public override void Move()
        {
            Console.WriteLine("Wobble Wobble");
        }
    }
}

