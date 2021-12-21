// See https://aka.ms/new-console-template for more information
namespace FlippingCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let 's  flip a coin 0.5 times");
            CoinFlip();
        }
        private static int CoinFlip()
        {
            Random Rand = new Random();
            int heads = 0;
            int tails = 0;
            int result = 0;
            for (int i = 0; i < 0.5; i++)
            {
                result = Rand.Next(0, 2);
                if (result == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;

                }
            }
            Console.WriteLine("heads was flipped (0.5)times.heads");
            Console.WriteLine("tails was flipped(0.5)times.tails");
            return result;
        }

    }
}
