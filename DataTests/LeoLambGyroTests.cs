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

        /// <summary>
        /// Checks that LeoLambGyro implements INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var gyro = new LeoLambGyro();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(gyro);
        }

        /// <summary>
        /// Checks that associated properties where notified when Meat changed
        /// </summary>
        /// <param name="meat">The meat</param>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData(DonerMeat.Beef, "Meat")]
        [InlineData(DonerMeat.Chicken, "Meat")]
        [InlineData(DonerMeat.Lamb, "Meat")]
        [InlineData(DonerMeat.Pork, "Meat")]
        [InlineData(DonerMeat.Beef, "Calories")]
        [InlineData(DonerMeat.Chicken, "Calories")]
        [InlineData(DonerMeat.Lamb, "Calories")]
        [InlineData(DonerMeat.Pork, "Calories")]
        [InlineData(DonerMeat.Beef, "SpecialInstructions")]
        [InlineData(DonerMeat.Chicken, "SpecialInstructions")]
        [InlineData(DonerMeat.Lamb, "SpecialInstructions")]
        [InlineData(DonerMeat.Pork, "SpecialInstructions")]
        public void ShouldNotifyOfPropertyChangedWhenMeatChanges(DonerMeat meat, string propertyName)
        {
            var gyro = new LeoLambGyro();

            if (meat == DonerMeat.Lamb) { gyro.Meat = DonerMeat.Beef; }

            Assert.PropertyChanged(gyro, propertyName, () =>
            {
                gyro.Meat = meat;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when Pita changed
        /// </summary>
        /// <param name="pita">With or without Pita</param>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData(true, "Pita")]
        [InlineData(false, "Pita")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]
        public void ShouldNotifyOfPropertyChangedWhenPitaChanges(bool pita, string propertyName)
        {
            var gyro = new LeoLambGyro();

            if (pita == true)
            {
                gyro.Pita = false;
            }

            Assert.PropertyChanged(gyro, propertyName, () =>
            {
                gyro.Pita = pita;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when Tomato changed
        /// </summary>
        /// <param name="tomato">With or without Tomato</param>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData(true, "Tomato")]
        [InlineData(false, "Tomato")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]
        public void ShouldNotifyOfPropertyChangedWhenTomatoChanges(bool tomato, string propertyName)
        {
            var gyro = new LeoLambGyro();

            if (tomato == true)
            {
                gyro.Tomato = false;
            }

            Assert.PropertyChanged(gyro, propertyName, () =>
            {
                gyro.Tomato = tomato;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when Onion changed
        /// </summary>
        /// <param name="onion">With or without Onion</param>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData(true, "Onion")]
        [InlineData(false, "Onion")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]
        public void ShouldNotifyOfPropertyChangedWhenOnionChanges(bool onion, string propertyName)
        {
            var gyro = new LeoLambGyro();

            if (onion == true)
            {
                gyro.Onion = false;
            }

            Assert.PropertyChanged(gyro, propertyName, () =>
            {
                gyro.Onion = onion;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when Eggplant changed
        /// </summary>
        /// <param name="eggplant">With or without Eggplant</param>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData(true, "Eggplant")]
        [InlineData(false, "Eggplant")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]
        public void ShouldNotifyOfPropertyChangedWhenEggplantChanges(bool eggplant, string propertyName)
        {
            var gyro = new LeoLambGyro();

            if (eggplant == true)
            {
                gyro.Eggplant = false;
            }

            Assert.PropertyChanged(gyro, propertyName, () =>
            {
                gyro.Eggplant = eggplant;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when Lettuce changed
        /// </summary>
        /// <param name="lettuce">With or without Lettuce</param>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData(true, "Lettuce")]
        [InlineData(false, "Lettuce")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]
        public void ShouldNotifyOfPropertyChangedWhenLettuceChanges(bool lettuce, string propertyName)
        {
            var gyro = new LeoLambGyro();

            if (lettuce == true)
            {
                gyro.Lettuce = false;
            }

            Assert.PropertyChanged(gyro, propertyName, () =>
            {
                gyro.Lettuce = lettuce;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when MintChutney changed
        /// </summary>
        /// <param name="mintChutney">With or without MintChutney</param>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData(true, "MintChutney")]
        [InlineData(false, "MintChutney")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]
        public void ShouldNotifyOfPropertyChangedWhenMintChutneyChanges(bool mintChutney, string propertyName)
        {
            var gyro = new LeoLambGyro();

            if (mintChutney == true)
            {
                gyro.MintChutney = false;
            }

            Assert.PropertyChanged(gyro, propertyName, () =>
            {
                gyro.MintChutney = mintChutney;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when Tzatziki changed
        /// </summary>
        /// <param name="tzatziki">With or without Tzatziki</param>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData(true, "Tzatziki")]
        [InlineData(false, "Tzatziki")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]
        public void ShouldNotifyOfPropertyChangedWhenTzatzikiChanges(bool tzatziki, string propertyName)
        {
            var gyro = new LeoLambGyro();

            if (tzatziki == false)
            {
                gyro.Tzatziki = true;
            }

            Assert.PropertyChanged(gyro, propertyName, () =>
            {
                gyro.Tzatziki = tzatziki;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when Peppers changed
        /// </summary>
        /// <param name="peppers">With or without Peppers</param>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData(true, "Peppers")]
        [InlineData(false, "Peppers")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]
        public void ShouldNotifyOfPropertyChangedWhenPeppersChanges(bool peppers, string propertyName)
        {
            var gyro = new LeoLambGyro();

            if (peppers == false)
            {
                gyro.Peppers = true;
            }

            Assert.PropertyChanged(gyro, propertyName, () =>
            {
                gyro.Peppers = peppers;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when WingSauce changed
        /// </summary>
        /// <param name="wingSauce">With or without WingSauce</param>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData(true, "WingSauce")]
        [InlineData(false, "WingSauce")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]
        public void ShouldNotifyOfPropertyChangedWhenWingSauceChanges(bool wingSauce, string propertyName)
        {
            var gyro = new LeoLambGyro();

            if (wingSauce == false)
            {
                gyro.WingSauce = true;
            }

            Assert.PropertyChanged(gyro, propertyName, () =>
            {
                gyro.WingSauce = wingSauce;
            });
        }

        /// <summary>
        /// Checks that the override ToString method returns the expected string
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            Gyro gyro = new LeoLambGyro();
            Assert.Equal("Leo Lamb Gyro", gyro.ToString());
        }
    }
}
