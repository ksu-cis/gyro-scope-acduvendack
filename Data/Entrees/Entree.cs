/*
 * Entree.cs
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
    /// Abstract class that creates an Entree.
    /// </summary>
    public abstract class Entree : INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// Notifies when a property of this class changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Abstract property containing getter for the price of this entree.
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// Abstract property that gets the calories for this entree.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Abstract property that gets a list of special instructions for this entree.
        /// </summary>
        public abstract IEnumerable<string> SpecialInstructions { get; }

        /// <summary>
        /// Used to trigger a PropertyChanged event
        /// </summary>
        /// <param name="propertyName">The name of the property that is changing</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        public virtual string Name
        {
            get
            {
                return this.ToString();
            }
        }
    }
}
