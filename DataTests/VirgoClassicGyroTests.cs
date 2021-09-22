/*
 * VirgoClassicGyroTests.cs
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
    /// Unit tests for VirgoClassicGyro
    /// </summary>
    public class VirgoClassicGyroTests
    {
        /// <summary>
        /// Checks the default ingredients.
        /// </summary>
        [Fact]
        public void DefaultIngredientsShouldBeCorrect()
        {
            Gyro gyro = new VirgoClassicGyro();
            Assert.Equal(DonerMeat.Pork, gyro.Meat);
            Assert.True(gyro.Pita);
            Assert.True(gyro.Tomato);
            Assert.True(gyro.Onion);
            Assert.True(gyro.Lettuce);
            Assert.True(gyro.Tzatziki);
        }

        /// <summary>
        /// Checks the default price.
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            Gyro gyro = new VirgoClassicGyro();
            Assert.Equal(5.50m, gyro.Price);
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
        [InlineData(DonerMeat.Pork, true, true, false, false, true, true, true, false, false, 593u)]
        [InlineData(DonerMeat.Pork, true, true, false, false, true, true, true, true, true, 618u)]
        [InlineData(DonerMeat.Beef, true, true, true, true, true, true, true, false, false, 667u)]
        [InlineData(DonerMeat.Chicken, true, true, false, false, true, true, true, false, false, 519u)]
        [InlineData(DonerMeat.Lamb, false, false, false, false, true, true, true, false, false, 265u)]
        [InlineData(DonerMeat.Pork, false, false, false, false, false, false, false, false, false, 187u)]
        [InlineData(DonerMeat.Pork, true, true, true, true, true, true, true, true, true, 698u)]
        [InlineData(DonerMeat.Pork, true, false, true, false, true, false, true, false, true, 552u)]
        public void CaloriesShouldBeCorrect(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, uint calories)
        {
            Gyro gyro = new VirgoClassicGyro();
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
        [InlineData(DonerMeat.Pork, true, true, false, false, true, true, true, false, false, new string[0])]
        [InlineData(DonerMeat.Pork, true, true, false, false, true, true, true, true, true, new string[] { "Add Wing Sauce", "Add Mint Chutney" })]
        [InlineData(DonerMeat.Beef, true, true, true, true, true, true, true, false, false, new string[] { "Add Peppers", "Add Eggplant", "Use Beef" })]
        [InlineData(DonerMeat.Chicken, true, true, false, false, true, true, true, false, false, new string[] { "Use Chicken" })]
        [InlineData(DonerMeat.Lamb, false, false, false, false, true, true, true, false, false, new string[] { "Hold Pita", "Hold Tomato", "Use Lamb"})]
        [InlineData(DonerMeat.Pork, false, false, false, false, false, false, false, false, false, new string[] { "Hold Pita", "Hold Tomato", "Hold Onion", "Hold Lettuce", "Hold Tzatziki" })]
        [InlineData(DonerMeat.Pork, true, true, true, true, true, true, true, true, true, new string[] { "Add Peppers", "Add Eggplant", "Add Wing Sauce", "Add Mint Chutney" })]
        [InlineData(DonerMeat.Pork, true, false, true, false, true, false, true, false, true, new string[] { "Hold Tomato", "Add Peppers", "Hold Lettuce", "Add Mint Chutney" })]
        public void SpecialInstructionsShouldReflectIngredients(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, string[] expected)
        {
            Gyro gyro = new VirgoClassicGyro();
            gyro.Pita = pita;
            gyro.Tomato = tomato;
            gyro.Peppers = peppers;
            gyro.Eggplant = eggplant;
            gyro.Onion = onion;
            gyro.Lettuce = lettuce;
            gyro.Tzatziki = tzatziki;
            gyro.WingSauce = wingSauce;
            gyro.MintChutney = mintChutney;
            gyro.Meat = meat;



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
