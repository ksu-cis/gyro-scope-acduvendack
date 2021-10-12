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
using System.ComponentModel;

/// <summary>
/// The NameSpace that contains the Drinks classes.
/// </summary>
namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// The class for the Libra Libation.
    /// </summary>
    public class LibraLibation : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Private backing field for Flavor property
        /// </summary>
        private LibraLibationFlavor _flavor;

        /// <summary>
        /// Property with getter and setter for the flavor of this Libra Liberation.
        /// </summary>
        public LibraLibationFlavor Flavor
        {
            get
            {
                return _flavor;
            }

            set
            {
                if (_flavor != value)
                {
                    this._flavor = value;
                    OnPropertyChanged(nameof(this.Flavor));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.Name));
                }
            }
        }

        /// <summary>
        /// Field that stores if this Libra Libation is sparkling.
        /// </summary>
        private bool _sparkling = true;

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
                if (_sparkling != value)
                {
                    this._sparkling = value;
                    OnPropertyChanged(nameof(this.Sparkling));
                    OnPropertyChanged(nameof(this.Name));
                }
                
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
                    return 180u;
                }
                else if (Flavor == LibraLibationFlavor.SourCherry)
                {
                    return 100u;
                }
                else if (Flavor == LibraLibationFlavor.Biral)
                {
                    return 120u;
                }
                else
                {
                    return 41u;
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
                return 1.00m;
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

        /// <summary>
        /// Returns a string representing the name of the Drink
        /// </summary>
        /// <returns>The name</returns>
        public override string ToString()
        {
            if (this.Flavor == LibraLibationFlavor.SourCherry)
            {
                return "Sour Cherry Libra Libation";
            }
            else if (this.Flavor == LibraLibationFlavor.PinkLemonada)
            {
                return "Pink Lemonada Libra Libation";
            }
            else
            {
                return $"{Flavor} Libra Libation";
            }
        }
    }
}
