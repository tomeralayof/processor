using Processor_;

internal class Program
{
    static void Main(string[] args)
    {
         string input = "Hello World! This is a test.";
        
         Processor processor = new Processor();
         UpCase upCaseProcessor = new UpCase();
         DownCase downCaseProcessor = new DownCase();
         Splitter splitterProcessor = new Splitter();

         Tester.Process(processor, input);
         Tester.Process(upCaseProcessor, input);
         Tester.Process(downCaseProcessor, input);
         Tester.Process(splitterProcessor, input);

         StringSwapper swapper = new StringSwapper();
         StringSwapperWrapper swapperWrapper = new StringSwapperWrapper(swapper);

         Tester.Process(swapperWrapper, input);

    }
}