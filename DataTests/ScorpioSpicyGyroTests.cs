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

        /// <summary>
        /// Checks that ScorpioSpicyGyro implements INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var gyro = new ScorpioSpicyGyro();
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
            var gyro = new ScorpioSpicyGyro();

            if (meat == DonerMeat.Chicken) { gyro.Meat = DonerMeat.Beef; }

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
            var gyro = new ScorpioSpicyGyro();

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
            var gyro = new ScorpioSpicyGyro();

            if (tomato == false)
            {
                gyro.Tomato = true;
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
            var gyro = new ScorpioSpicyGyro();

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
            var gyro = new ScorpioSpicyGyro();

            if (eggplant == false)
            {
                gyro.Eggplant = true;
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
            var gyro = new ScorpioSpicyGyro();

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
            var gyro = new ScorpioSpicyGyro();

            if (mintChutney == false)
            {
                gyro.MintChutney = true;
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
            var gyro = new ScorpioSpicyGyro();

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
            var gyro = new ScorpioSpicyGyro();

            if (peppers == true)
            {
                gyro.Peppers = false;
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
            var gyro = new ScorpioSpicyGyro();

            if (wingSauce == true)
            {
                gyro.WingSauce = false;
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
            Gyro gyro = new ScorpioSpicyGyro();
            Assert.Equal("Scorpio Spicy Gyro", gyro.ToString());
        }
    }
}
