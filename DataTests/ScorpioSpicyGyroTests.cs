/*
 * ScorpioSpicyGyroTests.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;
using Xunit;
using GyroScope.Data.Entrees;

/// <summary>
/// The NameSpace that contains the Tests classes.
/// </summary>
namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for ScorpioSpicyGyro
    /// </summary>
    public class ScorpioSpicyGyroTests
    {
        /// <summary>
        /// Checks the default ingredients.
        /// </summary>
        [Fact]
        public void DefaultIngredientsShouldBeCorrect()
        {
            Gyro gyro = new ScorpioSpicyGyro();
            Assert.Equal(DonerMeat.Chicken, gyro.Meat);
            Assert.True(gyro.Pita);
            Assert.True(gyro.Peppers);
            Assert.True(gyro.Onion);
            Assert.True(gyro.Lettuce);
            Assert.True(gyro.WingSauce);
        }

        /// <summary>
        /// Checks the default price.
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            Gyro gyro = new ScorpioSpicyGyro();
            Assert.Equal(6.20m, gyro.Price);
        }

        /// <summary>
        /// Checks for correct calories.
        /// </summary>
        /// <param name="meat">The meat used.</param>
        /// <param name="pita">If pita is used.</param>
        /// <param name="tomato">If tomato is used.</param>
        /// <param name="peppers">If peppers are used.</param>
        /// <param name="eggplant">If eggplant is used.</param>
        /// <param name="onion">If onion is used.</param>
        /// <param name="lettuce">If lettuce is used.</param>
        /// <param name="tzatziki">If tzatziki is used.</param>
        /// <param name="wingSauce">If wing sauce is used.</param>
        /// <param name="mintChutney">If mint chutney is used.</param>
        /// <param name="calories">The expected calories.</param>
        [Theory]
        [InlineData(DonerMeat.Chicken, true, false, true, false, true, true, false, true, false, 507u)]
        [InlineData(DonerMeat.Chicken, true, true, true, true, true, true, false, true, false, 584u)]
        [InlineData(DonerMeat.Beef, true, false, true, false, true, true, false, true, false, 575u)]
        [InlineData(DonerMeat.Lamb, true, false, true, false, true, true, false, true, false, 545u)]
        [InlineData(DonerMeat.Pork, true, false, true, false, true, true, false, true, false, 581u)]
        [InlineData(DonerMeat.Chicken, true, false, true, false, true, true, true, true, true, 547u)]
        [InlineData(DonerMeat.Chicken, true, true, true, true, true, true, true, true, true, 624u)]
        [InlineData(DonerMeat.Chicken, false, false, false, false, false, false, false, false, false, 113u)]
        public void CaloriesShouldBeCorrect(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, uint calories)
        {
            Gyro gyro = new ScorpioSpicyGyro();
            gyro.Pita = pita;
            gyro.Meat = meat;
            gyro.Peppers = peppers;
            gyro.Tomato = tomato;
            gyro.Onion = onion;
            gyro.Lettuce = lettuce;
            gyro.Tzatziki = tzatziki;
            gyro.Eggplant = eggplant;
            gyro.WingSauce = wingSauce;
            gyro.MintChutney = mintChutney;
            Assert.Equal(calories, gyro.Calories);
        }

        /// <summary>
        /// Checks for correct special instructions.
        /// </summary>
        /// <param name="meat">The meat used.</param>
        /// <param name="pita">If pita is used.</param>
        /// <param name="tomato">If tomato is used.</param>
        /// <param name="peppers">If peppers are used.</param>
        /// <param name="eggplant">If eggplant is used.</param>
        /// <param name="onion">If onion is used.</param>
        /// <param name="lettuce">If lettuce is used.</param>
        /// <param name="tzatziki">If tzatziki is used.</param>
        /// <param name="wingSauce">If wing sauce is used.</param>
        /// <param name="mintChutney">If mint chutney is used.</param>
        /// <param name="expected">The expected special instructions.</param>
        [Theory]
        [InlineData(DonerMeat.Chicken, true, false, true, false, true, true, false, true, false, new string[0])]
        [InlineData(DonerMeat.Chicken, true, true, true, true, true, true, false, true, false, new string[] { "Add Tomato", "Add Eggplant" })]
        [InlineData(DonerMeat.Beef, true, false, true, false, true, true, false, true, false, new string[] { "Use Beef" })]
        [InlineData(DonerMeat.Lamb, true, false, true, false, true, true, false, true, false, new string[] { "Use Lamb" })]
        [InlineData(DonerMeat.Pork, true, false, true, false, true, true, false, true, false, new string[] { "Use Pork" })]
        [InlineData(DonerMeat.Chicken, true, false, true, false, true, true, true, true, true, new string[] { "Add Tzatziki", "Add Mint Chutney" })]
        [InlineData(DonerMeat.Chicken, true, true, true, true, true, true, true, true, true, new string[] { "Add Tomato", "Add Eggplant", "Add Tzatziki", "Add Mint Chutney" })]
        [InlineData(DonerMeat.Chicken, false, false, false, false, false, false, false, false, false, new string[] { "Hold Pita", "Hold Peppers", "Hold Onion", "Hold Lettuce", "Hold Wing Sauce" })]
        public void SpecialInstructionsShouldReflectIngredients(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, string[] expected)
        {
            Gyro gyro = new ScorpioSpicyGyro();
            gyro.Pita = pita;
            gyro.Meat = meat;
            gyro.Peppers = peppers;
            gyro.Tomato = tomato;
            gyro.Onion = onion;
            gyro.Lettuce = lettuce;
            gyro.Tzatziki = tzatziki;
            gyro.Eggplant = eggplant;
            gyro.WingSauce = wingSauce;
            gyro.MintChutney = mintChutney;



            if (gyro.SpecialInstructions.Count() == expected.Length)
            {
                int i = 0;
                foreach (string item in gyro.SpecialInstructions)
                {
                    Assert.Equal(expected[i], item);
                    i++;
                }
            }
            else
            {
                Assert.Equal(expected.Length, gyro.SpecialInstructions.Count());
            }
        }
    }
}
