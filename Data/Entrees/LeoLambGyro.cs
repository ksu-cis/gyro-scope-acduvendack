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

/// <summary>
/// The NameSpace that contains the Entree classes.
/// </summary>
namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// The class for the Leo Lamb Gyro.
    /// </summary>
    public class LeoLambGyro : Gyro
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
    }
}
