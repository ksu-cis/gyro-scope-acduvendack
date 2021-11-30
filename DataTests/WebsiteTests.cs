/*
 * WebsiteTests.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.Pages;
using GyroScope.Data.Entrees;
using GyroScope.Data;
using Xunit;

namespace GyroScope.DataTests
{
    public class WebsiteTests
    {
        /// <summary>
        /// Checks that the search bar functions as expected
        /// </summary>
        [Fact]
        public void SearchFunctionOperatesAsExpected()
        {
            var im = new IndexModel();

            im.OnGet("tomato eggplant", null, 0, 1000, 0.00m, 10.00m);
            IMenuItem gyro = null;
            IMenuItem gyro2 = null;
            IMenuItem fish = null;
            IMenuItem sag1 = null;
            IMenuItem sag2 = null;
            IMenuItem sag3 = null;

            foreach (var item in im.Items)
            {
                if (item.Name == "Virgo Classic Gyro")
                {
                    gyro = item;
                }
                else if (item.Name == "Leo Lamb Gyro")
                {
                    gyro2 = item;
                }
                else if (item.Name == "Pisces Fish Dish")
                {
                    fish = item;
                }
                else if (item.Name == "Small Sagittarius Greek Salad")
                {
                    sag1 = item;
                }
                else if (item.Name == "Medium Sagittarius Greek Salad")
                {
                    sag2 = item;
                }
                else if (item.Name == "Large Sagittarius Greek Salad")
                {
                    sag3 = item;
                }
            }

            Assert.Equal("Virgo Classic Gyro", gyro.Name);
            Assert.Equal("Leo Lamb Gyro", gyro2.Name);
            Assert.Equal("Pisces Fish Dish", fish.Name);
            Assert.Equal("Small Sagittarius Greek Salad", sag1.Name);
            Assert.Equal("Medium Sagittarius Greek Salad", sag2.Name);
            Assert.Equal("Large Sagittarius Greek Salad", sag3.Name);
            Assert.Equal(6, im.Items.Count());
        }

        /// <summary>
        /// Checks that the Search bar functions correctly using a second testing procedure
        /// </summary>
        [Fact]
        public void SearchFunctionOperatesAsExpectedSecondTest()
        {
            var im = new IndexModel();
            im.OnGet("herbs", null, null, null, null, null);
            List<IMenuItem> list = im.Items.ToList();

            Assert.Equal("Small Aries Fries", list[0].Name);
            Assert.Equal("Medium Aries Fries", list[1].Name);
            Assert.Equal("Large Aries Fries", list[2].Name);
            Assert.Equal("Small Taurus Tabuleh", list[3].Name);
            Assert.Equal("Medium Taurus Tabuleh", list[4].Name);
            Assert.Equal("Large Taurus Tabuleh", list[5].Name);
        }

        /// <summary>
        /// Checks that the Menu Category filter functions as expected
        /// </summary>
        /// <param name="words">The categories</param>
        /// <param name="count">The expected filtered menu item count</param>
        [InlineData(new string[] { "Entrees" }, 4)]
        [InlineData(new string[] { "Entrees", "Sides" }, 16)]
        [InlineData(new string[] {"Sides"}, 12)]
        [InlineData(new string[] { "Treats"}, 19)]
        [InlineData(new string[] { "Drinks" }, 5)]
        [InlineData(null, 40)]
        [InlineData(new string[] { "Entrees", "Sides", "Treats", "Drinks"}, 40)]
        [InlineData(new string[] { "Treats", "Drinks"}, 24)]
        [Theory]
        public void MenuCategoryFilterFunctionsAsExpected(string[] words, int count)
        {
            var im = new IndexModel();
            im.OnGet(null, words, 0, 1000, 0.00m, 10.00m);

            Assert.Equal(count, im.Items.Count());
        }

        /// <summary>
        /// Checks that names are searched
        /// </summary>
        [Fact]
        public void CheckThatSearchConsidersName()
        {
            var im = new IndexModel();
            im.OnGet("classic", null, 0, 1000, 0.00m, 10.00m);

            foreach (IMenuItem food in im.Items)
            {
                Assert.Equal("Virgo Classic Gyro", food.Name);
            }
        }

        /// <summary>
        /// Checks that descriptions are searched
        /// </summary>
        [Fact]
        public void CheckThatSearchConsidersDescription()
        {
            var im = new IndexModel();
            im.OnGet("Halibut", null, 0, 1000, 0.00m, 10.00m);

            foreach (IMenuItem food in im.Items)
            {
                Assert.Equal("Pisces Fish Dish", food.Name);
            }
        }

        /// <summary>
        /// Checks that lowercase words are found when searched in uppercase
        /// </summary>
        [Fact]
        public void CheckThatUpperCaseWorks()
        {
            var im = new IndexModel();
            im.OnGet("TWIST", null, 0, 1000, 0.00m, 10.00m);

            foreach(IMenuItem food in im.Items)
            {
                Assert.Equal("Scorpio Spicy Gyro", food.Name);
            }
        }

        /// <summary>
        /// Checks that capitalized words are found even when searched in lowercase
        /// </summary>
        [Fact]
        public void CheckThatLowerCaseWorks()
        {
            var im = new IndexModel();
            im.OnGet("american", null, 0, 1000, 0.00m, 10.00m);

            foreach(IMenuItem food in im.Items)
            {
                Assert.Equal("Virgo Classic Gyro", food.Name);
            }
        }

        /// <summary>
        /// Checks that words are searched in any order
        /// </summary>
        [Fact]
        public void CheckThatWordsWorkInAnyOrder()
        {
            var im = new IndexModel();
            im.OnGet("chicken wing sauce", null, 0, 1000, 0.00m, 10.00m);

            foreach (IMenuItem food in im.Items)
            {
                if (food is ScorpioSpicyGyro)
                {
                    Assert.Equal("Scorpio Spicy Gyro", food.Name);
                }
                else if (food is VirgoClassicGyro)
                {
                    Assert.Equal("Virgo Classic Gyro", food.Name);
                }
                else if (food is PiscesFishDish)
                {
                    Assert.Equal("Pisces Fish Dish", food.Name);
                }
            }
        }

        /// <summary>
        /// Checks that the words are searched individually
        /// </summary>
        /// <param name="words">The search words</param>
        /// <param name="count">The expected filtered menu item count</param>
        [InlineData("Gyro", 3)]
        [InlineData("herbs", 6)]
        [InlineData("tomato", 6)]
        [InlineData("ice", 26)]
        [InlineData("green", 0)]
        [InlineData(null, 40)]
        [InlineData("spicy sauce herbs", 9)]
        [InlineData("gyro cake lemon", 11)]
        [Theory]
        public void WordSearchFilterFunctionsAsExpected(string words, int count)
        {
            var im = new IndexModel();
            im.OnGet(words, null, 0, 1000, 0.00m, 10.00m);

            Assert.Equal(count, im.Items.Count());
        }

        /// <summary>
        /// Checks that the Calorie filter works as expected
        /// </summary>
        /// <param name="calorieLow">The calorie minimum</param>
        /// <param name="calorieHigh">The calorie maximum</param>
        /// <param name="count">The expected filtered menu item count</param>
        [InlineData(null, null, 40)]
        [InlineData(0, 1000, 40)]
        [InlineData(null, 500, 33)]
        [InlineData(200, 800, 14)]
        [InlineData(500, null, 7)]
        [InlineData(400, 600, 5)]
        [InlineData(584, 584, 1)]
        [InlineData(1000, 0, 0)]
        [Theory]
        public void CalorieFilterFunctionsAsExpected(double? calorieLow, double? calorieHigh, int count)
        {
            var im = new IndexModel();
            im.OnGet(null, null, calorieLow, calorieHigh, 0.00m, 10.00m);

            Assert.Equal(count, im.Items.Count());
        }

        /// <summary>
        /// Checks that the Price filter works as expected
        /// </summary>
        /// <param name="priceLow">The price minimum</param>
        /// <param name="priceHigh">The price maximum</param>
        /// <param name="count">The expected filtered menu item count</param>
        [InlineData(null, null, 40)]
        [InlineData(0.00, 10.00, 40)]
        [InlineData(null, 5.00, 36)]
        [InlineData(2.00, 8.00, 33)]
        [InlineData(5.00, null, 4)]
        [InlineData(4.00, 6.00, 3)]
        [InlineData(5.75, 5.75, 1)]
        [InlineData(10.00, 0.00, 0)]
        [Theory]
        public void PriceFilterFunctionsAsExpected(double? priceLow, double? priceHigh, int count)
        {
            var im = new IndexModel();
            im.OnGet(null, null, null, null, (decimal?)priceLow, (decimal?)priceHigh);

            Assert.Equal(count, im.Items.Count());
        }
    }
}
