internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Please enter parking time: ");
        double parkingTime = 0;
        bool isDigit = double.TryParse(Console.ReadLine(), out parkingTime);

        double defaultParkingPayment = 1;
        double discountPrice = 0;
        double discountPerHourPayment = 0;
        double discountedParkingPayment = 0;

        if (isDigit)
        {
            if (parkingTime <= 3)
            {
                Console.WriteLine($"Your parking payment is: {defaultParkingPayment}");
                Console.WriteLine($"Your discounted parking payment is: {discountedParkingPayment}");
            }
            else if (parkingTime > 3 && parkingTime <= 5)
            {
                discountPrice = 0.2;
                defaultParkingPayment = parkingTime - ((parkingTime % 3) * discountPrice);
                discountPerHourPayment = defaultParkingPayment;
                Console.WriteLine($"Your parking payment is: {defaultParkingPayment}");
                Console.WriteLine($"Your discounted parking payment is: {(parkingTime % 3) * discountPrice}");
            }
            else if (parkingTime > 5 && parkingTime <= 8)
            {
                discountPrice = 0.5;
                defaultParkingPayment = parkingTime - (((parkingTime % 5) * discountPrice) + 0.4);
                Console.WriteLine($"Your parking payment is: {defaultParkingPayment}");
                Console.WriteLine($"Your discounted parking payment is: {(((parkingTime % 5) * discountPrice) + 0.4)}");
            }
        }
        else
        {
            Console.WriteLine("Please enter number only!!!");
        }
    }
}