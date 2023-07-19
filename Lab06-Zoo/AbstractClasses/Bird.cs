using Lab06_Zoo.Interfaces;
namespace Lab06_Zoo.AbstractClasses
{
    // abstract class inherits from animal and is the parent of Raven class
	public abstract class Bird : Animal, IHuntable, IFlyable
	{
        public override int NumOfLegs { get; set; } = 2;
        // virtual and property to be overiden or used in every class that inherits from Bird
        public virtual string FavFood { get; set; } = "worms";

        // overide method from animal class to be used by every class that inhereits from Bird
        public override void Move()
        {
            Console.WriteLine("flys away");
        }

        public string Hunt()
        {
            return $"{Name} hunts for {FavFood}";
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} flys away");
        }
    }
}

