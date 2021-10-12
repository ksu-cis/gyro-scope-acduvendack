/*
 * LibraLibationTests.cs
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
    /// Unit tests for LibraLibation
    /// </summary>
    public class LibraLibationTests
    {
        /// <summary>
        /// Checks if default LibraLibation is sparkling.
        /// </summary>
        [Fact]
        public void ShouldDefaultToSparkling()
        {
            LibraLibation libraLibation = new LibraLibation();
            Assert.True(libraLibation.Sparkling);
        }

        /// <summary>
        /// Checks if sparkling can be set.
        /// </summary>
        /// <param name="sparkling">The expected Sparkling setting.</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldBeAbleToSetSparkling(bool sparkling)
        {
            LibraLibation libraLibation = new LibraLibation();
            libraLibation.Sparkling = sparkling;
            Assert.Equal(sparkling, libraLibation.Sparkling);
        }

        /// <summary>
        /// Checks if flavor can be set.
        /// </summary>
        /// <param name="flavor">The flavor.</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral)]
        [InlineData(LibraLibationFlavor.Orangeade)]
        [InlineData(LibraLibationFlavor.PinkLemonada)]
        [InlineData(LibraLibationFlavor.SourCherry)]
        public void ShouldBeAbleToSetFlavor(LibraLibationFlavor flavor)
        {
            LibraLibation libraLibation = new LibraLibation();
            libraLibation.Flavor = flavor;
            Assert.Equal(flavor, libraLibation.Flavor);
        }
        
        /// <summary>
        /// Checks if price is correct for each flavor.
        /// </summary>
        /// <param name="flavor">The flavor.</param>
        /// <param name="price">The expected price.</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral, 1.00)]
        [InlineData(LibraLibationFlavor.Orangeade, 1.00)]
        [InlineData(LibraLibationFlavor.PinkLemonada, 1.00)]
        [InlineData(LibraLibationFlavor.SourCherry, 1.00)]
        public void PriceShouldBeCorrectForFlavor(LibraLibationFlavor flavor, decimal price)
        {
            LibraLibation libraLibation = new LibraLibation();
            libraLibation.Flavor = flavor;
            Assert.Equal(price, libraLibation.Price);
        }

        /// <summary>
        /// Checks if calories are correct for each flavor.
        /// </summary>
        /// <param name="flavor">The flavor.</param>
        /// <param name="calories">The expected calories.</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral, 120u)]
        [InlineData(LibraLibationFlavor.Orangeade, 180u)]
        [InlineData(LibraLibationFlavor.PinkLemonada, 41u)]
        [InlineData(LibraLibationFlavor.SourCherry, 100u)]
        public void CaloriesShouldBeCorrectForFlavor(LibraLibationFlavor flavor, uint calories)
        {
            LibraLibation libraLibation = new LibraLibation();
            libraLibation.Flavor = flavor;
            Assert.Equal(calories, libraLibation.Calories);
        }

        /// <summary>
        /// Checks if the name is correct for each flavor and type of Libra Libation.
        /// </summary>
        /// <param name="flavor">The flavor.</param>
        /// <param name="sparkling">If the drink is sparkling.</param>
        /// <param name="name">The expected name.</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral, true, "Sparkling Biral Libra Libation")]
        [InlineData(LibraLibationFlavor.Orangeade, true, "Sparkling Orangeade Libra Libation")]
        [InlineData(LibraLibationFlavor.PinkLemonada, true, "Sparkling Pink Lemonada Libra Libation")]
        [InlineData(LibraLibationFlavor.SourCherry, true, "Sparkling Sour Cherry Libra Libation")]
        [InlineData(LibraLibationFlavor.Biral, false, "Still Biral Libra Libation")]
        [InlineData(LibraLibationFlavor.Orangeade, false, "Still Orangeade Libra Libation")]
        [InlineData(LibraLibationFlavor.PinkLemonada, false, "Still Pink Lemonada Libra Libation")]
        [InlineData(LibraLibationFlavor.SourCherry, false, "Still Sour Cherry Libra Libation")]
        public void NameShouldBeCorrectForFlavorAndSparkling(LibraLibationFlavor flavor, bool sparkling, string name)
        {
            LibraLibation libraLibation = new LibraLibation();
            libraLibation.Flavor = flavor;
            libraLibation.Sparkling = sparkling;
            Assert.Equal(name, libraLibation.Name);
        }

        /// <summary>
        /// Checks that LibraLibation implements INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var drink = new LibraLibation();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(drink);
        }

        /// <summary>
        /// Checks that associated properties where notified when Flavor changed
        /// </summary>
        /// <param name="flavor">The flavor</param>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral, "Flavor")]
        [InlineData(LibraLibationFlavor.Orangeade, "Flavor")]
        [InlineData(LibraLibationFlavor.PinkLemonada, "Flavor")]
        [InlineData(LibraLibationFlavor.SourCherry, "Flavor")]
        [InlineData(LibraLibationFlavor.Biral, "Calories")]
        [InlineData(LibraLibationFlavor.Orangeade, "Calories")]
        [InlineData(LibraLibationFlavor.PinkLemonada, "Calories")]
        [InlineData(LibraLibationFlavor.SourCherry, "Calories")]
        [InlineData(LibraLibationFlavor.Biral, "Name")]
        [InlineData(LibraLibationFlavor.Orangeade, "Name")]
        [InlineData(LibraLibationFlavor.PinkLemonada, "Name")]
        [InlineData(LibraLibationFlavor.SourCherry, "Name")]
        public void ShouldNotifyOfPropertyChangedWhenFlavorChanges(LibraLibationFlavor flavor, string propertyName)
        {
            var drink = new LibraLibation();

            if (flavor == LibraLibationFlavor.Orangeade) { drink.Flavor = LibraLibationFlavor.Biral; }

            Assert.PropertyChanged(drink, propertyName, () =>
            {
                drink.Flavor = flavor;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when Sparkling changed
        /// </summary>
        /// <param name="sparkling">Sparkling or still</param>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData(true, "Sparkling")]
        [InlineData(false, "Sparkling")]
        [InlineData(true, "Name")]
        [InlineData(false, "Name")]
        public void ShouldNotifyOfPropertyChangedWhenSparklingChanges(bool sparkling, string propertyName)
        {
            var drink = new LibraLibation();

            if (sparkling == true) { drink.Sparkling = false; }

            Assert.PropertyChanged(drink, propertyName, () =>
            {
                drink.Sparkling = sparkling;
            });
        }

        /// <summary>
        /// Checks that the override ToString method returns the expected string
        /// </summary>
        /// <param name="flavor">The flavor</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral, "Biral Libra Libation")]
        [InlineData(LibraLibationFlavor.Orangeade, "Orangeade Libra Libation")]
        [InlineData(LibraLibationFlavor.PinkLemonada, "Pink Lemonada Libra Libation")]
        [InlineData(LibraLibationFlavor.SourCherry, "Sour Cherry Libra Libation")]
        public void ToStringShouldReturnExpectedValue(LibraLibationFlavor flavor, string name)
        {
            var drink = new LibraLibation();
            drink.Flavor = flavor;
            Assert.Equal(name, drink.ToString());
        }
    }
}
