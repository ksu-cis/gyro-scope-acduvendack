/*
 * CapricornMountainTeaTests.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;
using Xunit;
using GyroScope.Data.Drinks;

/// <summary>
/// The NameSpace that contains the Tests classes.
/// </summary>
namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for CapricornMountainTea
    /// </summary>
    public class CapricornMountainTeaTests
    {
        /// <summary>
        /// Checks if the price is correct with and without honey.
        /// </summary>
        /// <param name="honey">If honey is used.</param>
        /// <param name="price">The expected price.</param>
        [Theory]
        [InlineData(true, 2.50)]
        [InlineData(false, 2.50)]
        public void PriceShouldBeCorrectForHoney(bool honey, decimal price)
        {
            CapricornMountainTea mountainTea = new CapricornMountainTea();
            mountainTea.Honey = honey;
            Assert.Equal(price, mountainTea.Price);
        }

        /// <summary>
        /// Checks if calories are correct with and without honey.
        /// </summary>
        /// <param name="honey">If honey is used.</param>
        /// <param name="calories">The expected calories.</param>
        [Theory]
        [InlineData(true, 64u)]
        [InlineData(false, 0u)]
        public void CaloriesShouldBeCorrectForHoney(bool honey, uint calories)
        {
            CapricornMountainTea mountainTea = new CapricornMountainTea();
            mountainTea.Honey = honey;
            Assert.Equal(calories, mountainTea.Calories);
        }
    }
}
