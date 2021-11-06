using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoundRegister;
using System.ComponentModel;
using GyroScope.Data;

namespace GyroScope.Data
{
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

        private decimal _customerHundreds;

        public decimal CustomerHundreds
        {
            get => _customerHundreds;
            set
            {
                _customerHundreds = value;
                OnPropertyChanged("CustomerHundreds");
                OnPropertyChanged("ChangeHundreds");
            }
        }

        private decimal _customerFifties;

        public decimal CustomerFifties
        {
            get => _customerFifties;
            set
            {
                _customerFifties = value;
                OnPropertyChanged("CustomerFifties");
            }
        }

        private decimal _customerTwenties;

        public decimal CustomerTwenties
        {
            get => _customerTwenties;
            set
            {
                _customerTwenties = value;
                OnPropertyChanged("CustomerTwenties");
            }
        }

        private decimal _customerTens;

        public decimal CustomerTens
        {
            get => _customerTens;
            set
            {
                _customerTens = value;
                OnPropertyChanged("CustomerTens");
            }
        }

        private decimal _customerFives;

        public decimal CustomerFives
        {
            get => _customerFives;
            set
            {
                _customerFives = value;
                OnPropertyChanged("CustomerFives");
            }
        }

        private decimal _customerTwos;

        public decimal CustomerTwos
        {
            get => _customerTwos;
            set
            {
                _customerTwos = value;
                OnPropertyChanged("CustomerTwos");
            }
        }

        private decimal _customerOnes;

        public decimal CustomerOnes
        {
            get => _customerOnes;
            set
            {
                _customerOnes = value;
                OnPropertyChanged("CustomerOnes");
            }
        }

        private decimal _customerDollarCoins;

        public decimal CustomerDollarCoins
        {
            get => _customerDollarCoins;
            set
            {
                _customerDollarCoins = value;
                OnPropertyChanged("CustomerDollarCoins");
            }
        }

        private decimal _customerHalfDollars;

        public decimal CustomerHalfDollars
        {
            get => _customerHalfDollars;
            set
            {
                _customerHalfDollars = value;
                OnPropertyChanged("CustomerHalfDollars");
            }
        }

        private decimal _customerQuarters;

        public decimal CustomerQuarters
        {
            get => _customerQuarters;
            set
            {
                _customerQuarters = value;
                OnPropertyChanged("CustomerQuarters");
            }
        }

        private decimal _customerDimes;

        public decimal CustomerDimes
        {
            get => _customerDimes;
            set
            {
                _customerDimes = value;
                OnPropertyChanged("CustomerDimes");
            }
        }

        private decimal _customerNickels;

        public decimal CustomerNickels
        {
            get => _customerNickels;
            set
            {
                _customerNickels = value;
                OnPropertyChanged("CustomerNickels");
            }
        }

        private decimal _customerPennies;

        public decimal CustomerPennies
        {
            get => _customerPennies;
            set
            {
                _customerPennies = value;
                OnPropertyChanged("CustomerPennies");
            }
        }

        public decimal DrawerHundreds { get; set; }

        public decimal DrawerFifties { get; set; }

        public decimal DrawerTwenties { get; set; }

        public decimal DrawerTens { get; set; }

        public decimal DrawerFives { get; set; }

        public decimal DrawerTwos { get; set; }

        public decimal DrawerOnes { get; set; }

        public decimal DrawerDollarCoins { get; set; }

        public decimal DrawerHalfDollars { get; set; }

        public decimal DrawerQuarters { get; set; }

        public decimal DrawerDimes { get; set; }

        public decimal DrawerNickels { get; set; }

        public decimal DrawerPennies { get; set; }

        private decimal _changeHundreds;

        public decimal ChangeHundreds
        {
            get => _changeHundreds;

            set
            {
                if (CustomerHundreds <= 0)
                {
                    _changeHundreds = 0;
                }
                else
                {
                    _changeHundreds = CustomerHundreds - Math.Floor(value / 100) - 1;
                }
                
                OnPropertyChanged("ChangeHundreds");
            }
        }

