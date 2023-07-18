
namespace Lab06_Zoo.AbstractClasses
{
    //abstract class parent class of Snake
	public abstract class Reptile : Animal
	{
        public override int NumOfLegs { get; set; } = 4;
        //virtual method to be used or override by concrete child classes
        public virtual string FavFood { get; set; } = "Insects";
    }
}

