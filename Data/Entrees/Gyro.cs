using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
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

        public override abstract decimal Price { get; }

        public override abstract uint Calories { get; }

        public override abstract IEnumerable<string> SpecialInstructions { get; }
    }
}
