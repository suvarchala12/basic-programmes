// See https://aka.ms/new-console-template for more information
namespace CheckLeapYear
{
    class CheckLeapYear
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the year :");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("year is a LeapYear");
            else
                Console.WriteLine("year is not a LeapYear");
            Console.ReadKey();

        }
    }
}
