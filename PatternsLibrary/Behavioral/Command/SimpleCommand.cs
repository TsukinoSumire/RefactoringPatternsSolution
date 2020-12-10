using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLibrary.Behavioral.Command
{
    public class SimpleCommand : ICommand
    {
        private string _actionStr = string.Empty;

        public SimpleCommand(string actionStr)
        {
            _actionStr = actionStr;
        }

        public void Execute()
        {
            Console.WriteLine("execute command with action: {0}", _actionStr);
        }

    }
}
