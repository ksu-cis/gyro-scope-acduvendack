/*
 * Entree.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The NameSpace that contains the Entree classes.
/// </summary>
namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// Abstract class that creates an Entree.
    /// </summary>
    public abstract class Entree
    {
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
    }
}
