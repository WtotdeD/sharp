using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 30 ;
            int c = 14;
            int d = (a + b ) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient : {e} ");
            Console.WriteLine($"remainder : {d}");
            
        }
    }
}
