/*
 * MainWindow.xaml.cs
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
using GyroScope.Data.Entrees;
using GyroScope.Data;
using GyroScope.Data.Drinks;
using GyroScope.Data.Sides;
using GyroScope.Data.Treats;

/// <summary>
/// The namespace for classes in the PointOfSale GUI
/// </summary>
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes the control for the MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Order();
        }

        /// <summary>
        /// Event listener for the Select Items button.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The event</param>
        private void HandleClick(Object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button button13 && button13.Name == "ReturnToMainButton")
            {
                var menuSelectControl = new MenuItemSelectionControl();
                MenuItemSelect.Content = menuSelectControl;
            }
            else if (e.OriginalSource is Button button14 && button14.Name == "CancelOrderButton")
            {
                this.DataContext = new Order();
                var menuSelectControl = new MenuItemSelectionControl();
                MenuItemSelect.Content = menuSelectControl;
            }
            else if (e.OriginalSource is Button completeOrder && completeOrder.Name == "CompleteOrderButton")
            {
                var paymentScreen = new PaymentOptionsScreen();
                MenuItemSelect.Content = paymentScreen;
            }
        }
    }
}
