using taskInterface.Interfaces;

namespace taskInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student()
            {
                firstName = "John",
                lastName = "Doe",
            };
            john.Capitalize("John Doe");
            john.generateEmail();

            Student barry = new Student()
            {
                firstName = "Barry",
                lastName = "Riddell"
            };
            barry.Capitalize("Barry Riddell");
            barry.generateEmail();
        }
    }
}