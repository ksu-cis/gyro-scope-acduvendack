/*
 * MenuItemSelectionControl.xaml.cs
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
using GyroScope.Data.Sides;
using GyroScope.Data.Treats;
using GyroScope.Data.Drinks;

/// <summary>
/// The namespace for classes in the PointOfSale GUI
/// </summary>
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// Initializes the control for the Menu Item Selection Control
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event listener for buttons on the Menu Item Selection control
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The event</param>
        private void HandleClick(Object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button button1 && button1.Name == "VirgoClassicGyroButton")
            {
                var virgoClassicGyro = new VirgoClassicGyro();
                var virgoClassicControl = new VirgoClassicGyroControl();
                virgoClassicControl.DataContext = virgoClassicGyro;
                this.Content = virgoClassicControl;
            }
            else if (e.OriginalSource is Button button2 && button2.Name == "LeoLambGyroButton")
            {
                var leoLambGyro = new LeoLambGyro();
                var leoLambControl = new LeoLambGyroControl();
                leoLambControl.DataContext = leoLambGyro;
                this.Content = leoLambControl;
            }
            else if (e.OriginalSource is Button button3 && button3.Name == "ScorpioSpicyGyroButton")
            {
                var scorpioSpicyGyro = new ScorpioSpicyGyro();
                var scorpioSpicyControl = new ScorpioSpicyGyroControl();
                scorpioSpicyControl.DataContext = scorpioSpicyGyro;
                this.Content = scorpioSpicyControl;
            }
            else if (e.OriginalSource is Button button4 && button4.Name == "PiscesFishDishButton")
            {
                var piscesFishDish = new PiscesFishDish();
                var piscesFishControl = new PiscesFishDishControl();
                piscesFishControl.DataContext = piscesFishDish;
                this.Content = piscesFishControl;
            }
            else if (e.OriginalSource is Button button5 && button5.Name == "TaurusTabulehButton")
            {
                var taurusTabuleh = new TaurusTabuleh();
                var taurusTabulehControl = new TaurusTabulehControl();
                taurusTabulehControl.DataContext = taurusTabuleh;
                this.Content = taurusTabulehControl;
            }
            else if (e.OriginalSource is Button button6 && button6.Name == "GeminiGrapeLeavesButton")
            {
                var geminiGrapeLeaves = new GeminiStuffedGrapeLeaves();
                var geminiGrapeControl = new GeminiStuffedGrapeLeavesControl();
                geminiGrapeControl.DataContext = geminiGrapeLeaves;
                this.Content = geminiGrapeControl;
            }
            else if (e.OriginalSource is Button button7 && button7.Name == "SagittariusSaladButton")
            {
                var sagittariusSalad = new SagittariusGreekSalad();
                var sagittariusSaladControl = new SagittariusGreekSaladControl();
                sagittariusSaladControl.DataContext = sagittariusSalad;
                this.Content = sagittariusSaladControl;
            }
            else if (e.OriginalSource is Button button8 && button8.Name == "AriesFriesButton")
            {
                var ariesFries = new AriesFries();
                var ariesFriesControl = new AriesFriesControl();
                ariesFriesControl.DataContext = ariesFries;
                this.Content = ariesFriesControl;
            }
            else if (e.OriginalSource is Button button9 && button9.Name == "LibraLibationButton")
            {
                var libraLibation = new LibraLibation();
                var libraLibationControl = new LibraLibationControl();
                libraLibationControl.DataContext = libraLibation;
                this.Content = libraLibationControl;
            }
            else if (e.OriginalSource is Button button10 && button10.Name == "CapricornTeaButton")
            {
                var capricornTea = new CapricornMountainTea();
                var capricornTeaControl = new CapricornMountainTeaControl();
                capricornTeaControl.DataContext = capricornTea;
                this.Content = capricornTeaControl;
            }
            else if (e.OriginalSource is Button button11 && button11.Name == "AquariusIceButton")
            {
                var aquariusIce = new AquariusIce();
                var aquariusIceControl = new AquariusIceControl();
                aquariusIceControl.DataContext = aquariusIce;
                this.Content = aquariusIceControl;
            }
            else if (e.OriginalSource is Button button12 && button12.Name == "CancerCakeButton")
            {
                var cancerHalvaCake = new CancerHalvaCake();
                var cancerHalvaCakeControl = new CancerHalvaCakeControl();
                cancerHalvaCakeControl.DataContext = cancerHalvaCake;
                this.Content = cancerHalvaCakeControl;
            }
        }
    }
}