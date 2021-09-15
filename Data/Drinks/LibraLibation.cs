/*
 * LibraLibation.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

/// <summary>
/// The NameSpace that contains the Drinks classes.
/// </summary>
namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// The class for the Libra Libation.
    /// </summary>
    public class LibraLibation : Drink
    {
        /// <summary>
        /// Property with getter and setter for the flavor of this Libra Liberation.
        /// </summary>
        public LibraLibationFlavor Flavor { get; set; }

        /// <summary>
        /// Field that stores if this Libra Libation is sparkling.
        /// </summary>
        public bool _sparkling = true;

        /// <summary>
        /// Property with getter and setter for this Libra Libation is sparkling.
        /// </summary>
        public bool Sparkling
        {
            get
            {
                return this._sparkling;
            }

            set
            {
                this._sparkling = value;
            }
        }

        /// <summary>
        /// Property that gets the calories for this Libra Libation.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Flavor == LibraLibationFlavor.Orangeade)
                {
                    return 180;
                }
                else if (Flavor == LibraLibationFlavor.SourCherry)
                {
                    return 100;
                }
                else if (Flavor == LibraLibationFlavor.Biral)
                {
                    return 120;
                }
                else
                {
                    return 41;
                }
            }
        }

        /// <summary>
        /// Property that gets the price for this Libra Libation.
        /// </summary>
        public override decimal Price
        {
            get
            {
                return 100m;
            }
        }

        /// <summary>
        /// Property that gets the name of this kind of Libra Libation.
        /// </summary>
        public string Name
        {
            get
            {
                if (Sparkling)
                {
                    if (Flavor == LibraLibationFlavor.Orangeade)
                    {
                        return $"Sparkling Orangeade Libra Libation";
                    }
                    else if (Flavor == LibraLibationFlavor.SourCherry)
                    {
                        return $"Sparkling Sour Cherry Libra Libation";
                    }
                    else if (Flavor == LibraLibationFlavor.Biral)
                    {
                        return $"Sparkling Biral Libra Libation";
                    }
                    else
                    {
                        return $"Sparkling Pink Lemonada Libra Libation";
                    }
                }
                else
                {
                    if (Flavor == LibraLibationFlavor.Orangeade)
                    {
                        return $"Still Orangeade Libra Libation";
                    }
                    else if (Flavor == LibraLibationFlavor.SourCherry)
                    {
                        return $"Still Sour Cherry Libra Libation";
                    }
                    else if (Flavor == LibraLibationFlavor.Biral)
                    {
                        return $"Still Biral Libra Libation";
                    }
                    else
                    {
                        return $"Still Pink Lemonada Libra Libation";
                    }
                }
            }
        }
    }
}
