namespace Processor_ {

class DownCase : Processor {
    public override string Name()
    {
        return "downCase";
    }

    public override string Process(string input)
    {
        return input.ToLower();
    }
}
}
