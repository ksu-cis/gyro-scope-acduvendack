/*
 * Order.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections.Specialized;
using RoundRegister;

/// <summary>
/// Namespace for IMenuItem, Order, Entrees, Drinks, Sides, etc.
/// </summary>
namespace GyroScope.Data
{
    /// <summary>
    /// Class for an Order object
    /// </summary>
    public class Order : ObservableCollection<IMenuItem>, ICollection<IMenuItem>, INotifyCollectionChanged, INotifyPropertyChanged 
    {
        /// <summary>
        /// Constructor for Order object
        /// </summary>
        public Order()
        {
            Number = _nextOrderNumber;
            _nextOrderNumber++;
            this.CollectionChanged += OnCollectionChanged;
        }

        /// <summary>
        /// Backing field for the SalesTaxRate property
        /// </summary>
        private decimal _salesTaxRate = .09m;

        /// <summary>
        /// Property for a sales tax rate
        /// </summary>
        public decimal SalesTaxRate
        {
            get
            {
                return this._salesTaxRate;
            }

            set
            {
                if (_salesTaxRate != value)
                {
                    this._salesTaxRate = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SalesTaxRate"));
                }
                    
            }
        }

        /// <summary>
        /// Property for the subtotal of the order
        /// </summary>
        public decimal Subtotal
        {
            get
            {
                decimal subtotal = 0.00m;
                foreach(IMenuItem item in this)
                {
                    subtotal += item.Price;
                }
                return decimal.Round(subtotal, 2, MidpointRounding.AwayFromZero);
            }
        }

        /// <summary>
        /// Property for the tax on the order
        /// </summary>
        public decimal Tax
        {
            get
            {
                return decimal.Round(Subtotal * SalesTaxRate, 2, MidpointRounding.AwayFromZero);
            }
        }

        /// <summary>
        /// Property for the total of the order
        /// </summary>
        public decimal Total
        {
            get
            {
                return Subtotal + Tax;
            }
        }

        /// <summary>
        /// Property for the calories of the order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach(IMenuItem item in this)
                {
                    calories += item.Calories;
                }
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                return calories;
            }
        }

        /// <summary>
        /// Backing field for the Number property
        /// </summary>
        private static int _nextOrderNumber = 1;

        /// <summary>
        /// Property to distinguish the order number
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// Property for the time the order was placed
        /// </summary>
        public DateTime PlacedAt
        {
            get
            {
                return DateTime.Now;
            }
        }
        
        /// <summary>
        /// Event listener for collection change event
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The event</param>
        protected virtual void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (IMenuItem item in this)
            {
                ((INotifyPropertyChanged)item).PropertyChanged += CollectionItemChangedListener;
            }
            OnPropertyChanged(new PropertyChangedEventArgs("Count"));
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Event listener for property change events of items within the collection
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The event</param>
        protected virtual void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            }
            else if (e.PropertyName == "Calories") {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Prints the receipt for the order
        /// </summary>
        /// <param name="cashOrCredit">The type of payment</param>
        /// <param name="changeOwed">The change owed for cash payment</param>
        public void PrintReceipt(string cashOrCredit, string changeOwed)
        {
            RecieptPrinter.PrintLine("Order #" + Number.ToString());
            RecieptPrinter.PrintLine(PlacedAt.ToString());
            RecieptPrinter.PrintLine("");
            foreach (IMenuItem item in this)
            {
                RecieptPrinter.PrintLine(item.ToString());
                RecieptPrinter.PrintLine("  Price: $" + item.Price.ToString());
                
                foreach(string specialRequest in item.SpecialInstructions)
                {
                    RecieptPrinter.PrintLine("      " + specialRequest);
                }

                RecieptPrinter.PrintLine("");
            }
            
            RecieptPrinter.PrintLine("Subtotal: $" + Subtotal.ToString());
            RecieptPrinter.PrintLine("Tax: $" + Tax.ToString());
            RecieptPrinter.PrintLine("Total: $" + Total.ToString());
            RecieptPrinter.PrintLine("Payment Type: " + cashOrCredit);
            RecieptPrinter.PrintLine("Change Given: $" + changeOwed);
            RecieptPrinter.CutTape();
        }
    }
}
