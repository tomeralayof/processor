namespace Processor_
{
    internal class Processor
    {
        public virtual string Name()
        {
            return "processor";
        }

        public virtual string Process(string input)
        {
            return "process";
        }
    }
}