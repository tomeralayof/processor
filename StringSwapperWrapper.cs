namespace Processor_ {
    internal class StringSwapperWrapper : Processor {

        private StringSwapper stringSwapper;

        public StringSwapperWrapper(StringSwapper stringSwapper)
        {
            this.stringSwapper = stringSwapper;
        }

        public override string Process(string input)
        {
            return stringSwapper.swap(input);
        }

        public override string Name()
        {
            return stringSwapper.Name();
        }
    }

    };