namespace MethodOverride
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog is Barking...");
        }
    }
}