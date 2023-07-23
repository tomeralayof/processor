using System.Text;
using Processor_;

internal class StringSwapper : Processor {
    public string swap(string input) 
    {

            StringBuilder sb = new StringBuilder(input.Length);
            for(int i = input.Length - 1; i >= 0; i-- )
            {
                sb.Append(input[i]);
            }

            return sb.ToString();
    }

    public override string Name()
    {
        return "string swapper";
    }
}