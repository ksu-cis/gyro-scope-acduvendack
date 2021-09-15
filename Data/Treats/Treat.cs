﻿/*
 * Treat.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The NameSpace that contains the Treats classes.
/// </summary>
namespace GyroScope.Data.Treats
{
    /// <summary>
    /// A base class for all treats sold at GyroScope
    /// </summary>
    public abstract class Treat
    {
        /// <summary>
        /// The price of the treat
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the treat
        /// </summary>
        public abstract uint Calories { get; }
    }
}
