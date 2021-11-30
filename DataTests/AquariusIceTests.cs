/*
 * AquariusIceTests.cs
 * Modified by: Nathan Bean
 */
using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;

/// <summary>
/// The NameSpace that contains the Tests classes.
/// </summary>
namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for AquariusIce
    /// </summary>
    public class AquariusIceTests
    {
        /// <summary>
        /// Checks default flavor
        /// </summary>
        [Fact]
        public void FlavorShouldDefaultToLemon()
        {
            var ice = new AquariusIce();
            Assert.Equal(AquariusIceFlavor.Lemon, ice.Flavor);
        }

        /// <summary>
        /// Checks that the <paramref name="flavor"/> can be set
        /// </summary>
        /// <param name="flavor">The flavor to use</param>
        [Theory]
        [InlineData(AquariusIceFlavor.BlueRaspberry)]
        [InlineData(AquariusIceFlavor.Lemon)]
        [InlineData(AquariusIceFlavor.Mango)]
        [InlineData(AquariusIceFlavor.Orange)]
        [InlineData(AquariusIceFlavor.Strawberry)]
        [InlineData(AquariusIceFlavor.Watermellon)]
        public void ShouldBeAbleToSetFlavor(AquariusIceFlavor flavor)
        {
            var ice = new AquariusIce();
            ice.Flavor = flavor;
            Assert.Equal(flavor, ice.Flavor);
        }

        /// <summary>
        /// Checks the default size
        /// </summary>
        [Fact]
        public void ShouldDefaultToSmall()
        {
            var ice = new AquariusIce();
            Assert.Equal(Size.Small, ice.Size);
        }

        /// <summary>
        /// Checks the price based on the size 
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(Size.Small, 2.0)]
        [InlineData(Size.Medium, 2.5)]
        [InlineData(Size.Large, 3.0)]
        public void ShouldHaveTheRightPriceForSize(Size size, decimal price)
        {
            var ice = new AquariusIce()
            {
                Size = size
            };
            Assert.Equal(price, ice.Price);

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
            var ice = new AquariusIce() { Size = size };
            Assert.Equal(size, ice.Size);
        }

        /// <summary>
        /// Checks if the name of each size and flavor are correct.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="flavor">The flavor.</param>
        /// <param name="name">The expected name.</param>
        [Theory]
        [InlineData(Size.Small, AquariusIceFlavor.BlueRaspberry, "Small Blue Raspberry Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Lemon, "Small Lemon Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Mango, "Small Mango Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Orange, "Small Orange Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Strawberry, "Small Strawberry Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Watermellon, "Small Watermellon Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.BlueRaspberry, "Medium Blue Raspberry Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Lemon, "Medium Lemon Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Mango, "Medium Mango Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Orange, "Medium Orange Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Strawberry, "Medium Strawberry Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Watermellon, "Medium Watermellon Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.BlueRaspberry, "Large Blue Raspberry Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Lemon, "Large Lemon Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Mango, "Large Mango Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Orange, "Large Orange Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Strawberry, "Large Strawberry Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Watermellon, "Large Watermellon Aquarius Ice")]
        public void ShouldHaveTheRightNameForSizeAndFlavor(Size size, AquariusIceFlavor flavor, string name)
        {
            var ice = new AquariusIce()
            {
                Size = size,
                Flavor = flavor
            };
            Assert.Equal(name, ice.Name);
        }

        /// <summary>
        /// Checks that AquariusIce implements INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var ice = new AquariusIce();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(ice);
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
        [InlineData(Size.Small, "Name")]
        [InlineData(Size.Medium, "Name")]
        [InlineData(Size.Large, "Name")]
        public void ShouldNotifyOfPropertyChangedWhenSizeChanges(Size size, string propertyName)
        {
            var ice = new AquariusIce();

            //A quick hack to avoid not changing size when setting the default size
            if (size == Size.Small) { ice.Size = Size.Large; }

            Assert.PropertyChanged(ice, propertyName, () =>
            {
                ice.Size = size;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when Flavor changed
        /// </summary>
        /// <param name="flavor">The flavor</param>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData(AquariusIceFlavor.Lemon, "Flavor")]
        [InlineData(AquariusIceFlavor.Orange, "Flavor")]
        [InlineData(AquariusIceFlavor.BlueRaspberry, "Flavor")]
        [InlineData(AquariusIceFlavor.Mango, "Flavor")]
        [InlineData(AquariusIceFlavor.Strawberry, "Flavor")]
        [InlineData(AquariusIceFlavor.Watermellon, "Flavor")]
        [InlineData(AquariusIceFlavor.Lemon, "Calories")]
        [InlineData(AquariusIceFlavor.Orange, "Calories")]
        [InlineData(AquariusIceFlavor.BlueRaspberry, "Calories")]
        [InlineData(AquariusIceFlavor.Mango, "Calories")]
        [InlineData(AquariusIceFlavor.Strawberry, "Calories")]
        [InlineData(AquariusIceFlavor.Watermellon, "Calories")]
        [InlineData(AquariusIceFlavor.Lemon, "Name")]
        [InlineData(AquariusIceFlavor.Orange, "Name")]
        [InlineData(AquariusIceFlavor.BlueRaspberry, "Name")]
        [InlineData(AquariusIceFlavor.Mango, "Name")]
        [InlineData(AquariusIceFlavor.Strawberry, "Name")]
        [InlineData(AquariusIceFlavor.Watermellon, "Name")]
        public void ShouldNotifyOfPropertyChangedWhenFlavorChanges(AquariusIceFlavor flavor, string propertyName)
        {
            var ice = new AquariusIce();

            //A quick hack to avoid not changing size when setting the default size
            if (flavor == AquariusIceFlavor.Lemon) { ice.Flavor = AquariusIceFlavor.Orange; }

            Assert.PropertyChanged(ice, propertyName, () =>
            {
                ice.Flavor = flavor;
            });
        }

        /// <summary>
        /// Checks that the override ToString method returns the expected string
        /// </summary>
        /// <param name="size">The size</param>
        /// <param name="flavor">The flavor</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(Size.Small, AquariusIceFlavor.BlueRaspberry, "Small Blue Raspberry Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Lemon, "Small Lemon Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Mango, "Small Mango Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Orange, "Small Orange Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Strawberry, "Small Strawberry Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Watermellon, "Small Watermellon Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.BlueRaspberry, "Medium Blue Raspberry Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Lemon, "Medium Lemon Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Mango, "Medium Mango Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Orange, "Medium Orange Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Strawberry, "Medium Strawberry Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Watermellon, "Medium Watermellon Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.BlueRaspberry, "Large Blue Raspberry Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Lemon, "Large Lemon Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Mango, "Large Mango Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Orange, "Large Orange Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Strawberry, "Large Strawberry Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Watermellon, "Large Watermellon Aquarius Ice")]
        public void ToStringShouldReturnExpectedValue(Size size, AquariusIceFlavor flavor, string name)
        {
            var drink = new AquariusIce();
            drink.Flavor = flavor;
            drink.Size = size;
            Assert.Equal(name, drink.ToString());
        }

        /// <summary>
        /// Checks that the Description property returns the expected value.
        /// </summary>
        [Fact]
        public void DescriptionShouldReturnExpectedValue()
        {
            var treat = new AquariusIce();
            Assert.Equal("Italian flavored ices, the coolest treat you can eat with a spoon!", treat.Description);
        }
    }
}
