Console.Write("Please enter number: ");
int inputNumber;
int factorial = 1;
bool isNumber = int.TryParse(Console.ReadLine(), out inputNumber);

if (isNumber)
{
    //for (int i = inputNumber; i >= 1; i--)
    //{
    //    factorial *= i;
    //}

    while (inputNumber >= 1)
    {
        factorial *= inputNumber;
        inputNumber--;
    }
    Console.WriteLine($"Factorial result is: {factorial}");
}