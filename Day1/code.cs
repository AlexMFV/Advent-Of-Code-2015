using Advent_Of_Code_2015;

internal partial class Program
{
    public static string Day1()
    {
        string text = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "../../../Day1/input.txt"));
        
        //---------Part 1 and 2----------
        int out1 = 0;
        int out2 = 1; //index
        bool done = false;
        foreach (char c in text)
        {
            if(!done && out1 == 0 && c == ')')
                done = true;

            if (c == '(')
                out1++;
            else if (c == ')')
                out1--;

            if(!done)
                out2++;
        }

        return Helper.Print(out1, out2);
    }
}