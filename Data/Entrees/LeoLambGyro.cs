/*
 * LeoLambGyro.cs
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
    /// The class for the Leo Lamb Gyro.
    /// </summary>
    class LeoLambGyro
    {
        /// <summary>
        /// Field that stores the meat for this gyro.
        /// </summary>
        private Enums.DonerMeat _meat = Enums.DonerMeat.Lamb;
        /// <summary>
        /// Meat property with getter and setter.
        /// </summary>
        public Enums.DonerMeat Meat
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

        private bool _tomato = true;
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
        private bool _eggPlant = true;
        /// <summary>
        /// Property with getter and setter for if Egg Plant is used.
        /// </summary>
        public bool EggPlant
        {
            get
            {
                return this._eggPlant;
            }

            set
            {
                this._eggPlant = value;
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
        /// Property containing getter for the price of this gyro.
        /// </summary>
        public decimal Price
        {
            get
            {
                return 5.75m;
            }
        }

        /// <summary>
        /// Field that stores the calories of this gyro.
        /// </summary>
        private uint _calories = 0;
        /// <summary>
        /// Property that gets the calories for this gyro.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Pita == true)
                {
                    _calories += 262;
                }

                if (Tomato == true)
                {
                    _calories += 30;
                }

                if (Onion == true)
                {
                    _calories += 30;
                }

                if (EggPlant == true)
                {
                    _calories += 47;
                }

                if (Lettuce == true)
                {
                    _calories += 54;
                }

                if (MintChutney == true)
                {
                    _calories += 10;
                }

                if (Meat == Enums.DonerMeat.Chicken)
                {
                    _calories += 113;
                }
                else if (Meat == Enums.DonerMeat.Lamb)
                {
                    _calories += 151;
                }
                else if (Meat == Enums.DonerMeat.Pork)
                {
                    _calories += 187;
                }
                else if (Meat == Enums.DonerMeat.Beef)
                {
                    _calories += 181;
                }

                return _calories;
            }
        }

        /// <summary>
        /// Property that gets a list of special instructions for this gyro.
        /// </summary>
        public IEnumerable<string> SpecialInstructions
        {
            get
            {
                Queue<string> specialInstructions = new Queue<string>();
                if (Pita == false)
                {
                    specialInstructions.Enqueue("Hold Pita");
                }

                if (Tomato == false)
                {
                    specialInstructions.Enqueue("Hold Tomato");
                }

                if (Onion == false)
                {
                    specialInstructions.Enqueue("Hold Onion");
                }

                if (Lettuce == false)
                {
                    specialInstructions.Enqueue("Hold Lettuce");
                }

                if (MintChutney == false)
                {
                    specialInstructions.Enqueue("Hold Mint Chutney");
                }

                if (Meat == Enums.DonerMeat.Chicken)
                {
                    specialInstructions.Enqueue("Use Chicken");
                }
                else if (Meat == Enums.DonerMeat.Pork)
                {
                    specialInstructions.Enqueue("Use Pork");
                }
                else if (Meat == Enums.DonerMeat.Beef)
                {
                    specialInstructions.Enqueue("Use Beef");
                }

                return specialInstructions;
            }
        }
    }
}
