using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace karl.MVVM
{
    internal class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExcute;

        public RelayCommand(Action<object> excute, Func<object, bool> canExcute=null) { 
        this.execute = excute;
        this.canExcute = canExcute;
        
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return canExcute == null || canExcute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
