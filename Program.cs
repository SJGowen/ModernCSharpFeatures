namespace ModernCSharpFeatures;

using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        var feature = 0;
        do
        {
            feature = GetValidMenuEntry();
            if (feature > 0)
            {
                var newWay = GetBoolFromPrompt("Do you want to view the modern way of implementing this feature?");
                DisplayFeature(feature, newWay);
            }
        } while (feature > 0);
        Console.WriteLine("Thank you for using the C# Modern Features.");
    }

    public static int GetValidMenuEntry()
    {
        var featureCount = 4;
        var intEntry = -1;
        do
        {
            var entry = DisplayMenu();
            if (!int.TryParse(entry, out intEntry))
            {
                Console.WriteLine("Sorry, that is an invalid entry!\n");
                intEntry = -1;
            }
            else
            {
                if (intEntry > featureCount)
                {
                    Console.WriteLine($"Sorry there are only {featureCount} entries!\n");
                }
            }
        } while (intEntry < 0 || intEntry > featureCount);
        return intEntry;
    }

    public static string DisplayMenu()
    {
        //Console.Clear();
        Console.WriteLine("Choose a number to look at a C# Modern Feature");
        Console.WriteLine("==============================================");
        Console.WriteLine(" 1 - Tuples instead of out parameters.");
        Console.WriteLine(" 2 - Casting using 'is' versus 'as'.");
        Console.WriteLine(" 3 - Local functions within other functions.");
        Console.WriteLine(" 4 - Expression bodied members.\n");
        Console.WriteLine(" 0 - To Exit using C# Modern Features.");
        Console.Write("Enter your choice: ");
        return Console.ReadLine();
    }

    public static bool GetBoolFromPrompt(string prompt)
    {
        var intEntry = -1;
        do
        {
            var entry = GetReplyFromPrompt(prompt);
            if (entry.Length > 0 && entry.ToLower() == "y") entry = "1";
            if (entry.Length > 0 && entry.ToLower() == "n") entry = "0";
            if (!int.TryParse(entry, out intEntry))
            {
                Console.WriteLine("Sorry, that is an invalid entry!\n");
                intEntry = -1;
            }
        } while (intEntry < 0 || intEntry > 1);
        return intEntry == 1;
    }

    public static string GetReplyFromPrompt(string prompt)
    {
        //Console.Clear();
        Console.WriteLine(prompt);
        Console.Write("Enter your choice (y/n): ");
        return Console.ReadLine();
    }

    public static void DisplayFeature(int toDisplay, bool newWay)
    {
        //Console.WriteLine($"{toDisplay} {newWay}\n");
        if (newWay) 
            DisplayNewFeature(toDisplay);
        else
            DisplayOldFeature(toDisplay);
    }

    public static void DisplayNewFeature(int toDisplay)
    {
        switch (toDisplay) 
        {
            case 1: 
            {
                var feature = new TupleNewFeature();
                if (GetBoolFromPrompt("Do you want to view code?")) 
                    Process.Start("code", "TupleNewFeature.cs");
                break;
            }
            case 2: 
            {
                var feature = new CastUsingIsNewFeature();
                if (GetBoolFromPrompt("Do you want to view code?")) 
                    Process.Start("code", "CastUsingIsNewFeature.cs");
                break;
            }

            default: 
            {
                break;
            }
        }
    }

    public static void DisplayOldFeature(int toDisplay)
    {
        switch (toDisplay) 
        {
            case 1: 
            {
                var feature = new TupleOldFeature();
                if (GetBoolFromPrompt("Do you want to view code?"))
                    Process.Start("code", "TupleOldFeature.cs");
                break;
            }
            case 2: 
            {
                var feature = new CastUsingIsOldFeature();
                if (GetBoolFromPrompt("Do you want to view code?"))
                    Process.Start("code", "CastUsingIsOldFeature.cs");
                break;
            }
            default: 
            {
                break;
            }
        }
    }
}