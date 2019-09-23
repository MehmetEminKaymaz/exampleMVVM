using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPFCore.Models
{
    public class Product :INotifyPropertyChanged,IDataErrorInfo
    {

        private decimal price;
        private string name;
        private string content;

        public Product(string name,string content , decimal price){ //default constructor


            this.name = name;
            this.content = content;
            this.price = price;

        }

        

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                if (content == value)
                {
                    return;
                }

                content = value;
                OnPropertyChanged("Content");

            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name == value)
                {
                    return;
                }

                name = value;
                OnPropertyChanged("Name");

            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price == value)
                {
                    return;
                }

                price = value;
                OnPropertyChanged("Price");

            }
        }


        public string this[string columnName] {
            get
            {
               switch (columnName){
                    case "Name":
                        if (String.IsNullOrWhiteSpace(Name))
                        {
                            Error = "Name can not be null or empty";
                        }
                        else
                        {
                            Error = null;
                        }
                        break;
                    case "Price":
                        if (String.IsNullOrWhiteSpace(Name))
                        {
                            Error = "Price can not be null or empty";
                        }
                        else
                        {
                            Error = null;
                        }
                        break;
                    case "Content":
                        if (String.IsNullOrWhiteSpace(Name))
                        {
                            Error = "Content can not be null or empty";
                        }
                        else
                        {
                            Error = null;
                        }
                        break;
                    default:
                       
                        break;
                }
                return Error;
            }
        }
        public string Error
        {
            get;
            private set;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