        private decimal _changeFifties;

        public decimal ChangeFifties
        {
            get => _changeFifties;

            set
            {
                if (CustomerFifties <= 0)
                {
                    _changeFifties = 0;
                }
                else
                {
                    _changeFifties = CustomerFifties - Math.Floor((value - CustomerHundreds) / 50);
                }
                
            }
        }

        private decimal _changeTwenties;

        public decimal ChangeTwenties
        {
            get => _changeTwenties;

            set
            {
                _changeTwenties = CustomerTwenties - ((int)value / 20);
            }
        }

        private decimal _changeTens;

        public decimal ChangeTens
        {
            get => _changeTens;

            set
            {
                _changeTens = CustomerTens - ((int)value / 10);
            }
        }

        private decimal _changeFives;

        public decimal ChangeFives
        {
            get => _changeFives;

            set
            {
                _changeFives = CustomerFives - ((int)value / 5);
            }
        }

        private decimal _changeTwos;

        public decimal ChangeTwos
        {
            get => _changeTwos;

            set
            {
                _changeTwos = CustomerTwos - ((int)value / 2);
            }
        }

        private decimal _changeOnes;

        public decimal ChangeOnes
        {
            get => _changeOnes;

            set
            {
                _changeOnes = CustomerOnes - ((int)value / 1);
            }
        }

        private decimal _changeDollarCoins;

        public decimal ChangeDollarCoins
        {
            get => _changeDollarCoins;

            set
            {
                _changeDollarCoins = CustomerDollarCoins - ((int)value / 1);
            }
        }

        private decimal _changeHalfDollars;

        public decimal ChangeHalfDollars
        {
            get => _changeHalfDollars;

            set
            {
                _changeHalfDollars = CustomerHalfDollars - (value % 1);
            }
        }

        private decimal _changeQuarters;

        public decimal ChangeQuarters
        {
            get => _changeQuarters;

            set
            {
                _changeQuarters = CustomerQuarters - (value % 1);
            }
        }

        private decimal _changeDimes;

        public decimal ChangeDimes
        {
            get => _changeDimes;

            set
            {
                _changeDimes = CustomerDimes - (value % 1);
            }
        }

        private decimal _changeNickels;

        public decimal ChangeNickels
        {
            get => _changeNickels;

            set
            {
                _changeNickels = CustomerNickels - (value % 1);
            }
        }

        private decimal _changePennies;

        public decimal ChangePennies
        {
            get => _changePennies;

            set
            {
                _changePennies = CustomerPennies - (value % 1);
            }
        }

        public void FinalizeTransaction()
        {
            CashDrawer.OpenDrawer();
            CashDrawer.Hundreds = (int)(CustomerHundreds - ChangeHundreds);
            CashDrawer.Fifties = (int)(CustomerFifties - ChangeFifties);
            CashDrawer.Twenties = (int)(CustomerTwenties - ChangeTwenties);
            CashDrawer.Tens = (int)(CustomerTens - ChangeTens);
            CashDrawer.Fives = (int)(CustomerFives - ChangeFives);
            CashDrawer.Twos = (int)(CustomerTwos - ChangeTwos);
            CashDrawer.Dollars = (int)(CustomerOnes - ChangeOnes);
            CashDrawer.Ones = (int)(CustomerDollarCoins - ChangeDollarCoins);
            CashDrawer.HalfDollars = (int)(CustomerHalfDollars - ChangeHalfDollars);
            CashDrawer.Quarters = (int)(CustomerQuarters - ChangeQuarters);
            CashDrawer.Dimes = (int)(CustomerDimes - ChangeDimes);
            CashDrawer.Nickels = (int)(CustomerNickels - ChangeNickels);
            CashDrawer.Pennies = (int)(CustomerPennies - ChangePennies);
        }
    }
}
