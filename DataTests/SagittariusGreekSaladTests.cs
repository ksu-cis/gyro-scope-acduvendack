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

        /// <summary>
        /// Checks that SagittariusGreekSalad implements INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var side = new SagittariusGreekSalad();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(side);
        }

        /// <summary>
        /// Checks that associated properties where notified when Size changed
        /// </summary>
        /// <param name="size">The size</param>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData(Size.Small, "Size")]
        [InlineData(Size.Medium, "Size")]
        [InlineData(Size.Large, "Size")]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Medium, "Price")]
        [InlineData(Size.Large, "Price")]
        [InlineData(Size.Small, "Calories")]
        [InlineData(Size.Medium, "Calories")]
        [InlineData(Size.Large, "Calories")]
        public void ShouldNotifyOfPropertyChangedWhenSizeChanges(Size size, string propertyName)
        {
            var side = new SagittariusGreekSalad();

            //A quick hack to avoid not changing size when setting the default size
            if (size == Size.Small) { side.Size = Size.Large; }

            Assert.PropertyChanged(side, propertyName, () =>
            {
                side.Size = size;
            });
        }

        /// <summary>
        /// Checks that the override ToString method returns the expected string
        /// </summary>
        /// <param name="size">The size</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(Size.Small, "Small Sagittarius Greek Salad")]
        [InlineData(Size.Medium, "Medium Sagittarius Greek Salad")]
        [InlineData(Size.Large, "Large Sagittarius Greek Salad")]
        public void ToStringShouldReturnExpectedValue(Size size, string name)
        {
            var side = new SagittariusGreekSalad();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }
    }
}
