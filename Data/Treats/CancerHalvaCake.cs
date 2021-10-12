/*
 * CancerHelvahCake.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

/// <summary>
/// The NameSpace that contains the Treats classes.
/// </summary>
namespace GyroScope.Data.Treats
{
    /// <summary>
    /// A class representing Cancer Helvah Cake.
    /// </summary>
    public class CancerHalvaCake : Treat, INotifyPropertyChanged
    {
        /// <summary>
        /// The price of this Cancer Helvah Cake
        /// </summary>
        public override decimal Price
        {
            get
            {
                return 3.00m;
            }
        }

        /// <summary>
        /// Property that gets the calories for this Cancer Helvah Cake.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 272u;
            }
        }

        /// <summary>
        /// Returns a string representing the name of the Entree
        /// </summary>
        /// <returns>The name</returns>
        public override string ToString()
        {
            return "Cancer Halva Cake";
        }
    }
}
