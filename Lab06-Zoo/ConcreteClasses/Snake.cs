using Lab06_Zoo.AbstractClasses;
namespace Lab06_Zoo.Classes
{
    //concrete class child class of parent class Reptile
    public class Snake : Reptile
    {
        //overrides and uses virtual and abstract properties and methods of parent class
        public new string Sound = "hisssss";
        public new string FavFood = "mice";
        public override string Color { get; set; } = "green";
        public override string Name { get; set; } = "Slippy";
        public new int NumOfLegs { get; set; } = 0;

        public Snake() { }

        public Snake(string name)
        {
            Name = name;
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the snake says {Sound}");
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
            Console.WriteLine("Slither Slither");
        }
    }
}

