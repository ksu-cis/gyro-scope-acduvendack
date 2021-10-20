/*
 * OrderSummaryControl.xaml.cs
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
using GyroScope.Data.Entrees;
using GyroScope.Data.Drinks;
using GyroScope.Data.Sides;
using GyroScope.Data.Treats;

/// <summary>
/// The namespace for classes in the PointOfSale GUI
/// </summary>
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        /// <summary>
        /// Initializes the control for the Menu Item Selection Control
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
            
        }

        private void RemoveItemListener(Object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button button14 && button14.Name == "RemoveItemButton")
            {
                if (DataContext is Order order)
                {
                    order.Remove((IMenuItem)MainList.SelectedItem);
                }
            }
        }


        private void OnSelectionChanged(Object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is ListBox box && box.Name == "MainList")
            {
                if (DataContext is Order order)
                {
                    MainWindow main = (MainWindow)LogicalTreeHelper.GetParent(this.Parent);

                    if (MainList.SelectedItem is LeoLambGyro)
                    {
                        var leoLambControl = new LeoLambGyroControl();
                        leoLambControl.DataContext = MainList.SelectedItem;
                        main.MenuItemSelect.Content = leoLambControl;
                    }
                    else if (MainList.SelectedItem is AquariusIce)
                    {
                        var aquariusIceControl = new AquariusIceControl();
                        aquariusIceControl.DataContext = MainList.SelectedItem;
                        main.MenuItemSelect.Content = aquariusIceControl;
                    }
                    else if (MainList.SelectedItem is ScorpioSpicyGyro)
                    {
                        var scorpioSpicyControl = new ScorpioSpicyGyroControl();
                        scorpioSpicyControl.DataContext = MainList.SelectedItem;
                        main.MenuItemSelect.Content = scorpioSpicyControl;
                    }
                    else if (MainList.SelectedItem is VirgoClassicGyro)
                    {
                        var virgoClassicControl = new VirgoClassicGyroControl();
                        virgoClassicControl.DataContext = MainList.SelectedItem;
                        main.MenuItemSelect.Content = virgoClassicControl;
                    }
                    else if (MainList.SelectedItem is PiscesFishDish)
                    {
                        var piscesFishControl = new PiscesFishDishControl();
                        piscesFishControl.DataContext = MainList.SelectedItem;
                        main.MenuItemSelect.Content = piscesFishControl;
                    }
                    else if (MainList.SelectedItem is AriesFries)
                    {
                        var ariesFriesControl = new AriesFriesControl();
                        ariesFriesControl.DataContext = MainList.SelectedItem;
                        main.MenuItemSelect.Content = ariesFriesControl;
                    }
                    else if (MainList.SelectedItem is GeminiStuffedGrapeLeaves)
                    {
                        var geminiGrapeControl = new GeminiStuffedGrapeLeavesControl();
                        geminiGrapeControl.DataContext = MainList.SelectedItem;
                        main.MenuItemSelect.Content = geminiGrapeControl;
                    }
                    else if (MainList.SelectedItem is SagittariusGreekSalad)
                    {
                        var sagittariusSaladControl = new SagittariusGreekSaladControl();
                        sagittariusSaladControl.DataContext = MainList.SelectedItem;
                        main.MenuItemSelect.Content = sagittariusSaladControl;
                    }
                    else if (MainList.SelectedItem is TaurusTabuleh)
                    {
                        var taurusTabulehControl = new TaurusTabulehControl();
                        taurusTabulehControl.DataContext = MainList.SelectedItem;
                        main.MenuItemSelect.Content = taurusTabulehControl;
                    }
                    else if (MainList.SelectedItem is CapricornMountainTea)
                    {
                        var capricornTeaControl = new CapricornMountainTeaControl();
                        capricornTeaControl.DataContext = MainList.SelectedItem;
                        main.MenuItemSelect.Content = capricornTeaControl;
                    }
                    else if (MainList.SelectedItem is LibraLibation)
                    {
                        var libraLibationControl = new LibraLibationControl();
                        libraLibationControl.DataContext = MainList.SelectedItem;
                        main.MenuItemSelect.Content = libraLibationControl;
                    }
                    else if (MainList.SelectedItem is CancerHalvaCake)
                    {
                        var cancerCakeControl = new CancerHalvaCakeControl();
                        cancerCakeControl.DataContext = MainList.SelectedItem;
                        main.MenuItemSelect.Content = cancerCakeControl;
                    }
                }
            }
        }
    }
}
