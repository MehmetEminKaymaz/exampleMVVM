using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows.Input;
using WPFCore.Commands;
using WPFCore.Models;

namespace WPFCore.ViewModels
{
    internal class ProductViewModel : IDataErrorInfo, INotifyPropertyChanged
    {
        private ObservableCollection<Product> product;
        private Product selectedProduct;

        public ProductViewModel()
        { //default contructor 
            this.product = new ObservableCollection<Product>()
            {
                new Product("Süt", "Laktoz,protein,yağ", 15),
                new Product("Süt2", "Laktoz,protein,yağ", 17),
                new Product("Süt3", "Laktoz,protein,yağ", 18),
                new Product("Süt4", "Laktoz,protein,yağ", 19),
                new Product("Süt5", "Laktoz,protein,yağ", 20),
                new Product("Süt6", "Laktoz,protein,yağ", 21),
                new Product("Süt7", "Laktoz,protein,yağ", 22)

            };
            
            this.AddCommand = new addProduct(this);
            this.DeleteCommand = new deleteProduct(this);
        }

        public ICommand DeleteCommand
        {
            get;
            private set;
        }

        public void Delete()
        {
            Product.Remove(selectedProduct);
        }


        public bool StateDelete
        {
            get
            {
                if (selectedProduct == null)
                {
                    return false;
                }
                return Product.Contains(selectedProduct);
            }
        }

        public Product SelectedItem
        {
            get {
                return selectedProduct;
            }
            set
            {
                selectedProduct = value;
            }
        }


        private string txtName;

        public string TxtName
        {
            get
            {
                return txtName;
            }
            set
            {

                if (TxtName == value)
                {
                    return;

                }

                txtName = value;
                OnPropertyChanged("TxtName");

            }
        }

        public ICommand AddCommand
        {
            get;
            private set;
        }

        private decimal txtPrice;

        public string TxtPrice
        {
            get
            {
                return txtPrice.ToString();
            }
            set
            {

                if (txtPrice == decimal.Parse(value))
                {
                    return;
                }
                txtPrice = decimal.Parse(value);
                OnPropertyChanged("TxtPrice");

            }
        }

        private string txtContent;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string TxtContent
        {
            get
            {
                return txtContent;
            }
            set
            {
                if (txtContent == value)
                {
                    return;
                }
                txtContent = value;
                OnPropertyChanged("TxtContent");
            }
        }

        public ObservableCollection<Product> Product
        {
            get
            {
                return product;
            }
        }

        public void Add()
        {
            this.product.Add(new Product(txtName, txtContent, txtPrice));
        }

        public string Error
        {
            get;
            private set;
        }

        private bool c1, c2, c3;

        private bool errorState;
        public bool ErrorState
        {
            get
            {
                return errorState;
            }

        }

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {

                    case "TxtName":
                        if (String.IsNullOrWhiteSpace(TxtName))
                        {
                            Error = "Name can not be null or empty";
                            c1 = false;
                        }
                        else
                        {

                            Error = null;
                            c1 = true;
                            if (c2 && c3)
                            {

                                errorState = true;
                            }
                        }
                        break;

                    case "TxtPrice":
                        if (String.IsNullOrWhiteSpace(TxtPrice) || !decimal.TryParse(TxtPrice, out _))
                        {
                            Error = "Price can not be null or empty";
                            c2 = false;
                        }
                        else
                        {

                            Error = null;
                            c2 = true;
                            if (c1 && c3)
                            {



                                errorState = true;
                            }
                        }
                        break;
                    case "TxtContent":

                        if (String.IsNullOrWhiteSpace(TxtContent))
                        {
                            Error = "Content can not be null or empty";
                            c3 = false;
                        }
                        else
                        {

                            Error = null;
                            c3 = true;
                            if (c1 && c2)

                                errorState = true;
                        }
                        break;

                    default:
                        break;
                }








                return Error;
            }


        }
    }
}
