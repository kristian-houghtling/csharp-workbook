using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        int num1;
        int num2;
        int yards;
        int inches;
        bool people = true;
        bool f = false;
        double num;
        string firstName = "Kristian";
        string lastName = "Houghtling";
        int age = 44;
        string job = "Landman";
        string favoriteBand = "AC/DC";
        string favoriteSportsTeam = "None";


        // Adding two numbers
        Console.WriteLine("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your two numbers added together = " + (num1 + num2));

        System.Threading.Thread.Sleep(2000);
        Console.Clear();

        // Yards to inches
        Console.WriteLine("Let's convert Yards to Inches. \nPlease enter how many Yards: ");
        yards = Convert.ToInt32(Console.ReadLine());
        inches = yards * 36;
        Console.WriteLine(yards + " yards = " + inches + " inches!");

        System.Threading.Thread.Sleep(2000);
        Console.Clear();

        // Display the variable num multiplied by itself
        Console.WriteLine("Lets see what a number multiplied by itself equals. \nPlease enter a number you'd like to multiplied by itself: ");
        num = Convert.ToInt32(Console.ReadLine());
        num = num * num;
        Console.WriteLine("Your number multiplied by itself equals: " + num);

        System.Threading.Thread.Sleep(2000);
        Console.Clear();

        Console.WriteLine("Thank You!, Please come again.");


        // leave this command at the end so your program does not close automatically
        Console.ReadLine();
    }
}
