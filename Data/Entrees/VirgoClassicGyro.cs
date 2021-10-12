/*
 * VirgoClassicGyro.cs
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
/// The NameSpace that contains the Entree classes.
/// </summary>
namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// The class for the Virgo Classic Gyro.
    /// </summary>
    public class VirgoClassicGyro : Gyro, INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor for a Virgo Classic Gyro.
        /// </summary>
        public VirgoClassicGyro()
        {
            Meat = DonerMeat.Pork;
            Pita = true;
            Peppers = false;
            Tomato = true;
            Eggplant = false;
            MintChutney = false;
            WingSauce = false;
            Onion = true;
            Lettuce = true;
            Tzatziki = true;
        }

        /// <summary>
        /// Property containing getter for the price of this gyro.
        /// </summary>
        public override decimal Price
        {
            get
            {
                return 5.50m;
            }
        }

        /// <summary>
        /// Property that gets a list of special instructions for this gyro.
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
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

                if (Peppers == true)
                {
                    specialInstructions.Enqueue("Add Peppers");
                }

                if (Eggplant == true)
                {
                    specialInstructions.Enqueue("Add Eggplant");
                }

                if (Onion == false)
                {
                    specialInstructions.Enqueue("Hold Onion");
                }

                if (Lettuce == false)
                {
                    specialInstructions.Enqueue("Hold Lettuce");
                }

                if (Tzatziki == false)
                {
                    specialInstructions.Enqueue("Hold Tzatziki");
                }

                if (WingSauce == true)
                {
                    specialInstructions.Enqueue("Add Wing Sauce");
                }

                if (MintChutney == true)
                {
                    specialInstructions.Enqueue("Add Mint Chutney");
                }

                if (Meat == DonerMeat.Lamb)
                {
                    specialInstructions.Enqueue("Use Lamb");
                }
                else if (Meat == DonerMeat.Chicken)
                {
                    specialInstructions.Enqueue("Use Chicken");
                }
                else if (Meat == DonerMeat.Beef)
                {
                    specialInstructions.Enqueue("Use Beef");
                }

                return specialInstructions;
            }
        }

        /// <summary>
        /// Returns a string representing the name of the Entree
        /// </summary>
        /// <returns>The name</returns>
        public override string ToString()
        {
            return "Virgo Classic Gyro";
        }
    }
}
