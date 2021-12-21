// See https://aka.ms/new-console-template for more information
namespace Powerprogram
{
    class program
    {
        static void Main(string[] args)
        {
            double n, p;
            n = 7;
            p = 2;
            Console.WriteLine("Exponent power=" + n);
            double res = Math.Pow(n, p);
            Console.WriteLine("Result= {0}",res);
            Console.ReadLine();
        }

    }
 
}