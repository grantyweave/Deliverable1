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
            Console.Write("How many people are we making PB&J sandwiches for?");
            int numberOfSandwichs = int.Parse(Console.ReadLine());


            double totalSlicesNeeded = numberOfSandwichs * 2;

            double totalLoavesNeeded = Math.Ceiling(totalSlicesNeeded / slicesPerLoaf);

            double tablesspoonsOfPBNeeded = numberOfSandwichs * 2;

            double totalJarsOfPBNeeded = Math.Ceiling(tablesspoonsOfPBNeeded / tablespoonsOfPeanutButterPerJar);
            
            double teaspoonsOfJellyNeeded = numberOfSandwichs * 4;

            double totalJarsOfJellyNeeded = Math.Ceiling(teaspoonsOfJellyNeeded / teaspoonsOfJellyPerJar);

            Console.WriteLine($"To make {numberOfSandwichs} sandwiches you will need {totalLoavesNeeded} loaves of bread, {totalJarsOfPBNeeded} jars of Peanut Butter, and {totalJarsOfJellyNeeded} jars of Jelly.");

            Console.WriteLine("Would you like to restart? Enter 'yes' or 'y' to continue, or enter any other key to exit.");
            var input = Console.ReadLine();

            var lowercaseInput = input.ToLower();


            if (lowercaseInput == "yes"|| lowercaseInput == "y")
            {
                System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                Environment.Exit(0);
            }

            Console.WriteLine("Goodbye");

        }
    }
}