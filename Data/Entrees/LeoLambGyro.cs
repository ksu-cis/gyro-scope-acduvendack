/*
 * LeoLambGyro.cs
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
    /// The class for the Leo Lamb Gyro.
    /// </summary>
    public class LeoLambGyro : Gyro, INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// Constructor for a Leo Lamn Gyro.
        /// </summary>
        public LeoLambGyro()
        {
            Meat = DonerMeat.Lamb;
            Pita = true;
            Peppers = false;
            Tomato = true;
            Onion = true;
            Eggplant = true;
            Lettuce = true;
            MintChutney = true;
            Tzatziki = false;
            WingSauce = false;
        }

        /// <summary>
        /// Property containing getter for the price of this gyro.
        /// </summary>
        public override decimal Price
        {
            get
            {
                return 5.75m;
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

                if (Eggplant == false)
                {
                    specialInstructions.Enqueue("Hold Eggplant");
                }

                if (Onion == false)
                {
                    specialInstructions.Enqueue("Hold Onion");
                }

                if (Lettuce == false)
                {
                    specialInstructions.Enqueue("Hold Lettuce");
                }

                if (Tzatziki == true)
                {
                    specialInstructions.Enqueue("Add Tzatziki");
                }

                if (WingSauce == true)
                {
                    specialInstructions.Enqueue("Add Wing Sauce");
                }

                if (MintChutney == false)
                {
                    specialInstructions.Enqueue("Hold Mint Chutney");
                }

                if (Meat == DonerMeat.Chicken)
                {
                    specialInstructions.Enqueue("Use Chicken");
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

        /// <summary>
        /// Returns a string representing the name of the Entree
        /// </summary>
        /// <returns>The name</returns>
        public override string ToString()
        {
            return "Leo Lamb Gyro";
        }

        /// <summary>
        /// Property that returns description of item.
        /// </summary>
        public override string Description
        {
            get
            {
                return "A fresh take on the gyro - seasoned doner lamb, fresh sliced tomato, diced onion, steamed eggplant, and shredded lettuce, smothered in mint chutney and served in a pita.";
            }
        }

        /// <summary>
        /// Read-only item type property
        /// </summary>
        public override string ItemType
        {
            get
            {
                return "Entrees";
            }
        }
    }
}
