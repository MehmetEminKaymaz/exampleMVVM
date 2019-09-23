using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPFCore.ViewModels;

namespace WPFCore.Commands
{
    class addProduct :ICommand
    {

        private ProductViewModel viewModel;

        public addProduct(ProductViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested += value;
            }
        }

        

        public bool CanExecute(object parameter)
        {
            return viewModel.ErrorState;
        }

        public void Execute(object parameter)
        {
            viewModel.Add();
        }
    }
}
