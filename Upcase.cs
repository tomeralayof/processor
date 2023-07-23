namespace Processor_ {
internal class UpCase : Processor_.Processor {
    public override string Name()
    {
        return "UpCase";
    }

    public override string Process(string input)
    {
        return input.ToUpper();
    }
}

}
