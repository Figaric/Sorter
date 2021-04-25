using System;
using System.Windows.Input;

namespace Sorter.Core
{
    public class RelayCommand : ICommand
    {
        private readonly Action _action;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action action)
        {
            _action = action ?? throw new ArgumentNullException("Command action cannot be null.");
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            _action.Invoke();
        }
    }
}
