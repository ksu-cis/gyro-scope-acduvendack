/*
 * LeoLambGyroTests.cs
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
    /// Unit tests for LeoLambGyro
    /// </summary>
    public class LeoLambGyroTests
    {
        /// <summary>
        /// Checks the default ingredients.
        /// </summary>
        [Fact]
        public void DefaultIngredientsShouldBeCorrect()
        {
            Gyro gyro = new LeoLambGyro();
            Assert.Equal(DonerMeat.Lamb, gyro.Meat);
            Assert.True(gyro.Pita);
            Assert.True(gyro.Tomato);
            Assert.True(gyro.Onion);
            Assert.True(gyro.Eggplant);
            Assert.True(gyro.Lettuce);
            Assert.True(gyro.MintChutney);
        }

        /// <summary>
        /// Checks the default price.
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            Gyro gyro = new LeoLambGyro();
            Assert.Equal(5.75m, gyro.Price);
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
        [InlineData(DonerMeat.Lamb, true, true, false, true, false, true, false, false, true, 554u)]
        [InlineData(DonerMeat.Lamb, true, true, false, true, false, true, true, true, true, 599u)]
        [InlineData(DonerMeat.Beef, true, true, false, true, false, true, false, false, true, 584u)]
        [InlineData(DonerMeat.Chicken, true, true, false, true, false, true, false, false, true, 516u)]
        [InlineData(DonerMeat.Pork, true, true, false, true, false, true, false, false, true, 590u)]
        [InlineData(DonerMeat.Lamb, true, true, true, true, true, true, false, false, true, 617u)]
        [InlineData(DonerMeat.Lamb, true, true, true, true, true, true, true, true, true, 662u)]
        [InlineData(DonerMeat.Lamb, false, false, false, false, false, false, false, false, false, 151u)]
        public void CaloriesShouldBeCorrect(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, uint calories)
        {
            Gyro gyro = new LeoLambGyro();
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
        [InlineData(DonerMeat.Lamb, true, true, false, true, true, true, false, false, true, new string[0])]
        [InlineData(DonerMeat.Lamb, true, true, false, false, true, true, true, true, true, new string[] { "Hold Eggplant", "Add Tzatziki", "Add Wing Sauce" })]
        [InlineData(DonerMeat.Beef, true, true, true, true, true, true, true, false, false, new string[] { "Add Peppers", "Add Tzatziki", "Hold Mint Chutney", "Use Beef" })]
        [InlineData(DonerMeat.Chicken, true, true, false, false, true, true, true, false, false, new string[] { "Hold Eggplant", "Add Tzatziki", "Hold Mint Chutney", "Use Chicken" })]
        [InlineData(DonerMeat.Pork, false, false, false, false, true, true, true, false, false, new string[] { "Hold Pita", "Hold Tomato", "Hold Eggplant", "Add Tzatziki", "Hold Mint Chutney", "Use Pork" })]
        [InlineData(DonerMeat.Lamb, false, false, false, false, false, false, false, false, false, new string[] { "Hold Pita", "Hold Tomato", "Hold Eggplant", "Hold Onion", "Hold Lettuce", "Hold Mint Chutney" })]
        [InlineData(DonerMeat.Lamb, true, true, true, true, true, true, true, true, true, new string[] { "Add Peppers", "Add Tzatziki", "Add Wing Sauce" })]
        [InlineData(DonerMeat.Lamb, true, false, true, false, true, false, true, false, true, new string[] { "Hold Tomato", "Add Peppers", "Hold Eggplant", "Hold Lettuce", "Add Tzatziki" })]
        public void SpecialInstructionsShouldReflectIngredients(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, string[] expected)
        {
            Gyro gyro = new LeoLambGyro();
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
