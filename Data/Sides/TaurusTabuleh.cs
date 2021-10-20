/*
 * TaurusTabuleh.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;
using System.ComponentModel;

/// <summary>
/// The NameSpace that contains the Sides classes.
/// </summary>
namespace GyroScope.Data.Sides
{
    /// <summary>
    /// The class for the Taurus Tabuleh.
    /// </summary>
    public class TaurusTabuleh : Side, INotifyPropertyChanged, IMenuItem
    {

        /// <summary>
        /// Property containing getter for the price of this side.
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == Size.Small)
                {

                    OnPropertyChanged("Subtotal");
                    OnPropertyChanged("Tax");
                    OnPropertyChanged("Total");
                    return 1.50m;
                }
                else if (Size == Size.Medium)
                {
                    OnPropertyChanged("Subtotal");
                    OnPropertyChanged("Tax");
                    OnPropertyChanged("Total");
                    return 2.00m;
                }
                else
                {
                    OnPropertyChanged("Subtotal");
                    OnPropertyChanged("Tax");
                    OnPropertyChanged("Total");
                    return 2.50m;
                }
            }
        }

        /// <summary>
        /// Property that gets the calories for this side.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 124u;
                }
                else if (Size == Size.Medium)
                {
                    return 186u;
                }
                else
                {
                    return 248u;
                }
            }
        }

        /// <summary>
        /// Returns a string representing the name of the Entree
        /// </summary>
        /// <returns>The name</returns>
        public override string ToString()
        {
            return $"{Size} Taurus Tabuleh";
        }
    }
}
