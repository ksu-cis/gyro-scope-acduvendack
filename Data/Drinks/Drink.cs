/*
 * Drink.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The NameSpace that contains the Drinks classes.
/// </summary>
namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// The class for a drink.
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Property that gets the price for this drink.
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// Property that gets the calories for this drink.
        /// </summary>
        public abstract uint Calories { get; }
    }
}
