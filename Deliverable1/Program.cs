using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

class MainClass
{

    private const int slicesPerLoaf = 28;
    private const int tablespoonsOfPeanutButterPerJar = 32;
    private const int teaspoonsOfJellyPerJar = 48;

    public static void Main(string[] args)
    {
        {
            Console.WriteLine("How many people are we making PB&J sandwiches for?" );
            
            int numberOfSandwichs = int.Parse(Console.ReadLine());
            Console.WriteLine();


            double totalSlicesNeeded = numberOfSandwichs * 2;

            double totalLoavesNeeded = Math.Ceiling(totalSlicesNeeded / slicesPerLoaf);

            double tablesspoonsOfPBNeeded = numberOfSandwichs * 2;

            double totalJarsOfPBNeeded = Math.Ceiling(tablesspoonsOfPBNeeded / tablespoonsOfPeanutButterPerJar);
            
            double teaspoonsOfJellyNeeded = numberOfSandwichs * 4;

            double totalJarsOfJellyNeeded = Math.Ceiling(teaspoonsOfJellyNeeded / teaspoonsOfJellyPerJar);

            Console.WriteLine("You need:" );
            Console.WriteLine();
            Console.WriteLine($"  {totalSlicesNeeded} slices of bread" );
            Console.WriteLine($"  {tablesspoonsOfPBNeeded} tablespoons of peanut butter" );
            Console.WriteLine($"  {teaspoonsOfJellyNeeded} teaspoons of jelly" );
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  which is..." );
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"  {totalLoavesNeeded} loaves of bread" );
            Console.WriteLine($"  {totalJarsOfPBNeeded} jars of peanut butter" );
            Console.WriteLine($"  {totalJarsOfJellyNeeded} jars of jelly");
            Console.WriteLine();


            Console.WriteLine("Would you like to restart? Enter 'yes' or 'y' to continue, or enter any other key to exit.");
            var input = Console.ReadLine();

            var lowercaseInput = input.ToLower();


            if (lowercaseInput == "yes"|| lowercaseInput == "y")
            {
                System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                Environment.Exit(0);
            }

            Console.WriteLine("Goodbye!");

        }
    }
}