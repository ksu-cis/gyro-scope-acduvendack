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

        /// <summary>
        /// Checks that VirgoClassicGyro implements INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var gyro = new VirgoClassicGyro();
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
            var gyro = new VirgoClassicGyro();

            if (meat == DonerMeat.Pork) { gyro.Meat = DonerMeat.Beef; }

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
            var gyro = new VirgoClassicGyro();

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
            var gyro = new VirgoClassicGyro();

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
            var gyro = new VirgoClassicGyro();

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
            var gyro = new VirgoClassicGyro();

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
            var gyro = new VirgoClassicGyro();

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
            var gyro = new VirgoClassicGyro();

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
            var gyro = new VirgoClassicGyro();

            if (tzatziki == true)
            {
                gyro.Tzatziki = false;
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
            var gyro = new VirgoClassicGyro();

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
            var gyro = new VirgoClassicGyro();

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
            Gyro gyro = new VirgoClassicGyro();
            Assert.Equal("Virgo Classic Gyro", gyro.ToString());
        }
    }
}
