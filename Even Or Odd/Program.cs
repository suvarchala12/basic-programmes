// See https://aka.ms/new-console-template for more information
namespace EvenOrOdd
{
    class EvenOrOdd
    {
        public  static void  Main(string[] args)
        {
            int n;
            Console.Write("Enter The Number:");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.Write("Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Number is an Odd Number");
                Console.Read();

            }
        }
    }
}
