/*
 * Side.cs
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
    /// The class for sides.
    /// </summary>
    public abstract class Side : INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// Notifies when a property of this class changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Field that stores the size of this side.
        /// </summary>
        private Size _size;

        /// <summary>
        /// Property with getter and setter for size.
        /// </summary>
        public Size Size
        {
            get => _size;

            set
            {
                if (_size != value)
                {
                    this._size = value;
                    OnPropertyChanged(nameof(this.Size));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.Price));
                    OnPropertyChanged(nameof(this.Name));
                }
            }
        }


        /// <summary>
        /// Property containing getter for the price of this side.
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// Property that gets the calories for this side.
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
        /// Returns the name of the side
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
