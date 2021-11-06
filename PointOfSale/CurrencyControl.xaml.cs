﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GyroScope.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        public CurrencyControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A dependency property representing the Label of this control
        /// </summary>
        public static DependencyProperty LabelTextProperty = DependencyProperty.Register("Label", typeof(string), typeof(CurrencyControl));

        /// <summary>
        /// The Label of this control
        /// </summary>
        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }

            set { SetValue(LabelTextProperty, value); }
        }

        public static DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(string), typeof(CurrencyControl));

        public string CustomerQuantity
        {
            get { return (string)GetValue(CustomerQuantityProperty); }
            set { SetValue(CustomerQuantityProperty, value); }
        }

        public static DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(string), typeof(CurrencyControl));

        public string ChangeQuantity
        {
            get { return (string)GetValue(ChangeQuantityProperty); }
            set { SetValue(ChangeQuantityProperty, value); }
        }

        private void PlusMinusClick(Object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button plus && plus.Name == "PlusButton")
            {
                if (DataContext is Register register)
                {
                    if (LogicalTreeHelper.GetParent(plus.Parent) is CurrencyControl hundreds && hundreds.Name == "HundredsControl")
                    {
                        register.CustomerHundreds = register.CustomerHundreds + 1;

                        if (register.CustomerHundreds != 0)
                        {
                            this.MinusButton.IsEnabled = true;
                        }

                        MenuItemSelectionControl menu = (MenuItemSelectionControl)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));

                        if (menu.DataContext is Order order)
                        {
                            register.ChangeHundreds = order.Total;
                        }
                    }

                    if (LogicalTreeHelper.GetParent(plus.Parent) is CurrencyControl fifties && fifties.Name == "FiftiesControl")
                    {
                        register.CustomerFifties = register.CustomerFifties + 1;

                        if (register.CustomerFifties != 0)
                        {
                            this.MinusButton.IsEnabled = true;
                        }

                        MenuItemSelectionControl menu = (MenuItemSelectionControl)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));

                        if (menu.DataContext is Order order)
                        {
                            register.ChangeFifties = order.Total;
                        }
                    }

                    if (LogicalTreeHelper.GetParent(plus.Parent) is CurrencyControl twenties && twenties.Name == "TwentiesControl")
                    {
                        register.CustomerTwenties = register.CustomerTwenties + 1;

                        if (register.CustomerTwenties != 0)
                        {
                            this.MinusButton.IsEnabled = true;
                        }

                        MenuItemSelectionControl menu = (MenuItemSelectionControl)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));

                        if (menu.DataContext is Order order)
                        {
                            register.ChangeTwenties = order.Total;
                        }
                    }

                    if (LogicalTreeHelper.GetParent(plus.Parent) is CurrencyControl tens && tens.Name == "TensControl")
                    {
                        register.CustomerTens = register.CustomerTens + 1;

                        if (register.CustomerTens != 0)
                        {
                            this.MinusButton.IsEnabled = true;
                        }

                        MenuItemSelectionControl menu = (MenuItemSelectionControl)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));

                        if (menu.DataContext is Order order)
                        {
                            register.ChangeTens = order.Total;
                        }
                    }

                    if (LogicalTreeHelper.GetParent(plus.Parent) is CurrencyControl fives && fives.Name == "FivesControl")
                    {
                        register.CustomerFives = register.CustomerFives + 1;

                        if (register.CustomerFives != 0)
                        {
                            this.MinusButton.IsEnabled = true;
                        }

                        MenuItemSelectionControl menu = (MenuItemSelectionControl)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));

                        if (menu.DataContext is Order order)
                        {
                            register.ChangeFives = order.Total;
                        }
                    }

                    if (LogicalTreeHelper.GetParent(plus.Parent) is CurrencyControl twos && twos.Name == "TwosControl")
                    {
                        register.CustomerTwos = register.CustomerTwos + 1;

                        if (register.CustomerTwos != 0)
                        {
                            this.MinusButton.IsEnabled = true;
                        }

                        MenuItemSelectionControl menu = (MenuItemSelectionControl)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));

                        if (menu.DataContext is Order order)
                        {
                            register.ChangeTwos = order.Total;
                        }
                    }

                    if (LogicalTreeHelper.GetParent(plus.Parent) is CurrencyControl ones && ones.Name == "OnesControl")
                    {
                        register.CustomerOnes = register.CustomerOnes + 1;

                        if (register.CustomerOnes != 0)
                        {
                            this.MinusButton.IsEnabled = true;
                        }

                        MenuItemSelectionControl menu = (MenuItemSelectionControl)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));

                        if (menu.DataContext is Order order)
                        {
                            register.ChangeOnes = order.Total;
                        }
                    }

                    if (LogicalTreeHelper.GetParent(plus.Parent) is CurrencyControl dollarCoins && dollarCoins.Name == "DollarCoinsControl")
                    {
                        register.CustomerDollarCoins = register.CustomerDollarCoins + 1;

                        if (register.CustomerDollarCoins != 0)
                        {
                            this.MinusButton.IsEnabled = true;
                        }

                        MenuItemSelectionControl menu = (MenuItemSelectionControl)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));

                        if (menu.DataContext is Order order)
                        {
                            register.ChangeDollarCoins = order.Total;
                        }
                    }

                    if (LogicalTreeHelper.GetParent(plus.Parent) is CurrencyControl halfDollars && halfDollars.Name == "HalfDollarsControl")
                    {
                        register.CustomerHalfDollars = register.CustomerHalfDollars + 1;

                        if (register.CustomerHalfDollars != 0)
                        {
                            this.MinusButton.IsEnabled = true;
                        }

                        MenuItemSelectionControl menu = (MenuItemSelectionControl)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));

                        if (menu.DataContext is Order order)
                        {
                            register.ChangeHalfDollars = order.Total;
                        }
                    }

                    if (LogicalTreeHelper.GetParent(plus.Parent) is CurrencyControl quarters && quarters.Name == "QuartersControl")
                    {
                        register.CustomerQuarters = register.CustomerQuarters + 1;

                        if (register.CustomerQuarters != 0)
                        {
                            this.MinusButton.IsEnabled = true;
                        }

                        MenuItemSelectionControl menu = (MenuItemSelectionControl)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));

                        if (menu.DataContext is Order order)
                        {
                            register.ChangeQuarters = order.Total;
                        }
                    }

                    if (LogicalTreeHelper.GetParent(plus.Parent) is CurrencyControl dimes && dimes.Name == "DimesControl")
                    {
                        register.CustomerDimes = register.CustomerDimes + 1;

                        if (register.CustomerDimes != 0)
                        {
                            this.MinusButton.IsEnabled = true;
                        }

                        MenuItemSelectionControl menu = (MenuItemSelectionControl)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));

                        if (menu.DataContext is Order order)
                        {
                            register.ChangeDimes = order.Total;
                        }
                    }

                    if (LogicalTreeHelper.GetParent(plus.Parent) is CurrencyControl nickels && nickels.Name == "NickelsControl")
                    {
                        register.CustomerNickels = register.CustomerNickels + 1;

                        if (register.CustomerNickels != 0)
                        {
                            this.MinusButton.IsEnabled = true;
                        }

                        MenuItemSelectionControl menu = (MenuItemSelectionControl)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));

                        if (menu.DataContext is Order order)
                        {
                            register.ChangeNickels = order.Total;
                        }
                    }

                    if (LogicalTreeHelper.GetParent(plus.Parent) is CurrencyControl pennies && pennies.Name == "PenniesControl")
                    {
                        register.CustomerPennies = register.CustomerPennies + 1;

                        if (register.CustomerPennies != 0)
                        {
                            this.MinusButton.IsEnabled = true;
                        }

                        MenuItemSelectionControl menu = (MenuItemSelectionControl)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));

                        if (menu.DataContext is Order order)
                        {
                            register.ChangePennies = order.Total;
                        }
                    }
                }
                
            }
            else if (e.OriginalSource is Button minus && minus.Name == "MinusButton")
            {
                decimal d = System.Convert.ToDecimal(this.CustomerQuantity);
                d--;

                if (d == 0)
                {
                    minus.IsEnabled = false;
                }

                this.CustomerQuantity = d.ToString();
            }
        }
    }
}
