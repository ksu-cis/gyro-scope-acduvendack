/*
 * CapricornMountainTea.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

/// <summary>
/// The NameSpace that contains the Drinks classes.
/// </summary>
namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// The class for the Capricorn Mountain Tea.
    /// </summary>
    public class CapricornMountainTea : Drink, INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// Property that gets the price for this Capricorn Mountain Tea.
        /// </summary>
        public override decimal Price
        {
            get
            {
                return 2.50m;
            }
        }

        /// <summary>
        /// Property that gets the calories for this Capricorn Mountain Tea.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Honey == false)
                {
                    return 0;
                }
                else
                {
                    return 64;
                }
            }
        }

        /// <summary>
        /// Field that stores if honey is used.
        /// </summary>
        private bool _honey = false;

        /// <summary>
        /// Property with getter and setter for if honey is used.
        /// </summary>
        public bool Honey
        {
            get
            {
                return this._honey;
            }

            set
            {
                if (_honey != value)
                {
                    this._honey = value;
                    OnPropertyChanged(nameof(this.Honey));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                }
            }
        }

        /// <summary>
        /// Returns a string representing the name of the Drink
        /// </summary>
        /// <returns>The name</returns>
        public override string ToString()
        {
            return "Capricorn Mountain Tea";
        }

        /// <summary>
        /// Returns a queue of instructions to modify the Drink
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
        {
            get
            {
                Queue<string> specialInstructions = new Queue<string>();

                if (Honey == true)
                {
                    specialInstructions.Enqueue("Add Honey");
                }

                return specialInstructions;
            }
        }
    }
}
