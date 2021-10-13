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

        /// <summary>
        /// Checks that CapricornMountainTea implements INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var drink = new CapricornMountainTea();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(drink);
        }

        /// <summary>
        /// Checks that associated properties where notified when Sparkling changed
        /// </summary>
        /// <param name="honey">With or without honey</param>
        /// <param name="propertyName">The property.</param>
        [Theory]
        [InlineData(true, "Honey")]
        [InlineData(false, "Honey")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ShouldNotifyOfPropertyChangedWhenSparklingChanges(bool honey, string propertyName)
        {
            var drink = new CapricornMountainTea();

            if (honey == false) { drink.Honey = true; }

            Assert.PropertyChanged(drink, propertyName, () =>
            {
                drink.Honey = honey;
            });
        }

        /// <summary>
        /// Checks that the override ToString method returns the expected string
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            Drink tea = new CapricornMountainTea();
            Assert.Equal("Capricorn Mountain Tea", tea.ToString());
        }
    }
}
