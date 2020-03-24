using System;

namespace BranachesAndLoops
{
    class Program
    {
        static void ExploreIF()
        {
            int a = 1;
            int b = 4;
            if ((a + b > 10) && (a * b <15) || (a + b == 50))
                {
                Console.WriteLine("The sum off a and b is greater then 10");
                Console.WriteLine("and the sum is smaller then fifteen");
                }
            else
            Console.WriteLine("The sum is not greater then ten");
        }


         static void Main(string[] args)
         {
             int number;
             Console.WriteLine("Welcome.....");
             System.Threading.Thread.Sleep(0500);
             Console.WriteLine("To the most advanced calculator ever");
             System.Threading.Thread.Sleep(0500);
             Console.WriteLine("So mortal..... what is the number you choise...");
            number  = Convert.ToInt32(Console.ReadLine());
             
             ExploreIF();
         }

    }
}
