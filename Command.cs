using System;
using System.Windows.Input;

namespace BringIntoViewMVVMExample
{
    // simepl implementation. Do not use in real code
    public class Command : ICommand
    {
        private readonly Action action;

        public Command(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }

        public event EventHandler CanExecuteChanged;
    }
}