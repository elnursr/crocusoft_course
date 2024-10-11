using accessModifiersEncapsulation.Models;

namespace accessModifiersEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Models.Animal("Scorpion", "Male");
            //animal.Type = "Bug";
            //animal.BirthYear = 2025;
            Console.WriteLine(animal.Type);

            Dog dog = new Dog("Leo", "Male", "German Shepherd");
            //dog.Breed = "Alaskan Malamute";
            //dog.BirthYear = 2024;
            Console.WriteLine(dog.BirthYear);
        }
    }
}