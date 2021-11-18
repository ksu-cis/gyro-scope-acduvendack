/*
 * PaymentOptionsScreen.xaml.cs
 * Modified by: Adam Duvendack
 */
using System;
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
using RoundRegister;
using GyroScope.Data;

/// <summary>
/// The namespace for classes in the PointOfSale GUI
/// </summary>
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptionsScreen.xaml
    /// </summary>
    public partial class PaymentOptionsScreen : UserControl
    {
        /// <summary>
        /// Initializes the control for Payment Options Screen
        /// </summary>
        public PaymentOptionsScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event listener for Cash, Credit, and Debit buttons
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The event</param>
        private void PaymentScreenClick(Object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button creditDebit && ((creditDebit.Name == "CreditButton") || (creditDebit.Name == "DebitButton"))){
                if (DataContext is Order order)
                {
                    var result = CardReader.RunCard((double)order.Total);
                    MainWindow main = (MainWindow)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));

                    if (result == CardTransactionResult.Approved)
                    {
                        order.PrintReceipt("Card", "0.00");
                        main.DataContext = new Order();
                        var menuSelectControl = new MenuItemSelectionControl();
                        main.MenuItemSelect.Content = menuSelectControl;
                    }
                    else if (result == CardTransactionResult.Declined)
                    {
                        MessageBox.Show("Card Declined: Please try again or choose a different payment method.");
                        var payment = new PaymentOptionsScreen();
                        main.MenuItemSelect.Content = payment;
                    }
                    else if (result == CardTransactionResult.ReadError)
                    {
                        MessageBox.Show("Card Read Error: Please try card again.");
                        var payment = new PaymentOptionsScreen();
                        main.MenuItemSelect.Content = payment;
                    }
                    else if (result == CardTransactionResult.InsufficientFunds)
                    {
                        MessageBox.Show("Insufficient Funds: Please choose a different payment method.");
                        var payment = new PaymentOptionsScreen();
                        main.MenuItemSelect.Content = payment;
                    }
                    else if (result == CardTransactionResult.IncorrectPin)
                    {
                        MessageBox.Show("Incorrect Pin: Please try card again.");
                        var payment = new PaymentOptionsScreen();
                        main.MenuItemSelect.Content = payment;
                    }
                }
            }

            if (e.OriginalSource is Button cash && (cash.Name == "CashButton"))
            {
                if (DataContext is Order order)
                {
                    MainWindow main = (MainWindow)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));
                    main.MenuItemSelect.Content = new CashPaymentProcessing();
                    CashPaymentProcessing cashPayment = (CashPaymentProcessing)main.MenuItemSelect.Content;
                    
                    if (cashPayment.DataContext is Register register)
                    {
                        register.AmountDue = order.Total;
                    }
                }
            }
        }
    }
}
