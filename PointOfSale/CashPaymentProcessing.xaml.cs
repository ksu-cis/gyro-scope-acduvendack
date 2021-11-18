/*
 * CashPaymentProcessing.xaml.cs
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
using GyroScope.Data;

/// <summary>
/// The namespace for classes in the PointOfSale GUI
/// </summary>
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentProcessing.xaml
    /// </summary>
    public partial class CashPaymentProcessing : UserControl
    {
        /// <summary>
        /// Initializes the control for Cash Payment Processing
        /// </summary>
        public CashPaymentProcessing()
        {
            InitializeComponent();
            this.DataContext = new Register();
        }

        /// <summary>
        /// Event listener for the Finalize Sale button
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The event</param>
        private void FinalizeSaleClick(Object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button finalize && finalize.Name == "FinalizeSaleButton")
            {
                if (DataContext is Register register)
                {
                    if (LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(finalize.Parent)))) is MainWindow main)
                    {
                        Order order = (Order)main.DataContext;
                        order.PrintReceipt("Cash", register.ChangeOwed.ToString());

                        register.FinalizeTransaction();

                        main.DataContext = new Order();
                        var menuSelectControl = new MenuItemSelectionControl();
                        main.MenuItemSelect.Content = menuSelectControl;
                    }
                }
            }
        }
    }
}
