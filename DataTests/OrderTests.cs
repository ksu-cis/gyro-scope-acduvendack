/*
 * OrderTests.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using GyroScope.Data;
using System.Collections.Specialized;
using GyroScope.Data.Sides;
using GyroScope.Data.Entrees;
using GyroScope.Data.Drinks;

/// <summary>
/// The NameSpace that contains the Tests classes.
/// </summary>
namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for Order
    /// </summary>
    public class OrderTests
    {
        /// <summary>
        /// Test that adding an object to the collection causes a notification
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCollectionChangedOnAdd()
        {
            var order = new Order();
            NotifyCollectionChangedEventArgs args = null;
            order.CollectionChanged += (sender, e) =>
            {
                args = e;
            };
            var menuItem = new SagittariusGreekSalad();
            order.Add(menuItem);
            Assert.NotNull(args);
            Assert.Equal(NotifyCollectionChangedAction.Add, args.Action);
            Assert.Equal(menuItem, args.NewItems[0]);
            Assert.Equal(1, args.NewItems.Count);
            Assert.Null(args.OldItems);
        }

        /// <summary>
        /// Test that removing an object from the collection causes a notification
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCollectionChangedOnRemove()
        {
            var order = new Order();
            NotifyCollectionChangedEventArgs args = null;
            order.CollectionChanged += (sender, e) =>
            {
                args = e;
            };
            var menuItem = new SagittariusGreekSalad();
            order.Add(menuItem);
            order.Remove(menuItem);
            Assert.NotNull(args);
            Assert.Equal(NotifyCollectionChangedAction.Remove, args.Action);
            Assert.Equal(menuItem, args.OldItems[0]);
            Assert.Equal(1, args.OldItems.Count);
            Assert.Null(args.NewItems);
        }

        /// <summary>
        /// Checks that LeoLambGyro implements INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var order = new Order();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(order);
        }

        /// <summary>
        /// Checks that LeoLambGyro implements INotifyCollectionChanged
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyCollectionChanged()
        {
            var order = new Order();
            Assert.IsAssignableFrom<System.Collections.Specialized.INotifyCollectionChanged>(order);
        }

        /// <summary>
        /// Test that adding an item to the list actually adds an item
        /// </summary>
        [Fact]
        public void ShouldAddItemToOrderOnAdd()
        {
            var side = new SagittariusGreekSalad();
            var order = new Order();
            order.Add(side);
            Assert.Equal(side, order[0]);
        }

        /// <summary>
        /// Test that removing an item from the list actually removes an item
        /// </summary>
        [Fact]
        public void ShouldRemoveItemFromOrderOnRemove()
        {
            var side = new SagittariusGreekSalad();
            var order = new Order();
            order.Add(side);
            order.Remove(side);
            Assert.Empty(order);
        }

        /// <summary>
        /// Test that properties are notified when an object is added to the order
        /// </summary>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        [InlineData("Count")]
        public void ShouldNotifyOfPropertyChangedOnAdd(string propertyName)
        {
            var side = new SagittariusGreekSalad();
            var order = new Order();
            

            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Add(side);
            });
        }

        /// <summary>
        /// Test that properties are notified when an object is removed from the order
        /// </summary>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        [InlineData("Count")]
        public void ShouldNotifyOfPropertyChangedWhenOnRemove(string propertyName)
        {
            var side = new SagittariusGreekSalad();
            var order = new Order();
            order.Add(side);

            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Remove(side);
            });
        }

        /// <summary>
        /// Test that properties are notified when an object within the order is modified
        /// </summary>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        public void ShouldNotifyOfPropertyChangedItemModified(string propertyName)
        {
            var side = new SagittariusGreekSalad();
            var order = new Order();
            order.Add(side);
            

            Assert.PropertyChanged(order, propertyName, () =>
            {
                side.Size = Data.Enums.Size.Large;
            });
        }

        /// <summary>
        /// Test that properties are notified when SalesTaxRate is changed
        /// </summary>
        /// <param name="propertyName">The property</param>
        [Theory]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("SalesTaxRate")]
        public void ShouldNotifyOfPropertyChangedWhenSalesTaxChanged(string propertyName)
        {
            var side = new SagittariusGreekSalad();
            var order = new Order();
            order.Add(side);

            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.SalesTaxRate = 3;
            });
        }

        /// <summary>
        /// Checks that the Number property returns the correct value
        /// </summary>
        [Fact]
        public void ChecksThatOrderNumberIsCorrect()
        {
            var order = new Order();
            var order2 = new Order();
            var order3 = new Order();
            Assert.Equal(1, order.Number);
            Assert.Equal(2, order2.Number);
            Assert.Equal(3, order3.Number);
        }
    }
}
