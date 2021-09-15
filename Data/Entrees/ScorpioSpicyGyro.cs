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
    public class ScorpioSpicyGyro : Gyro
    {
        /// <summary>
        /// Constructor for a Scorpio Spicy Gyro.
        /// </summary>
        public ScorpioSpicyGyro()
        {
            Meat = DonerMeat.Chicken;
            Pita = true;
            Peppers = true;
            Tomato = false;
            Eggplant = false;
            MintChutney = false;
            Onion = true;
            Lettuce = true;
            WingSauce = true;
            Tzatziki = false;
        }

        /// <summary>
        /// Property containing getter for the price of this gyro.
        /// </summary>
        public override decimal Price
        {
            get
            {
                return 6.20m;
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

                if (Tomato == true)
                {
                    specialInstructions.Enqueue("Add Tomato");
                }

                if (Eggplant == true)
                {
                    specialInstructions.Enqueue("Add Eggplant");
                }

                if (MintChutney == true)
                {
                    specialInstructions.Enqueue("Add MintChutney");
                }

                if (Tzatziki == true)
                {
                    specialInstructions.Enqueue("Add Tzatziki");
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
