/*
 * CancerHalvehCake.cs
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
    class CancerHalvehCake : Treat
    {
        /// <summary>
        /// The price of this Cancer Halveh Cake
        /// </summary>
        public override decimal Price
        {
            get
            {
                return 3.00m;
            }
        }

        /// <summary>
        /// Property that gets the calories for this Cancer Halveh Cake.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 272;
            }
        }
    }
}
