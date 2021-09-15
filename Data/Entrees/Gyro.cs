/*
 * Gyro.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

/// <summary>
/// The NameSpace that contains the Entree classes.
/// </summary>
namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// Abstract class that creates a Gyro.
    /// </summary>
    public abstract class Gyro : Entree
    {
        /// <summary>
        /// Field that stores the meat for this gyro.
        /// </summary>
        private DonerMeat _meat = new DonerMeat();

        /// <summary>
        /// Meat property with getter and setter.
        /// </summary>
        public DonerMeat Meat
        {
            get
            {
                return this._meat;
            }

            set
            {
                this._meat = value;
            }
        }

        /// <summary>
        /// Field that stores if pita is used in this gyro.
        /// </summary>
        private bool _pita = true;

        /// <summary>
        /// Property with getter and setter for if pita is used.
        /// </summary>
        public bool Pita
        {
            get
            {
                return this._pita;
            }

            set
            {
                this._pita = value;
            }
        }

        /// <summary>
        /// Field that stores if tomato is used in this gyro.
        /// </summary>
        private bool _tomato = true;

        /// <summary>
        /// Property with getter and setter for if tomato is used.
        /// </summary>
        public bool Tomato
        {
            get
            {
                return this._tomato;
            }

            set
            {
                this._tomato = value;
            }
        }

        /// <summary>
        /// Field that stores if onion is used in this gyro.
        /// </summary>
        private bool _onion = true;

        /// <summary>
        /// Property with getter and setter for if onion is used.
        /// </summary>
        public bool Onion
        {
            get
            {
                return this._onion;
            }

            set
            {
                this._onion = value;
            }
        }

        /// <summary>
        /// Field that stores if Egg Plant is used in this gyro.
        /// </summary>
        private bool _eggplant = true;

        /// <summary>
        /// Property with getter and setter for if Egg Plant is used.
        /// </summary>
        public bool Eggplant
        {
            get
            {
                return this._eggplant;
            }

            set
            {
                this._eggplant = value;
            }
        }

        /// <summary>
        /// Field that stores if lettuce is used in this gyro.
        /// </summary>
        private bool _lettuce = true;

        /// <summary>
        /// Property with getter and setter for if lettuce is used.
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return this._lettuce;
            }

            set
            {
                this._lettuce = value;
            }
        }

        /// <summary>
        /// Field that stores if Mint Chutney is used in this gyro.
        /// </summary>
        private bool _mintChutney = true;

        /// <summary>
        /// Property with getter and setter for if Mint Chutney is used.
        /// </summary>
        public bool MintChutney
        {
            get
            {
                return this._mintChutney;
            }

            set
            {
                this._mintChutney = value;
            }
        }

        /// <summary>
        /// Field that stores if tzatziki is used in this gyro.
        /// </summary>
        private bool _tzatziki = true;

        /// <summary>
        /// Property with getter and setter for if tzatziki is used.
        /// </summary>
        public bool Tzatziki
        {
            get
            {
                return this._tzatziki;
            }

            set
            {
                this._tzatziki = value;
            }
        }

        /// <summary>
        /// Field that stores if peppers are used in this gyro.
        /// </summary>
        private bool _peppers = true;

        /// <summary>
        /// Property with getter and setter for if peppers are used.
        /// </summary>
        public bool Peppers
        {
            get
            {
                return this._peppers;
            }

            set
            {
                this._peppers = value;
            }
        }

        /// <summary>
        /// Field that stores if Wing Sauce is used in this gyro.
        /// </summary>
        private bool _wingSauce = true;

        /// <summary>
        /// Property with getter and setter for if Wing Sauce is used.
        /// </summary>
        public bool WingSauce
        {
            get
            {
                return this._wingSauce;
            }

            set
            {
                this._wingSauce = value;
            }
        }

        /// <summary>
        /// Abstract property containing getter for the price of this gyro.
        /// </summary>
        public override abstract decimal Price { get; }

        /// <summary>
        /// Field that stores the calories of this gyro.
        /// </summary>
        private uint _calories = 0;

        /// <summary>
        /// Property that gets the calories for this gyro.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Pita == true)
                {
                    _calories += 262;
                }

                if (Peppers == true)
                {
                    _calories += 33;
                }

                if (Tomato == true)
                {
                    _calories += 30;
                }

                if (Eggplant == true)
                {
                    _calories += 47;
                }

                if (MintChutney == true)
                {
                    _calories += 10;
                }

                if (Tzatziki == true)
                {
                    _calories += 30;
                }

                if (Onion == true)
                {
                    _calories += 30;
                }

                if (Lettuce == true)
                {
                    _calories += 54;
                }

                if (WingSauce == true)
                {
                    _calories += 15;
                }

                if (Meat == DonerMeat.Chicken)
                {
                    _calories += 113;
                }
                else if (Meat == DonerMeat.Lamb)
                {
                    _calories += 151;
                }
                else if (Meat == DonerMeat.Pork)
                {
                    _calories += 187;
                }
                else if (Meat == DonerMeat.Beef)
                {
                    _calories += 181;
                }

                return _calories;
            }
        }

        /// <summary>
        /// Abstract property that gets a list of special instructions for this gyro.
        /// </summary>
        public override abstract IEnumerable<string> SpecialInstructions { get; }
    }
}
