/*
 * PiscesFishDishTests.cs
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
    /// Unit tests for PiscesFishDish
    /// </summary>
    public class PiscesFishDishTests
    {
        /// <summary>
        /// Checks the default price.
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            Entree fishDish = new PiscesFishDish();
            Assert.Equal(5.99m, fishDish.Price);
        }

        /// <summary>
        /// Checks for correct calories.
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            Entree fishDish = new PiscesFishDish();
            Assert.Equal(726u, fishDish.Calories);
        }

        /// <summary>
        /// Checks for correct special instructions.
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeEmpty()
        {
            Entree fishDish = new PiscesFishDish();
            Assert.Empty(fishDish.SpecialInstructions);
        }

        /// <summary>
        /// Checks that the override ToString method returns the expected string
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            Entree fishDish = new PiscesFishDish();
            Assert.Equal("Pisces Fish Dish", fishDish.ToString());
        }
    }
}
