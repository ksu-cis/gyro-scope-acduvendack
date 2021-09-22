/*
 * AriesFriesTests.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;
using Xunit;
using GyroScope.Data.Sides;

/// <summary>
/// The NameSpace that contains the Tests classes.
/// </summary>
namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for AriesFries
    /// </summary>
    public class AriesFriesTests
    {
        /// <summary>
        /// Checks default size.
        /// </summary>
        [Fact]
        public void SizeShouldDefaultToSmall()
        {
            Side ariesFries = new AriesFries();
            Assert.Equal(Size.Small, ariesFries.Size);
        }
        
        /// <summary>
        /// Checks if size can be set.
        /// </summary>
        /// <param name="size">The expected size.</param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldBeAbleToSetSize(Size size)
        {
            Side ariesFries = new AriesFries();
            ariesFries.Size = size;
            Assert.Equal(size, ariesFries.Size);
        }

        /// <summary>
        /// Checks if different sizes have the correct prices.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="price">The expected price.</param>
        [Theory]
        [InlineData(Size.Small, 1.50)]
        [InlineData(Size.Medium, 2.00)]
        [InlineData(Size.Large, 2.50)]
        public void PriceShouldBeCorrectForSize(Size size, decimal price)
        {
            Side ariesFries = new AriesFries();
            ariesFries.Size = size;
            Assert.Equal(price, ariesFries.Price);
        }

        /// <summary>
        /// Checks if different sizes have the correct calories.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="calories">The expected calories.</param>
        [Theory]
        [InlineData(Size.Small, 304u)]
        [InlineData(Size.Medium, 456u)]
        [InlineData(Size.Large, 608u)]
        public void CaloriesShouldBeCorrectForSize(Size size, uint calories)
        {
            Side ariesFries = new AriesFries();
            ariesFries.Size = size;
            Assert.Equal(calories, ariesFries.Calories);
        }
    }
}
