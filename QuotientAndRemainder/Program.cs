// See https://aka.ms/new-console-template for more information
namespace QuotientAndRemainder
{
    class Program
    {
        public static void Main(string[] args)
        {
            int dividend = 48, divisor = 8;
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Dividend:{0}Divisor{1}", dividend, divisor);
            Console.WriteLine("Quotient =" + quotient);
            Console.WriteLine(" Reaminder =" + remainder);
            Console.ReadLine();
        }
    }
}
