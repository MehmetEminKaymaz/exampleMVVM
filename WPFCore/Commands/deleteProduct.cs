using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPFCore.ViewModels;

namespace WPFCore.Commands
{
    class deleteProduct:ICommand
    {
        private ProductViewModel viewModel;
        public deleteProduct(ProductViewModel viewModel)
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
                CommandManager.RequerySuggested -= value;
            }
        }



        public bool CanExecute(object parameter)
        {
            return viewModel.StateDelete;
        }

        public void Execute(object parameter)
        {
            viewModel.Delete();
        }
    }
}
