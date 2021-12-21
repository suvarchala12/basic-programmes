// See https://aka.ms/new-console-template for more information
namespace SwapTwoNumbers
{
    class Program
    {
        public static void Main(string[]args)
        {
            int num1, num2, temp;
            Console.WriteLine("\n Enter the First number :");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter the Second number :");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("\nAfter Swapping:");
            Console.WriteLine("\nFirst number:" + num1);
            Console.WriteLine("\nSecond number:" + num2);
            Console.Read();
        }
    }
}
