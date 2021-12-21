// See https://aka.ms/new-console-template for more information
namespace Largeof3Numbers
{
    class Program
    {

    public static void Main(string[]args)
        {
            int x, y, z;
            Console.WriteLine("Enter the First Number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y && x > z) 
            {
                Console.WriteLine("Enter the greatest is" + x);
            }
             else if(y>z) 
            {
                Console.WriteLine("Enter the greatest is" + y);

            }
            else
            {
                Console.WriteLine("Enter the greatest is" + z);

            }

        }
    }
}
