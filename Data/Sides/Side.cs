﻿/*
 * Side.cs
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
    /// The class for sides.
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// Field that stores the size of this side.
        /// </summary>
        private Size _size;

        /// <summary>
        /// Property with getter and setter for size.
        /// </summary>
        public Size Size
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
        public abstract decimal Price { get; }

        /// <summary>
        /// Property that gets the calories for this side.
        /// </summary>
        public abstract uint Calories { get; }
    }
}
