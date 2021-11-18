/*
 * RegisterTests.cs
 * Modified by: Adam Duvendack
 */
using System;
using Xunit;
using GyroScope.Data;
using RoundRegister;

/// <summary>
/// Namespace for the xUnit tests involved with the PointOfSale project
/// </summary>
namespace PointOfSaleTests
{
    /// <summary>
    /// Class containing the xUnit tests for the Register class
    /// </summary>
    public class RegisterTests
    {
        /// <summary>
        /// Checks that GetChange gets the correct amount of change to the customer
        /// </summary>
        /// <param name="expectedChange">The correct amount of change</param>
        /// <param name="total">The total bill</param>
        [Theory]
        [InlineData(0.00, 189.91)]
        [InlineData(184.16, 5.75)]
        [InlineData(174.16, 15.75)]
        [InlineData(164.65, 25.26)]
        [InlineData(89.91, 100.00)]
        [InlineData(148.26, 41.65)]
        [InlineData(143.91, 46.00)]
        [InlineData(9.91, 180.00)]
        public void ChangeShouldBeCorrect(decimal expectedChange, decimal total)
        {
            Register register = new Register();
            register.CustomerHundreds = 1;
            register.CustomerFifties = 1;
            register.CustomerTwenties = 1;
            register.CustomerTens = 1;
            register.CustomerFives = 1;
            register.CustomerTwos = 1;
            register.CustomerOnes = 1;
            register.CustomerDollarCoins = 1;
            register.CustomerHalfDollars = 1;
            register.CustomerQuarters = 1;
            register.CustomerDimes = 1;
            register.CustomerNickels = 1;
            register.CustomerPennies = 1;
            register.GetChange(total);

            Assert.Equal(expectedChange, register.ChangeOwed);
        }

        /// <summary>
        /// Checks that FinalizeSale accurately finalizes the sale with the cash register.
        /// </summary>
        /// <param name="orderTotal">The total bill</param>
        [Theory]
        [InlineData(50.00)]
        [InlineData(40.00)]
        [InlineData(500.50)]
        [InlineData(400.00)]
        [InlineData(235.50)]
        [InlineData(12.00)]
        [InlineData(250.50)]
        [InlineData(17.80)]
        public void ShouldFinalizeSale(decimal orderTotal)
        {
            CashDrawer.ResetDrawer();
            double oldDrawer = CashDrawer.Total;
            Register register = new Register();
            register.CustomerHundreds = 5;
            register.CustomerFifties = 1;
            register.CustomerTwenties = 1;
            register.CustomerTens = 1;
            register.CustomerFives = 1;
            register.CustomerTwos = 1;
            register.CustomerOnes = 1;
            register.CustomerDollarCoins = 1;
            register.CustomerHalfDollars = 1;
            register.CustomerQuarters = 1;
            register.CustomerDimes = 1;
            register.CustomerNickels = 1;
            register.CustomerPennies = 1;
            register.GetChange(orderTotal);
            register.FinalizeTransaction();
            double newDrawer = CashDrawer.Total;
            
            Assert.Equal((decimal)oldDrawer + orderTotal, (decimal)newDrawer);
        }

        /// <summary>
        /// Checks that Register implements INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var register = new Register();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(register);
        }

