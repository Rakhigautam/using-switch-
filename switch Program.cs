// See https://aka.ms/new-console-template for more information
using System;
namespace Weekday
{
    class prgram
{
    static void Main(string[] args)
    {
            int Weekday;
            Console.WriteLine("Enter weekday number (0-6)");
            Weekday = Convert.ToInt32(Console.ReadLine());
            switch (Weekday)
            {
                case 0:
                    Console.WriteLine("It is Sunday");
                    break;
                case 1:
                    Console.WriteLine("it ia Monday");
                    break ;
                case 2:
                    Console.WriteLine("it is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("it is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("it is thursday");
                    break;
                case 5:
                    Console.WriteLine("it is friday");
                    break;
                case 6:
                    Console.WriteLine("it is saturday");
                    break;



            }

            
           
        

            
     
    }
}
}
