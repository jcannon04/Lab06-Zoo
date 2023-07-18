using Lab06_Zoo.AbstractClasses;
namespace Lab06_Zoo.Classes
{
    //concrete class child class of parent class mammal 
    public class Lion : Mammal
    {
        //overrides and uses virtual and abstract properties and methods of parent class
        public new  string Sound { get; set; } = "roar";
        public override string Color { get; set; } = "Golden";
        public new string FavFood = "steak";
        public override string Name { get; set; } = "Leo";

        public Lion() { }

        public Lion(string name)
        {
            Name = name;
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the lion says {Sound}");
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
            Console.WriteLine("Prowling through the savvanah");
        }
    }
}

