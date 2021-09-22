/*
 * TaurusTabulehTests.cs
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
    /// Unit tests for TaurusTabuleh
    /// </summary>
    public class TaurusTabulehTests
    {
        /// <summary>
        /// Checks default size.
        /// </summary>
        [Fact]
        public void SizeShouldDefaultToSmall()
        {
            Side taurusTabuleh = new TaurusTabuleh();
            Assert.Equal(Size.Small, taurusTabuleh.Size);
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
            Side taurusTabuleh = new TaurusTabuleh();
            taurusTabuleh.Size = size;
            Assert.Equal(size, taurusTabuleh.Size);
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
            Side taurusTabuleh = new TaurusTabuleh();
            taurusTabuleh.Size = size;
            Assert.Equal(price, taurusTabuleh.Price);
        }

        /// <summary>
        /// Checks if different sizes have the correct calories.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="calories">The expected calories.</param>
        [Theory]
        [InlineData(Size.Small, 124u)]
        [InlineData(Size.Medium, 186u)]
        [InlineData(Size.Large, 248u)]
        public void CaloriesShouldBeCorrectForSize(Size size, uint calories)
        {
            Side taurusTabuleh = new TaurusTabuleh();
            taurusTabuleh.Size = size;
            Assert.Equal(calories, taurusTabuleh.Calories);
        }
    }
}
