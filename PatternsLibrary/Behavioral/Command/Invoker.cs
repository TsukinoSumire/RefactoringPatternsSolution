using System;

namespace PatternsLibrary.Behavioral.Command
{
    /// <summary>
    /// логика для отправителя
    /// </summary>
    public class Invoker
    {
        ICommand _onStart;
        ICommand _onFinished;


        public void SetOnStart(ICommand onStart)
            => _onStart = onStart;

        public void SetOnFinish(ICommand onFinish)
            => _onFinished = onFinish;
        

        public void DoSomethingImportant()
        {

            Console.WriteLine("Invoker: DoSomethingImportant");
            Console.WriteLine("Invoker: On Start Execute");
            ExecuteCommand(_onStart);
            Console.WriteLine("Invoker: On Finish Execute");
            ExecuteCommand(_onFinished);

        }

        void ExecuteCommand(ICommand command)
        {
            if (command == null) return;
           
            command.Execute();
        }


    }
}
