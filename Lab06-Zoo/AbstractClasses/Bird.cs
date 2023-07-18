
namespace Lab06_Zoo.AbstractClasses
{
    // abstract class inherits from animal and is the parent of Raven class
	public abstract class Bird : Animal
	{
        public override int NumOfLegs { get; set; } = 2;
        // virtual and property to be overiden or used in every class that inherits from Bird
        public virtual string FavFood { get; set; } = "Worms";

        // overide method from animal class to be used by every class that inhereits from Bird
        public override void Move()
        {
            Console.WriteLine("flys away");
        }
    }
}

