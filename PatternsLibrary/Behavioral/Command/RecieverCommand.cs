using System;

namespace PatternsLibrary.Behavioral.Command
{
    public class RecieverCommand: ICommand
    {
        string _firstActStr;
        string _secondActStr;
        Receiver _receiver;

        public RecieverCommand(Receiver receiver
            , string firstActStr, string secondActStr)
        {
            _receiver = receiver;
            _firstActStr = firstActStr;
            _secondActStr = secondActStr;
        }

        public void Execute()
        {
            Console.WriteLine("RecieverCommand: Command receiver object.");
            _receiver.DoSomething(_firstActStr);
            _receiver.AlsoDoSomething(_secondActStr);
        }
    }
}
