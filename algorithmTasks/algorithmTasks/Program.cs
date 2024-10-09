#region task_1_01_10_2024
//task_1:

//Console.WriteLine("******* Simple And Complex Number *******");
//Console.ForegroundColor = ConsoleColor.Green;
//Console.Write("Please enter number: ");

//int inputNumber;
//bool isNumber = int.TryParse(Console.ReadLine(), out inputNumber);

//if (isNumber)
//{
//    if (inputNumber % 2 == 0 && inputNumber == 2)
//    {
//        Console.WriteLine("Your number is the same time complex and simple");
//        goto task_1;
//    }
//    else if (inputNumber % 2 == 0)
//    {
//        Console.WriteLine("Your number is complex");
//        goto task_1;
//    }
//    else
//    {
//        Console.WriteLine("Your number is simple");
//        goto task_1;
//    }
//}
//else
//{
//    Console.Beep(255, 455);
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Incorrect value!!!");
//    goto task_1;
//}
#endregion

#region task_2_01_10_2024
//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine("******* Sum Simple Numbers *******");
//Console.Write("Please enter number: ");

//int inputNumber;
//int simpleNumberSum = 0;
//bool isNumber = int.TryParse(Console.ReadLine(), out inputNumber);

//if (isNumber)
//{
//    int count = 0;

//    while (count < inputNumber)
//    {
//        inputNumber--;

//        if (inputNumber % 2 != 0)
//        {
//            simpleNumberSum += inputNumber;
//        }
//    }
//    Console.WriteLine($"Your simple numbers sum is: {simpleNumberSum}");
//}
#endregion

#region task_1_09_10_2024
//int[] myArray = [15, 93, 27, 35, 49, 21, 14, 7, 81, 77];

//int minimumNumber = myArray.Length - 1;

//for (int i = 0; i < myArray.Length; i++)
//{
//    if (myArray[i] <= minimumNumber)
//    {
//        minimumNumber = myArray[i];
//    }
//}

//Console.WriteLine($"Your array minimum number is: {minimumNumber}");
#endregion

#region task_2_09_10_2024
Console.Write("Please enter numbers: ");
string symbols = Console.ReadLine();


string[] myArray = { symbols };

Console.WriteLine(myArray);

//int[] myArray = [-1, 12, 9, -17, 25, 13, -77, 29, -48, 28, 78, 96];
//int sumNegativeNumber = 0;
//int sumEvenNumber = 1;

//for (int i = 0; i < myArray.Length; i++)
//{
//    if (myArray[i] < 0)
//    {
//        sumNegativeNumber += myArray[i];
//    }
//    else if (myArray[i] % 2 == 0)
//    {
//        sumEvenNumber *= myArray[i];
//    }
//}

//Console.WriteLine($"Your negative number sum is: {sumNegativeNumber}");

//Console.WriteLine($"Your even number sum is: {sumEvenNumber}");
#endregion