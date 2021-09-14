/*
 * SagittariusGreekSalad.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

/// <summary>
/// The NameSpace that contains the Sides classes.
/// </summary>
namespace GyroScope.Data.Sides
{
    /// <summary>
    /// The class for the Sagittarius Greek Salad.
    /// </summary>
    public class SagittariusGreekSalad : Side
    {
        /// <summary>
        /// Field that stores the size of this side.
        /// </summary>
        private Size _size = new Size();

        /// <summary>
        /// Property containing getter for the price of this side.
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (this._size == Size.Small)
                {
                    return 2.00m;
                }
                else if (this._size == Size.Medium)
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
        public override uint Calories
        {
            get
            {
                if (this._size == Size.Small)
                {
                    return 180;
                }
                else if (this._size == Size.Medium)
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
