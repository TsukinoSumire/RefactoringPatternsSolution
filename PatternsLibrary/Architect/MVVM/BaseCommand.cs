using System;
using System.Windows.Input;

namespace PatternsLibrary.Architect.MVVM
{
    public class BaseCommand : ICommand
    {
        Action<object> _execute;
        Func<object, bool> _canExecute;

        public BaseCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            if (execute == null || canExecute == null) 
                throw new NullReferenceException("execute or canExecute command is null");

            _execute = execute;
            _canExecute = canExecute; 
        }

        #region ICommand
        //обязательно, особенно если нужна логика на доступность команды/ кнопки
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter) => _canExecute(parameter);

        public void Execute(object parameter) => _execute(parameter);
        #endregion

        #region using example in view model        
        //ICommand _ExampleCommand { get; set; }
        //public ICommand ExampleCommand
        //{
        //    get => _ExampleCommand;
        //    set { _ExampleCommand = value; RaiseOnPropertyChanged(); }
        //}

        //void InitCommands()
        //{
        //    ExampleCommand = new BaseCommand(/*async*/ param => { /*action*/}, param=> true /*or return bool */);
        //}  
        #endregion
    }
}
