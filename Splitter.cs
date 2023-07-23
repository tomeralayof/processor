namespace Processor_ {
internal class Splitter : Processor {

    public override string Name()
    {
        return "splitter";
    }

    public override string Process(string input)
    {
        string[] words = input.Split(' ');
        return string.Join(", ", words);
    }
}
}
