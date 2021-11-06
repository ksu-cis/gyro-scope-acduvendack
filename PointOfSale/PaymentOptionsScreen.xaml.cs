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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptionsScreen.xaml
    /// </summary>
    public partial class PaymentOptionsScreen : UserControl
    {
        public PaymentOptionsScreen()
        {
            InitializeComponent();
        }

        private void PaymentScreenClick(Object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button creditDebit && ((creditDebit.Name == "CreditButton") || (creditDebit.Name == "DebitButton"))){
                if (DataContext is Order order)
                {
                    var result = CardReader.RunCard((double)order.Total);

                    while (result != CardTransactionResult.Approved)
                    {
                        result = CardReader.RunCard((double)order.Total);
                    }

                    if (result == CardTransactionResult.Approved)
                    {
                        //RecieptPrinter
                        MainWindow main = (MainWindow)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));
                        main.DataContext = new Order();
                    }
                }

                
            }

            if (e.OriginalSource is Button cash && (cash.Name == "CashButton"))
            {
                if (DataContext is Order order)
                {
                    MainWindow main = (MainWindow)LogicalTreeHelper.GetParent(LogicalTreeHelper.GetParent(this.Parent));
                    main.MenuItemSelect.Content = new CashPaymentProcessing();
                }
            }
        }
    }
}
