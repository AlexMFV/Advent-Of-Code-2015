using Advent_Of_Code_2015;

internal partial class Program
{
    public static string Day2()
    {
        string text = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "../../../Day2/input.txt"));

        string[] lines = text.Split('\n'); //Separate for each gift

        List<Tuple<int, int, int>> gift_dims = new List<Tuple<int, int, int>>(); //l, w, h

        foreach (string line in lines)
        {
            if (line == "")
                break;

            string[] dims = line.Split('x');
            int l = int.Parse(dims[0]);
            int w = int.Parse(dims[1]);
            int h = int.Parse(dims[2]);

            gift_dims.Add(new Tuple<int, int, int>(l, w, h));
        }

        int total_paper = 0;
        int ribbon = 0;

        foreach(Tuple<int, int, int> dims in gift_dims)
        {
            int area1 = dims.Item1 * dims.Item2;
            int area2 = dims.Item2 * dims.Item3;
            int area3 = dims.Item3 * dims.Item1;

            total_paper += (2*area1) + (2*area2) + (2*area3);

            int min = Math.Min(area1, area2);
            total_paper += Math.Min(min, area3);

            int min1 = Math.Min(dims.Item1, dims.Item2);
            int auxMax = Math.Max(dims.Item1, dims.Item2);
            int min2 = Math.Min(auxMax, dims.Item3);

            ribbon += (min1*2) + (min2*2) + (dims.Item1 * dims.Item2 * dims.Item3); //Add ribbon + bow
        }

        return Helper.Print(total_paper, ribbon);
    }
}