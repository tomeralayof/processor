using Processor_;

internal static class Tester
{
    public static void Process(Processor p, string s)
    {
        Console.WriteLine("Using Processor: " + p.Name());
        Console.WriteLine(p.Process(s));
    }
}