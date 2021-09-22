/*
 * SagittariusGreekSaladTests.cs
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
    /// Unit tests for SagittariusGreekSalad
    /// </summary>
    public class SagittariusGreekSaladTests
    {
        /// <summary>
        /// Checks default size.
        /// </summary>
        [Fact]
        public void SizeShouldDefaultToSmall()
        {
            Side greekSalad = new SagittariusGreekSalad();
            Assert.Equal(Size.Small, greekSalad.Size);
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
            Side greekSalad = new SagittariusGreekSalad();
            greekSalad.Size = size;
            Assert.Equal(size, greekSalad.Size);
        }

        /// <summary>
        /// Checks if different sizes have the correct prices.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="price">The expected price.</param>
        [Theory]
        [InlineData(Size.Small, 2.00)]
        [InlineData(Size.Medium, 2.50)]
        [InlineData(Size.Large, 3.00)]
        public void PriceShouldBeCorrectForSize(Size size, decimal price)
        {
            Side greekSalad = new SagittariusGreekSalad();
            greekSalad.Size = size;
            Assert.Equal(price, greekSalad.Price);
        }

        /// <summary>
        /// Checks if different sizes have the correct calories.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="calories">The expected calories.</param>
        [Theory]
        [InlineData(Size.Small, 180u)]
        [InlineData(Size.Medium, 270u)]
        [InlineData(Size.Large, 360u)]
        public void CaloriesShouldBeCorrectForSize(Size size, uint calories)
        {
            Side greekSalad = new SagittariusGreekSalad();
            greekSalad.Size = size;
            Assert.Equal(calories, greekSalad.Calories);
        }
    }
}
