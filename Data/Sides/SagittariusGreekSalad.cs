/*
 * SagittariusGreekSalad.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The NameSpace that contains the Sides classes.
/// </summary>
namespace GyroScope.Data.Sides
{
    /// <summary>
    /// The class for the Sagittarius Greek Salad.
    /// </summary>
    class SagittariusGreekSalad
    {
        /// <summary>
        /// Field that stores the size of this side.
        /// </summary>
        private Enums.Size _size;
        /// <summary>
        /// Property with getter and setter for size.
        /// </summary>
        public Enums.Size Size
        {
            get
            {
                return this._size;
            }

            set
            {
                this._size = value;
            }
        }

        /// <summary>
        /// Property containing getter for the price of this side.
        /// </summary>
        public decimal Price
        {
            get
            {
                if (this._size == Enums.Size.Small)
                {
                    return 2.00m;
                }
                else if (this._size == Enums.Size.Medium)
                {
                    return 2.50m;
                }
                else
                {
                    return 3.00m;
                }
            }
        }

        /// <summary>
        /// Property that gets the calories for this side.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (this._size == Enums.Size.Small)
                {
                    return 180;
                }
                else if (this._size == Enums.Size.Medium)
                {
                    return 270;
                }
                else
                {
                    return 360;
                }
            }
        }
    }
}
