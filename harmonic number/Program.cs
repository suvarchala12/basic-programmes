// See https://aka.ms/new-console-template for more information
using System;
namespace HarmonicValue
{
    class HarmonicValue
    {
        //function to return sum of
        //harmonic series using recursion
        static  float sum(float n)
        {
            //Base conditions
            if (n < 2)
                return 1;
            else
                return 1/n +(sum(n - 1));
        }
        //Driven program
        public static  void Main ()

        {
            Console.WriteLine(sum(8));
            Console.WriteLine(sum(10));
        }
    }
}       
