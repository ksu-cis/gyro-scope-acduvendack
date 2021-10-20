/*
 * Treat.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

/// <summary>
/// The NameSpace that contains the Treats classes.
/// </summary>
namespace GyroScope.Data.Treats
{
    /// <summary>
    /// A base class for all treats sold at GyroScope
    /// </summary>
    public abstract class Treat : INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// Notifies when a property of this class changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the treat
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the treat
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
        /// Abstract property that gets a list of special instructions for this entree.
        /// </summary>
        public IEnumerable<string> SpecialInstructions
        {
            get
            {
                Queue<string> specialInstructions = new Queue<string>();
                return specialInstructions;
            }
        }

        /// <summary>
        /// Returns the name of the treat
        /// </summary>
        public string Name
        {
            get
            {
                return this.ToString();
            }
        }
    }
}