        /// <summary>
        /// Checks that associated properties where notified when CustomerHundreds changed
        /// </summary>
        /// <param name="hundreds">The number of Customer Hundreds</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenCustomerHundredsChanges(decimal hundreds)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "CustomerHundreds", () =>
            {
                register.CustomerHundreds = hundreds;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when CustomerFifties changed
        /// </summary>
        /// <param name="fifties">The number of Customer Fifties</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenCustomerFiftiesChanges(decimal fifties)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "CustomerFifties", () =>
            {
                register.CustomerFifties = fifties;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when CustomerTwenties changed
        /// </summary>
        /// <param name="twenties">The number of Customer Twenties</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenCustomerTwentiesChanges(decimal twenties)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "CustomerTwenties", () =>
            {
                register.CustomerTwenties = twenties;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when CustomerTens changed
        /// </summary>
        /// <param name="tens">The number of Customer Tens</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenCustomerTensChanges(decimal tens)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "CustomerTens", () =>
            {
                register.CustomerTens = tens;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when CustomerFives changed
        /// </summary>
        /// <param name="fives">The number of Customer Fives</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenCustomerFivesChanges(decimal fives)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "CustomerFives", () =>
            {
                register.CustomerFives = fives;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when CustomerTwos changed
        /// </summary>
        /// <param name="twos">The number of Customer Twos</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenCustomerTwosChanges(decimal twos)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "CustomerTwos", () =>
            {
                register.CustomerTwos = twos;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when CustomerOnes changed
        /// </summary>
        /// <param name="ones">The number of Customer Ones</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenCustomerOnesChanges(decimal ones)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "CustomerOnes", () =>
            {
                register.CustomerOnes = ones;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when CustomerDollarCoins changed
        /// </summary>
        /// <param name="dollarCoins">The number of Customer Dollar Coins</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenCustomerDollarCoinsChanges(decimal dollarCoins)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "CustomerDollarCoins", () =>
            {
                register.CustomerDollarCoins = dollarCoins;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when CustomerHalfDollars changed
        /// </summary>
        /// <param name="halfDollar">The number of Customer Half Dollars</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenCustomerHalfDollarsChanges(decimal halfDollars)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "CustomerHalfDollars", () =>
            {
                register.CustomerHalfDollars = halfDollars;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when CustomerQuarters changed
        /// </summary>
        /// <param name="quarters">The number of Customer Quarters</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenCustomerQuartersChanges(decimal quarters)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "CustomerQuarters", () =>
            {
                register.CustomerQuarters = quarters;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when CustomerDimes changed
        /// </summary>
        /// <param name="dimes">The number of Customer Dimes</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenCustomerDimesChanges(decimal dimes)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "CustomerDimes", () =>
            {
                register.CustomerDimes = dimes;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when CustomerNickels changed
        /// </summary>
        /// <param name="nickels">The number of Customer Nickels</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenCustomerNickelsChanges(decimal nickels)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "CustomerNickels", () =>
            {
                register.CustomerNickels = nickels;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when CustomerPennies changed
        /// </summary>
        /// <param name="pennies">The number of Customer Pennies</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenCustomerPenniesChanges(decimal pennies)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "CustomerPennies", () =>
            {
                register.CustomerPennies = pennies;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when ChangeHundreds changed
        /// </summary>
        /// <param name="hundreds">The number of Change Hundreds</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenChangeHundredsChanges(decimal hundreds)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "ChangeHundreds", () =>
            {
                register.ChangeHundreds = hundreds;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when ChangeFifties changed
        /// </summary>
        /// <param name="fifties">The number of Change Fifties</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenChangeFiftiesChanges(decimal fifties)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "ChangeFifties", () =>
            {
                register.ChangeFifties = fifties;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when ChangeTwenties changed
        /// </summary>
        /// <param name="twenties">The number of Change Twenties</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenChangeTwentiesChanges(decimal twenties)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "ChangeTwenties", () =>
            {
                register.ChangeTwenties = twenties;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when ChangeTens changed
        /// </summary>
        /// <param name="tens">The number of Change Tens</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenChangeTensChanges(decimal tens)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "ChangeTens", () =>
            {
                register.ChangeTens = tens;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when ChangeFives changed
        /// </summary>
        /// <param name="fives">The number of Change Fives</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenChangeFivesChanges(decimal fives)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "ChangeFives", () =>
            {
                register.ChangeFives = fives;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when ChangeTwos changed
        /// </summary>
        /// <param name="twos">The number of Change Twos</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenChangeTwosChanges(decimal twos)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "ChangeTwos", () =>
            {
                register.ChangeTwos = twos;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when ChangeOnes changed
        /// </summary>
        /// <param name="ones">The number of Change Ones</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenChangeOnesChanges(decimal ones)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "ChangeOnes", () =>
            {
                register.ChangeOnes = ones;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when ChangeDollarCoins changed
        /// </summary>
        /// <param name="dollarCoins">The number of Change Dollar Coins</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenChangeDollarCoinsChanges(decimal dollarCoins)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "ChangeDollarCoins", () =>
            {
                register.ChangeDollarCoins = dollarCoins;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when ChangeHalfDollars changed
        /// </summary>
        /// <param name="halfDollar">The number of Change Half Dollars</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenChangeHalfDollarsChanges(decimal halfDollars)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "ChangeHalfDollars", () =>
            {
                register.ChangeHalfDollars = halfDollars;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when ChangeQuarters changed
        /// </summary>
        /// <param name="quarters">The number of Change Quarters</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenChangeQuartersChanges(decimal quarters)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "ChangeQuarters", () =>
            {
                register.ChangeQuarters = quarters;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when ChangeDimes changed
        /// </summary>
        /// <param name="dimes">The number of Change Dimes</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenChangeDimesChanges(decimal dimes)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "ChangeDimes", () =>
            {
                register.ChangeDimes = dimes;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when ChangeNickels changed
        /// </summary>
        /// <param name="nickels">The number of Change Nickels</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenChangeNickelsChanges(decimal nickels)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "ChangeNickels", () =>
            {
                register.ChangeNickels = nickels;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when ChangePennies changed
        /// </summary>
        /// <param name="pennies">The number of Change Pennies</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenChangePenniesChanges(decimal pennies)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "ChangePennies", () =>
            {
                register.ChangePennies = pennies;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when AmountDue changed
        /// </summary>
        /// <param name="due">The amount due</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10.9)]
        [InlineData(100.53)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3.56)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenAmountDueChanges(decimal due)
        {
            var register = new Register();


            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.AmountDue = due;
            });
        }

        /// <summary>
        /// Checks that associated properties where notified when ChangeOwed changed
        /// </summary>
        /// <param name="total">The total bill</param>
        [Theory]
        [InlineData(1)]
        [InlineData(10.9)]
        [InlineData(100.53)]
        [InlineData(1000)]
        [InlineData(1000000000)]
        [InlineData(-3.56)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void ShouldNotifyOfPropertyChangedWhenChangeOwedChanges(decimal total)
        {
            var register = new Register();

            Assert.PropertyChanged(register, "ChangeOwed", () =>
            {
                register.GetChange(total);
            });
        }

        /// <summary>
        /// Checks that the Drawer properties return the correct result
        /// </summary>
        [Fact]
        public void DrawerPropertiesShouldEqualCashDrawerProperties()
        {
            var register = new Register();
            CashDrawer.ResetDrawer();
            Assert.Equal(CashDrawer.Hundreds, register.DrawerHundreds);
            Assert.Equal(CashDrawer.Fifties, register.DrawerFifties);
            Assert.Equal(CashDrawer.Twenties, register.DrawerTwenties);
            Assert.Equal(CashDrawer.Tens, register.DrawerTens);
            Assert.Equal(CashDrawer.Fives, register.DrawerFives);
            Assert.Equal(CashDrawer.Twos, register.DrawerTwos);
            Assert.Equal(CashDrawer.Ones, register.DrawerOnes);
            Assert.Equal(CashDrawer.Dollars, register.DrawerDollarCoins);
            Assert.Equal(CashDrawer.HalfDollars, register.DrawerHalfDollars);
            Assert.Equal(CashDrawer.Quarters, register.DrawerQuarters);
            Assert.Equal(CashDrawer.Dimes, register.DrawerDimes);
            Assert.Equal(CashDrawer.Nickels, register.DrawerNickels);
            Assert.Equal(CashDrawer.Pennies, register.DrawerPennies);
        }
    }
}
