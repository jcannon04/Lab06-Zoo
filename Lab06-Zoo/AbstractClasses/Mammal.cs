
namespace Lab06_Zoo.AbstractClasses
{
	//abstract class parent of Giraffe, Lion, BabySeal classes
	public abstract class Mammal : Animal
	{
		public override int NumOfLegs { get; set; } = 4;
		// virtual properties to vbe used or overrident in child classes
		public virtual string FavFood { get; set; } = "Pizza";

	}
}

