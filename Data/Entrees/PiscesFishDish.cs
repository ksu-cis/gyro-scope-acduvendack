/*
 * PiscesFishDish.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

/// <summary>
/// The NameSpace that contains the Entree classes.
/// </summary>
namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// The class for the Pisces Fish Dish.
    /// </summary>
    public class PiscesFishDish : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Property containing getter for the price of this dish.
        /// </summary>
        public override decimal Price
        {
            get
            {
                return 5.99m;
            }
        }

        /// <summary>
        /// Property that gets the calories for this gyro.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 726u;
            }
        }

        /// <summary>
        /// Property that gets a list of special instructions for this gyro.
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
        {
            get
            {
                Queue<string> specialInstructions = new Queue<string>();
                return specialInstructions;
            }
        }

        /// <summary>
        /// Returns a string representing the name of the Entree
        /// </summary>
        /// <returns>The name</returns>
        public override string ToString()
        {
            return "Pisces Fish Dish";
        }
    }
}
