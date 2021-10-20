﻿/*
 * SagittariusGreekSalad.cs
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
    /// The class for the Sagittarius Greek Salad.
    /// </summary>
    public class SagittariusGreekSalad : Side, INotifyPropertyChanged, IMenuItem
    {

        /// <summary>
        /// Property containing getter for the price of this side.
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 2.00m;
                }
                else if (Size == Size.Medium)
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
                if (Size == Size.Small)
                {
                    return 180u;
                }
                else if (Size == Size.Medium)
                {
                    return 270u;
                }
                else
                {
                    return 360u;
                }
            }
        }

        /// <summary>
        /// Returns a string representing the name of the Entree
        /// </summary>
        /// <returns>The name</returns>
        public override string ToString()
        {
            return $"{Size} Sagittarius Greek Salad";
        }
    }
}
