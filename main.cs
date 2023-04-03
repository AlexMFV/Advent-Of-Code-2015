//Simple console menu with selection without usings
using System.Reflection;

string? input = "";

while (input == "")
{
    Console.WriteLine("-----Welcome to the Advent Of Code 2015-----");
    Console.WriteLine("Select a day to run:");
    Console.WriteLine("1. Day 1");
    Console.WriteLine("2. Day 2");
    Console.WriteLine("3. Day 3");
    Console.WriteLine("4. Day 4");
    Console.WriteLine("5. Day 5");
    Console.WriteLine("6. Day 6");
    Console.WriteLine("7. Day 7");
    Console.WriteLine("8. Day 8");
    Console.WriteLine("9. Day 9");
    Console.WriteLine("10. Day 10");
    Console.WriteLine("11. Day 11");
    Console.WriteLine("12. Day 12");
    Console.WriteLine("13. Day 13");
    Console.WriteLine("14. Day 14");
    Console.WriteLine("15. Day 15");

    Console.Write("Enter a number: ");

    input = Console.ReadLine();

    //Validate if input is a number from 1 to 15
    if (int.TryParse(input, out int day) && day > 0 && day < 16)
    {
        //Run the selected day
        Console.WriteLine();
        Console.WriteLine("|| Running day " + day + " ||");

        //Access the folder of the selected day "DayX" where X is the number of the day and run the method with the name associated to the day
        Type? type = Type.GetType("Program");

        if (type != null)
        {
            MethodInfo? method = type.GetMethod("Day" + day);
            object? output = method?.Invoke(null, null);

            if (output?.GetType() == typeof(string))
            {
                File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "../../../Day" + day + "/output.txt"), output.ToString());
                Console.WriteLine($"DAY {day} OUTPUT");
                Console.WriteLine(output.ToString());
            }
            else
                Console.WriteLine("INVALID RETURN FORMAT!");
        }

        input = "";
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        Console.Clear();      
    }
    else
    {
        Console.Clear();
        input = "";
    }
}