/*
 * AquariusIce.cs
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
/// The NameSpace that contains the Treats classes.
/// </summary>
namespace GyroScope.Data.Treats
{
    /// <summary>
    /// A class representing "Aquarius Ice" - an itialian iced soda
    /// </summary>
    public class AquariusIce : Treat, INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// Backing field for the Size property
        /// </summary>
        private Size _size = Size.Small;

        /// <summary>
        /// The size of this Aquarius Ice
        /// </summary>
        public Size Size
        {
            get => _size;
            set
            {
                if (_size != value)
                {
                    this._size = value;
                    OnPropertyChanged(nameof(this.Size));
                    OnPropertyChanged(nameof(this.Price));
                    OnPropertyChanged(nameof(this.Name));
                }
            }
        }

        /// <summary>
        /// Backing field for the Flavor property
        /// </summary>
        private AquariusIceFlavor _flavor = AquariusIceFlavor.Lemon;

        /// <summary>
        /// The flavor of this Aquarius Ice
        /// </summary>
        public AquariusIceFlavor Flavor
        {
            get => _flavor;
            set
            {
                if (_flavor != value)
                {
                    _flavor = value;
                    OnPropertyChanged(nameof(this.Flavor));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.Name));
                }
            }
        }

        /// <summary>
        /// The calories of this Aquarius Ice
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Flavor)
                {
                    case AquariusIceFlavor.Lemon:
                    case AquariusIceFlavor.Orange:
                    case AquariusIceFlavor.Mango:
                    case AquariusIceFlavor.Watermellon:
                        return 45;
                    case AquariusIceFlavor.BlueRaspberry:
                    case AquariusIceFlavor.Strawberry:
                        return 170;
                    default:
                        throw new NotImplementedException($"Unknown Flavor {Flavor}");
                }
            }
        }

        /// <summary>
        /// The price of this Aquarius Ice
        /// </summary>
        public override decimal Price 
        { 
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 2.00m;
                    case Size.Medium:
                        return 2.50m;
                    case Size.Large:
                        return 3.00m;
                    default:
                        throw new NotImplementedException($"Unknown Size {Size}");
                }
            }
        }

        /// <summary>
        /// Returns a string representing the name of the Entree
        /// </summary>
        /// <returns>The name</returns>
        public override string ToString()
        {
            if (this.Flavor != AquariusIceFlavor.BlueRaspberry)
            {
                return $"{Size} {Flavor} Aquarius Ice";
            }
            else
            {
                return $"{Size} Blue Raspberry Aquarius Ice";
            }
        }

        /// <summary>
        /// Property that returns description of item.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Italian flavored ices, the coolest treat you can eat with a spoon!";
            }
        }

        /// <summary>
        /// Read-only item type property
        /// </summary>
        public override string ItemType
        {
            get
            {
                return "Treats";
            }
        }
    }
}
