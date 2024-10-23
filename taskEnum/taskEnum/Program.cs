using System.Collections.Concurrent;
using taskEnum.Enum;

internal class Program
{
    private static void Main(string[] args)
    {
    Start:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Please enter number: ");
        int inputValue = 1;
        bool isNumber = int.TryParse(Console.ReadLine(), out inputValue);

        if (isNumber)
        {
            getMonths(inputValue);
            getWeekDays(inputValue);
            goto Start;
        }
        else
        {
            Console.Beep(255, 455);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!!!!!!! ------- !!!!!!!");
            Console.WriteLine("Please enter only number !!!");
            Console.WriteLine("!!!!!!! ------- !!!!!!!");
            goto Start;
        }
    }
    public static void getWeekDays(int days)
    {
        switch (days)
        {
            case (int)weekDays.Monday:
                Console.WriteLine($"Your selected day is: {weekDays.Monday}");
                break;
            case (int)weekDays.Tuesday:
                Console.WriteLine($"Your selected day is: {weekDays.Tuesday}");
                break;
            case (int)weekDays.Wednesday:
                Console.WriteLine($"Your selected day is: {weekDays.Wednesday}");
                break;
            case (int)weekDays.Thursday:
                Console.WriteLine($"Your selected day is: {weekDays.Thursday}");
                break;
            case (int)weekDays.Friday:
                Console.WriteLine($"Your selected day is: {weekDays.Friday}");
                break;
            case (int)weekDays.Saturday:
                Console.WriteLine($"Your selected day is: {weekDays.Saturday}");
                break;
            case (int)weekDays.Sunday:
                Console.WriteLine($"Your selected day is: {weekDays.Sunday}");
                break;
            default:
                Console.Beep(255, 255);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!!!!! ------- !!!!!!!");
                Console.WriteLine("Please enter for week day 1 between 7 !!!");
                Console.WriteLine("!!!!!!! ------- !!!!!!!");
                break;
        }
    }
    public static void getMonths(int month)
    {
        switch (month)
        {
            case (int)Months.January:
                Console.WriteLine($"Your selected month is: {Months.January}");
                break;
            case (int)Months.February:
                Console.WriteLine($"Your selected month is: {Months.February}");
                break;
            case (int)Months.March:
                Console.WriteLine($"Your selected month is: {Months.March}");
                break;
            case (int)Months.April:
                Console.WriteLine($"Your selected month is: {Months.April}");
                break;
            case (int)Months.May:
                Console.WriteLine($"Your selected month is: {Months.May}");
                break;
            case (int)Months.June:
                Console.WriteLine($"Your selected month is: {Months.June}");
                break;
            case (int)Months.July:
                Console.WriteLine($"Your selected month is: {Months.July}");
                break;
            case (int)Months.August:
                Console.WriteLine($"Your selected month is: {Months.August}");
                break;
            case (int)Months.September:
                Console.WriteLine($"Your selected month is: {Months.September}");
                break;
            case (int)Months.October:
                Console.WriteLine($"Your selected month is: {Months.October}");
                break;
            case (int)Months.November:
                Console.WriteLine($"Your selected month is: {Months.November}");
                break;
            case (int)Months.December:
                Console.WriteLine($"Your selected month is: {Months.December}");
                break;
            default:
                Console.Beep(255, 255);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!!!!! ------- !!!!!!!");
                Console.WriteLine("Please enter for month 1 between 12 !!!");
                Console.WriteLine("!!!!!!! ------- !!!!!!!");
                break;
        }
    }
}