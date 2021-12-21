// See https://aka.ms/new-console-template for more information
namespace VowelOrConstant
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the alphabet");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("it is a Vowel");
                        break;
                case 'e':
                    Console.WriteLine("it a vowel");
                    break;
                case 'i':
                    Console.WriteLine("it is a Vowel");
                    break;
                case 'o':
                    Console.WriteLine("it is a Vowel");
                    break;
                case 'u':
                    Console.WriteLine("it is a Vowel");
                    break;
                default:
                    Console.WriteLine("it is not a vowel");
                    break ;
            }
            Console.ReadKey();
        }
    }
}

