/*
 * CancerHelvahCakeTests.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;
using Xunit;
using GyroScope.Data.Treats;

/// <summary>
/// The NameSpace that contains the Tests classes.
/// </summary>
namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for CancerHelvahCake
    /// </summary>
    public class CancerHalvaCakeTests
    {
        /// <summary>
        /// Checks the default price.
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            Treat cancerCake = new CancerHalvaCake();
            Assert.Equal(3.00m, cancerCake.Price);
        }

        /// <summary>
        /// Checks for correct calories.
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            Treat cancerCake = new CancerHalvaCake();
            Assert.Equal(272u, cancerCake.Calories);
        }

        /// <summary>
        /// Checks that the override ToString method returns the expected string
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            Treat cake = new CancerHalvaCake();
            Assert.Equal("Cancer Halva Cake", cake.ToString());
        }
    }
}
