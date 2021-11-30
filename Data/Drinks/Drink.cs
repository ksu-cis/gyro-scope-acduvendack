/*
 * Drink.cs
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
    /// The class for a drink.
    /// </summary>
    public abstract class Drink : INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// Notifies when a property of this class changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property that gets the price for this drink.
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// Property that gets the calories for this drink.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Used to trigger a PropertyChanged event
        /// </summary>
        /// <param name="propertyName">The name of the property that is changing</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Abstract property that gets a list of special instructions for this gyro.
        /// </summary>
        public abstract IEnumerable<string> SpecialInstructions { get; }

        /// <summary>
        /// Returns the name of the Drink.
        /// </summary>
        public string Name
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Abstract property that returns a description of the item.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Read-only item type property
        /// </summary>
        public abstract string ItemType { get; }
    }
}
