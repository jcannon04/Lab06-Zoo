using Lab06_Zoo.AbstractClasses;
using Lab06_Zoo.Interfaces;

namespace Lab06_Zoo.ConcreteClasses
{
	public class Owl : Animal, IHuntable, IFlyable
	{
        public new string Sound { get; set; } = "hoot";
        public override string Name { get; set; } = "Hooty";
        public override string Color { get; set; } = "brown";

        public override void Speak()
        {
            Console.Write($"The owl says {Sound}");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} flys away");
        }

        public override void Move()
        {
            Fly();
        }

        public string Hunt()
        {
            return $"{Name} goes for a hunt";
        }
    }
}

