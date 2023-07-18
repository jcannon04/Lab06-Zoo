
namespace Lab06_Zoo.AbstractClasses
{
    // Abstract class for all animals parent of Mammal, Bird, Reptile classes
	public abstract class Animal
	{
        // defining virtual and abstract properties to be overriden (Polymorphism)
        public virtual string Sound { get; set; } = "silence";
        public abstract string Color { get; set; }
        public abstract string Name { get; set; }
        public virtual int NumOfLegs { get; set; } = 4;

        // defining virtual and abstract methods to be overriden (Polymorphism)
        public virtual void Eat()
        {
            Console.WriteLine("Nom Nom");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("ZZZZ");
        }

        public abstract void Speak();
        public abstract void Move();
    }
}

