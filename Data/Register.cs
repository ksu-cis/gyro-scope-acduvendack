/*
 * Register.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoundRegister;
using System.ComponentModel;
using GyroScope.Data;

/// <summary>
/// Namespace for IMenuItem, Order, Entrees, Drinks, Sides, etc.
/// </summary>
namespace GyroScope.Data
{
    /// <summary>
    /// Class for a Register object
    /// </summary>
    public class Register : INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies when a property of this class changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Used to trigger a PropertyChanged event
        /// </summary>
        /// <param name="propertyName">The name of the property that is changing</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Backing field for CustomerHundreds
        /// </summary>
        private decimal _customerHundreds;

        /// <summary>
        /// Property for customer hundreds
        /// </summary>
        public decimal CustomerHundreds
        {
            get => _customerHundreds;
            set
            {
                _customerHundreds = value;
                OnPropertyChanged("CustomerHundreds");
            }
        }

        /// <summary>
        /// Backing field for CustomerFifties
        /// </summary>
        private decimal _customerFifties;

        /// <summary>
        /// Property for customer fifties
        /// </summary>
        public decimal CustomerFifties
        {
            get => _customerFifties;
            set
            {
                _customerFifties = value;
                OnPropertyChanged("CustomerFifties");
            }
        }

        /// <summary>
        /// Backing field for CustomerTwenties
        /// </summary>
        private decimal _customerTwenties;

        /// <summary>
        /// Property for customer twenties
        /// </summary>
        public decimal CustomerTwenties
        {
            get => _customerTwenties;
            set
            {
                _customerTwenties = value;
                OnPropertyChanged("CustomerTwenties");
            }
        }

        /// <summary>
        /// Backing field for CustomerTens
        /// </summary>
        private decimal _customerTens;

        /// <summary>
        /// Property for customer tens
        /// </summary>
        public decimal CustomerTens
        {
            get => _customerTens;
            set
            {
                _customerTens = value;
                OnPropertyChanged("CustomerTens");
            }
        }

        /// <summary>
        /// Backing field for CustomerFives
        /// </summary>
        private decimal _customerFives;

        /// <summary>
        /// Property for customer fives
        /// </summary>
        public decimal CustomerFives
        {
            get => _customerFives;
            set
            {
                _customerFives = value;
                OnPropertyChanged("CustomerFives");
            }
        }

        /// <summary>
        /// Backing field for CustomerTwos
        /// </summary>
        private decimal _customerTwos;

        /// <summary>
        /// Property for customer twos
        /// </summary>
        public decimal CustomerTwos
        {
            get => _customerTwos;
            set
            {
                _customerTwos = value;
                OnPropertyChanged("CustomerTwos");
            }
        }

        /// <summary>
        /// Backing field for CustomerOnes
        /// </summary>
        private decimal _customerOnes;

        /// <summary>
        /// Property for customer ones
        /// </summary>
        public decimal CustomerOnes
        {
            get => _customerOnes;
            set
            {
                _customerOnes = value;
                OnPropertyChanged("CustomerOnes");
            }
        }

        /// <summary>
        /// Backing field for CustomerDollarCoins
        /// </summary>
        private decimal _customerDollarCoins;

        /// <summary>
        /// Property for customer dollar coins
        /// </summary>
        public decimal CustomerDollarCoins
        {
            get => _customerDollarCoins;
            set
            {
                _customerDollarCoins = value;
                OnPropertyChanged("CustomerDollarCoins");
            }
        }

        /// <summary>
        /// Backing field for CustomerHalfDollars
        /// </summary>
        private decimal _customerHalfDollars;

        /// <summary>
        /// Property for customer half dollars
        /// </summary>
        public decimal CustomerHalfDollars
        {
            get => _customerHalfDollars;
            set
            {
                _customerHalfDollars = value;
                OnPropertyChanged("CustomerHalfDollars");
            }
        }

        /// <summary>
        /// Backing field for CustomerQuarters
        /// </summary>
        private decimal _customerQuarters;

        /// <summary>
        /// Property for customer quarters
        /// </summary>
        public decimal CustomerQuarters
        {
            get => _customerQuarters;
            set
            {
                _customerQuarters = value;
                OnPropertyChanged("CustomerQuarters");
            }
        }

        /// <summary>
        /// Backing field for CustomerDimes
        /// </summary>
        private decimal _customerDimes;

        /// <summary>
        /// Property for customer dimes
        /// </summary>
        public decimal CustomerDimes
        {
            get => _customerDimes;
            set
            {
                _customerDimes = value;
                OnPropertyChanged("CustomerDimes");
            }
        }

        /// <summary>
        /// Backing field for CustomerNickels
        /// </summary>
        private decimal _customerNickels;

        /// <summary>
        /// Property for customer nickels
        /// </summary>
        public decimal CustomerNickels
        {
            get => _customerNickels;
            set
            {
                _customerNickels = value;
                OnPropertyChanged("CustomerNickels");
            }
        }

        /// <summary>
        /// Backing field for CustomerPennies
        /// </summary>
        private decimal _customerPennies;

        /// <summary>
        /// Property for customer pennies
        /// </summary>
        public decimal CustomerPennies
        {
            get => _customerPennies;
            set
            {
                _customerPennies = value;
                OnPropertyChanged("CustomerPennies");
            }
        }

        /// <summary>
        /// Property for the drawer hundreds
        /// </summary>
        public decimal DrawerHundreds
        {
            get { return CashDrawer.Hundreds; }
        }

        /// <summary>
        /// Property for the drawer fifties
        /// </summary>
        public decimal DrawerFifties
        {
            get { return CashDrawer.Fifties; }
        }

        /// <summary>
        /// Property for the drawer twenties
        /// </summary>
        public decimal DrawerTwenties
        {
            get { return CashDrawer.Twenties; }
        }

        /// <summary>
        /// Property for the drawer tens
        /// </summary>
        public decimal DrawerTens
        {
            get { return CashDrawer.Tens; }
        }

        /// <summary>
        /// Property for the drawer fives
        /// </summary>
        public decimal DrawerFives
        {
            get { return CashDrawer.Fives; }
        }

        /// <summary>
        /// Property for the drawer twos
        /// </summary>
        public decimal DrawerTwos
        {
            get { return CashDrawer.Twos; }
        }

        /// <summary>
        /// Property for the drawer ones
        /// </summary>
        public decimal DrawerOnes
        {
            get { return CashDrawer.Ones; }
        }

        /// <summary>
        /// Property for the drawer dollar coins
        /// </summary>
        public decimal DrawerDollarCoins
        {
            get { return CashDrawer.Dollars; }
        }

        /// <summary>
        /// Property for the drawer half dollars
        /// </summary>
        public decimal DrawerHalfDollars
        {
            get { return CashDrawer.HalfDollars; }
        }

        /// <summary>
        /// Property for the drawer quarters
        /// </summary>
        public decimal DrawerQuarters
        {
            get { return CashDrawer.Quarters; }
        }

        /// <summary>
        /// Property for the drawer dimes
        /// </summary>
        public decimal DrawerDimes
        {
            get { return CashDrawer.Dimes; }
        }

        /// <summary>
        /// Property for the drawer nickels
        /// </summary>
        public decimal DrawerNickels
        {
            get { return CashDrawer.Nickels; }
        }

        /// <summary>
        /// Property for the drawer pennies
        /// </summary>
        public decimal DrawerPennies
        {
            get { return CashDrawer.Pennies; }
        }

        /// <summary>
        /// Backing field for ChangeHundreds
        /// </summary>
        private decimal _changeHundreds;

        /// <summary>
        /// Property for the change hundreds
        /// </summary>
        public decimal ChangeHundreds
        {
            get => _changeHundreds;

            set
            {
                _changeHundreds = value;
                OnPropertyChanged("ChangeHundreds");
            }
        }

        /// <summary>
        /// Backing field for ChangeFifties
        /// </summary>
        private decimal _changeFifties;

        /// <summary>
        /// Property for the change fifties
        /// </summary>
        public decimal ChangeFifties
        {
            get => _changeFifties;

            set
            {
                _changeFifties = value;
                OnPropertyChanged("ChangeFifties");
            }
        }

        /// <summary>
        /// Backing field for ChangeTwenties
        /// </summary>
        private decimal _changeTwenties;

        /// <summary>
        /// Property for the change twenties
        /// </summary>
        public decimal ChangeTwenties
        {
            get => _changeTwenties;

            set
            {
                _changeTwenties = value;
                OnPropertyChanged("ChangeTwenties");
            }
        }

        /// <summary>
        /// Backing field for ChangeTens
        /// </summary>
        private decimal _changeTens;

        /// <summary>
        /// Property for the change tens
        /// </summary>
        public decimal ChangeTens
        {
            get => _changeTens;

            set
            {
                _changeTens = value;
                OnPropertyChanged("ChangeTens");
            }
        }

        /// <summary>
        /// Backing field for ChangeFives
        /// </summary>
        private decimal _changeFives;

        /// <summary>
        /// Property for the change fives
        /// </summary>
        public decimal ChangeFives
        {
            get => _changeFives;

            set
            {
                _changeFives = value;
                OnPropertyChanged("ChangeFives");
            }
        }

        /// <summary>
        /// Backing field for ChangeTwos
        /// </summary>
        private decimal _changeTwos;

        /// <summary>
        /// Property for the change twos
        /// </summary>
        public decimal ChangeTwos
        {
            get => _changeTwos;

            set
            {
                _changeTwos = value;
                OnPropertyChanged("ChangeTwos");
            }
        }

        /// <summary>
        /// Backing field for ChangeOnes
        /// </summary>
        private decimal _changeOnes;

        /// <summary>
        /// Property for the change ones
        /// </summary>
        public decimal ChangeOnes
        {
            get => _changeOnes;

            set
            {
                _changeOnes = value;
                OnPropertyChanged("ChangeOnes");
            }
        }

        /// <summary>
        /// Backing field for ChangeDollarCoins
        /// </summary>
        private decimal _changeDollarCoins;

        /// <summary>
        /// Property for the change dollar coins
        /// </summary>
        public decimal ChangeDollarCoins
        {
            get => _changeDollarCoins;

            set
            {
                _changeDollarCoins = value;
                OnPropertyChanged("ChangeDollarCoins");
            }
        }

        /// <summary>
        /// Backing field for ChangeHalfDollars
        /// </summary>
        private decimal _changeHalfDollars;

        /// <summary>
        /// Property for the change half dollars
        /// </summary>
        public decimal ChangeHalfDollars
        {
            get => _changeHalfDollars;

            set
            {
                _changeHalfDollars = value;
                OnPropertyChanged("ChangeHalfDollars");
            }
        }

        /// <summary>
        /// Backing field for ChangeQuarters
        /// </summary>
        private decimal _changeQuarters;

        /// <summary>
        /// Property for the change quarters
        /// </summary>
        public decimal ChangeQuarters
        {
            get => _changeQuarters;

            set
            {
                _changeQuarters = value;
                OnPropertyChanged("ChangeQuarters");
            }
        }

        /// <summary>
        /// Backing field for ChangeDimes
        /// </summary>
        private decimal _changeDimes;

        /// <summary>
        /// Property for the change dimes
        /// </summary>
        public decimal ChangeDimes
        {
            get => _changeDimes;

            set
            {
                _changeDimes = value;
                OnPropertyChanged("ChangeDimes");
            }
        }

        /// <summary>
        /// Backing field for ChangeNickels
        /// </summary>
        private decimal _changeNickels;

        /// <summary>
        /// Property for the change nickels
        /// </summary>
        public decimal ChangeNickels
        {
            get => _changeNickels;

            set
            {
                _changeNickels = value;
                OnPropertyChanged("ChangeNickels");
            }
        }

        /// <summary>
        /// Backing field for ChangePennies
        /// </summary>
        private decimal _changePennies;

        /// <summary>
        /// Property for the change pennies
        /// </summary>
        public decimal ChangePennies
        {
            get => _changePennies;

            set
            {
                _changePennies = value;
                OnPropertyChanged("ChangePennies");
            }
        }

        /// <summary>
        /// Backing field for AmountDue
        /// </summary>
        private decimal _amountDue;

        /// <summary>
        /// Property for the amount the customer owes still
        /// </summary>
        public decimal AmountDue
        {
            get
            {
                return _amountDue;
            }

            set
            {
                _amountDue = value;
                OnPropertyChanged("AmountDue");
            }
        }

        /// <summary>
        /// Backing field for ChangeOwed
        /// </summary>
        private decimal _changeOwed = 0.00m;

        /// <summary>
        /// Property for the change owed to the customer
        /// </summary>
        public decimal ChangeOwed
        {
            get
            {
                return _changeOwed;
            }

            private set
            {
                _changeOwed = value;
                OnPropertyChanged("ChangeOwed");
            }
        }

        /// <summary>
        /// Finalizes the transaction
        /// </summary>
        public void FinalizeTransaction()
        {
            CashDrawer.OpenDrawer();
            CashDrawer.Hundreds = (int)(DrawerHundreds + (CustomerHundreds - ChangeHundreds));
            CashDrawer.Fifties = (int)(DrawerFifties + (CustomerFifties - ChangeFifties));
            CashDrawer.Twenties = (int)(DrawerTwenties + (CustomerTwenties - ChangeTwenties));
            CashDrawer.Tens = (int)(DrawerTens + (CustomerTens - ChangeTens));
            CashDrawer.Fives = (int)(DrawerFives + (CustomerFives - ChangeFives));
            CashDrawer.Twos = (int)(DrawerTwos + (CustomerTwos - ChangeTwos));
            CashDrawer.Ones = (int)(DrawerOnes + (CustomerOnes - ChangeOnes));
            CashDrawer.Dollars = (int)(DrawerDollarCoins + (CustomerDollarCoins - ChangeDollarCoins));
            CashDrawer.HalfDollars = (int)(DrawerHalfDollars + (CustomerHalfDollars - ChangeHalfDollars));
            CashDrawer.Quarters = (int)(DrawerQuarters + (CustomerQuarters - ChangeQuarters));
            CashDrawer.Dimes = (int)(DrawerDimes + (CustomerDimes - ChangeDimes));
            CashDrawer.Nickels = (int)(DrawerNickels + (CustomerNickels - ChangeNickels));
            CashDrawer.Pennies = (int)(DrawerPennies + (CustomerPennies - ChangePennies));
        }

        /// <summary>
        /// Gets the change for a customer
        /// </summary>
        /// <param name="total">The total bill</param>
        public void GetChange(decimal total)
        {
            decimal customerTotal = (CustomerHundreds * 100) + (CustomerFifties * 50) + (CustomerTwenties * 20) + (CustomerTens * 10) + (CustomerFives * 5) + (CustomerTwos * 2) + (CustomerOnes * 1) + (CustomerDollarCoins * 1)
                + (CustomerHalfDollars * .5m) + (CustomerQuarters * .25m) + (CustomerDimes * .10m) + (CustomerNickels * .05m) + (CustomerPennies * .01m);
           
            decimal changeTotal = customerTotal - total;

            if (changeTotal >= 0)
            {
                ChangeOwed = changeTotal;
                AmountDue = 0.00m;

                if ((DrawerHundreds + CustomerHundreds) >= (int)changeTotal / 100)
                {
                    ChangeHundreds = (int)changeTotal / 100;
                    changeTotal = changeTotal % 100;
                }
                else if (DrawerHundreds > 0)
                {
                    ChangeHundreds = DrawerHundreds;
                    changeTotal = (changeTotal % 100) + (100 * (((int)changeTotal / 100) - ChangeHundreds));
                }

                if ((DrawerFifties + CustomerFifties) >= (int)changeTotal / 50)
                {
                    ChangeFifties = (int)changeTotal / 50;
                    changeTotal = changeTotal % 50;
                }
                else if (DrawerFifties > 0)
                {
                    ChangeFifties = DrawerFifties;
                    changeTotal = (changeTotal % 50) + (50 * (((int)changeTotal / 50) - ChangeFifties));
                }

                if ((DrawerTwenties + CustomerTwenties) >= (int)changeTotal / 20)
                {
                    ChangeTwenties = (int)changeTotal / 20;
                    changeTotal = changeTotal % 20;
                }
                else if (DrawerTwenties > 0)
                {
                    ChangeTwenties = DrawerTwenties;
                    changeTotal = (changeTotal % 20) + (20 * (((int)changeTotal / 20) - ChangeTwenties));
                }

                if ((DrawerTens + CustomerTens) >= (int)changeTotal / 10)
                {
                    ChangeTens = (int)changeTotal / 10;
                    changeTotal = changeTotal % 10;
                }
                else if (DrawerTens > 0)
                {
                    ChangeTens = DrawerTens;
                    changeTotal = (changeTotal % 10) + (10 * (((int)changeTotal / 10) - ChangeTens));
                }

                if ((DrawerFives + CustomerFives) >= (int)changeTotal / 5)
                {
                    ChangeFives = (int)changeTotal / 5;
                    changeTotal = changeTotal % 5;
                }
                else if (DrawerFives > 0)
                {
                    ChangeFives = DrawerFives;
                    changeTotal = (changeTotal % 5) + (5 * (((int)changeTotal / 5) - ChangeFives));
                }

                if ((DrawerTwos + CustomerTwos) >= (int)changeTotal / 2)
                {
                    ChangeTwos = (int)changeTotal / 2;
                    changeTotal = changeTotal % 2;
                }
                else if (DrawerTwos > 0)
                {
                    ChangeTwos = DrawerTwos;
                    changeTotal = (changeTotal % 2) + (2 * (((int)changeTotal / 2) - ChangeTwos));
                }

                if ((DrawerOnes + CustomerOnes) >= (int)changeTotal / 1)
                {
                    ChangeOnes = (int)changeTotal / 1;
                    changeTotal = changeTotal % 1;
                }
                else if (DrawerOnes > 0)
                {
                    ChangeOnes = DrawerOnes;
                    changeTotal = (changeTotal % 1) + (1 * (((int)changeTotal / 1) - ChangeOnes));
                }

                if ((DrawerDollarCoins + CustomerDollarCoins) >= (int)changeTotal / 1)
                {
                    ChangeDollarCoins = (int)changeTotal / 1;
                    changeTotal = changeTotal % 1;
                }
                else if (DrawerDollarCoins > 0)
                {
                    ChangeDollarCoins = DrawerDollarCoins;
                    changeTotal = (changeTotal % 1) + (1 * (((int)changeTotal / 1) - ChangeDollarCoins));
                }

                if ((DrawerHalfDollars + CustomerHalfDollars) >= ((int)(changeTotal * 10) / 5))
                {
                    ChangeHalfDollars = ((int)(changeTotal * 10) / 5);
                    changeTotal = changeTotal % .5m;
                }
                else if (DrawerHalfDollars > 0)
                {
                    ChangeHalfDollars = DrawerHalfDollars;
                    changeTotal = (changeTotal % .5m) + (.5m * (((int)(changeTotal * 10) / 5) - ChangeHalfDollars));
                }

                if ((DrawerQuarters + CustomerQuarters) >= ((int)(changeTotal * 100) / 25))
                {
                    ChangeQuarters = ((int)(changeTotal * 100) / 25);
                    changeTotal = changeTotal % .25m;
                }
                else if (DrawerQuarters > 0)
                {
                    ChangeQuarters = DrawerQuarters;
                    changeTotal = (changeTotal % .25m) + (.25m * (((int)(changeTotal * 100) / 25) - ChangeQuarters));
                }

                if ((DrawerDimes + CustomerDimes) >= ((int)(changeTotal * 10) / 1))
                {
                    ChangeDimes = ((int)(changeTotal * 10) / 1);
                    changeTotal = changeTotal % .1m;
                }
                else if (DrawerDimes > 0)
                {
                    ChangeDimes = DrawerDimes;
                    changeTotal = (changeTotal % .1m) + (.1m * (((int)(changeTotal * 10) / 1) - ChangeDimes));
                }

                if ((DrawerNickels + CustomerNickels) >= ((int)(changeTotal * 100) / 5))
                {
                    ChangeNickels = ((int)(changeTotal * 100) / 5);
                    changeTotal = changeTotal % .05m;
                }
                else if (DrawerNickels > 0)
                {
                    ChangeNickels = DrawerNickels;
                    changeTotal = (changeTotal % .05m) + (.05m * (((int)(changeTotal * 100) / 5) - ChangeHalfDollars));
                }

                if ((DrawerPennies + CustomerPennies) >= ((int)(changeTotal * 100) / 1))
                {
                    ChangePennies = ((int)(changeTotal * 100) / 1);
                    changeTotal = changeTotal % .01m;
                }
                else if (DrawerPennies > 0)
                {
                    ChangePennies = DrawerPennies;
                }

            }
            else
            {
                AmountDue = changeTotal * -1;
                ChangeHundreds = 0;
                ChangeFifties = 0;
                ChangeTwenties = 0;
                ChangeTens = 0;
                ChangeFives = 0;
                ChangeTwos = 0;
                ChangeOnes = 0;
                ChangeDollarCoins = 0;
                ChangeHalfDollars = 0;
                ChangeQuarters = 0;
                ChangeDimes = 0;
                ChangeNickels = 0;
                ChangePennies = 0;
                ChangeOwed = 0.00m;
            }
        }
    }
}
