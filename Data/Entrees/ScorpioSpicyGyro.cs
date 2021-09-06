/*
 * ScorpioSpicyGyro.cs
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
    /// The class for the Scorpio Spicy Gyro.
    /// </summary>
    public class ScorpioSpicyGyro
    {
        /// <summary>
        /// Field that stores the meat for this gyro.
        /// </summary>
        private DonerMeat _meat = DonerMeat.Chicken;
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
        /// Property containing getter for the price of this gyro.
        /// </summary>
        public decimal Price
        {
            get
            {
                return 6.20m;
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

                if (Peppers == true)
                {
                    _calories += 33;
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

                if (Peppers == false)
                {
                    specialInstructions.Enqueue("Hold Peppers");
                }

                if (Onion == false)
                {
                    specialInstructions.Enqueue("Hold Onion");
                }

                if (Lettuce == false)
                {
                    specialInstructions.Enqueue("Hold Lettuce");
                }

                if (WingSauce == false)
                {
                    specialInstructions.Enqueue("Hold Wing Sauce");
                }

                if (Meat == DonerMeat.Lamb)
                {
                    specialInstructions.Enqueue("Use Lamb");
                }
                else if (Meat == DonerMeat.Pork)
                {
                    specialInstructions.Enqueue("Use Pork");
                }
                else if (Meat == DonerMeat.Beef)
                {
                    specialInstructions.Enqueue("Use Beef");
                }

                return specialInstructions;
            }
        }
    }
}
