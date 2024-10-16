# Interface

### Student code:
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskInterface.Interfaces;

namespace taskInterface
{
    internal class Student : IEmail
    {
        //constructor
        public Student()
        {
            Count++;
            ID += Count;
        }

        //properties
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public static int Count { get; set; }
        public string customEmail { get; set; }

        //methods
        public void Capitalize(string word)
        {
            Console.WriteLine(word.ToUpper());
        }
        public void generateEmail()
        {
            customEmail = $"{firstName.ToLower()}.{lastName.ToLower()}{ID}@gmail.com";
            Console.WriteLine(customEmail);
        }
    }
}
```
### Student image: 
![image](./assets/media/student.jpg)
-------
### IEmail code:
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskInterface.Interfaces
{
    internal interface IEmail
    {
        //properties
        public string customEmail { get; set; }

        //methods
        public void generateEmail();
    }
}
```
### IEmail image: 
![image](./assets/media/i_email.jpg)
-------
### Program code:
```csharp
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
```
### Program image: 
![image](./assets/media/program.jpg)
-------
### Output  image:
![image](./assets/media/output.jpg)