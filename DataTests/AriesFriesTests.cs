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

        /// <summary>
        /// Checks that AriesFries implements INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var side = new AriesFries();
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
        [InlineData(Size.Small, "Name")]
        [InlineData(Size.Medium, "Name")]
        [InlineData(Size.Large, "Name")]
        public void ShouldNotifyOfPropertyChangedWhenSizeChanges(Size size, string propertyName)
        {
            var side = new AriesFries();

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
        [InlineData(Size.Small, "Small Aries Fries")]
        [InlineData(Size.Medium, "Medium Aries Fries")]
        [InlineData(Size.Large, "Large Aries Fries")]
        public void ToStringShouldReturnExpectedValue(Size size, string name)
        {
            var side = new AriesFries();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }
    }
}
