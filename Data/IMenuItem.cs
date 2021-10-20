/*
 * IMenuItem.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Namespace for IMenuItem, Order, Entrees, Drinks, Sides, etc.
/// </summary>
namespace GyroScope.Data
{
    /// <summary>
    /// Interface for IMenuItem
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Price property with getter
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// Calories property with getter
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// SpecialInstructions property with getter
        /// </summary>
        public IEnumerable<string> SpecialInstructions { get; }

        /// <summary>
        /// Name property with getter
        /// </summary>
        public string Name { get; }
    }
}
