using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        //The correct default calories
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Equal<uint>(2, coffee.Calories);
        }

        //The correct default price
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Equal<double>(0.59, coffee.Price);
        }

        //The correct default ice
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.False(coffee.Ice);
        }

        //The correct default RoomForCream
        [Fact]
        public void ShouldHaveCorrectDefaultSpaceForCream()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.False(coffee.RoomForCream);
        }

        //The correct default size
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, coffee.Size);
        }

        //correct calories after setting small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToSmall()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Medium;
            coffee.Size = Size.Small;
            Assert.Equal<uint>(2, coffee.Calories);
        }


        //The correct price after setting small
        [Fact]
        public void ShouldUseCorrectPriceForSmall()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Medium;
            coffee.Size = Size.Small;
            Assert.Equal(0.59, coffee.Price);
        }
        //The correct calories after setting medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToMedium()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Large;
            coffee.Size = Size.Medium;
            Assert.Equal<uint>(4, coffee.Calories);
        }

        //The correct price after setting medium
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Large;
            coffee.Size = Size.Medium;
            Assert.Equal(0.99, coffee.Price);
        }

        //The correct calories after setting large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToLarge()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Medium;
            coffee.Size = Size.Large;
            Assert.Equal<uint>(8, coffee.Calories);
        }

        //The correct price after setting large
        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Medium;
            coffee.Size = Size.Large;
            Assert.Equal(1.49, coffee.Price);
        }

        //That invoking AddIce() results in the Ice property being true
        [Fact]
        public void ShouldHaveCorrectIceAfterAddingIce()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.AddIce();
            Assert.True(coffee.Ice);
        }

        //That invoking LeaveSpaceForCream() results in the Lemon property being true
        [Fact]
        public void ShouldHaveCorrectIceAfterSettingLeaveRoomForCream()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.LeaveRoomForCream();
            Assert.True(coffee.RoomForCream);
        }

        //The correct ingredients
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Contains<string>("Water", coffee.Ingredients);
            Assert.Contains<string>("Coffee", coffee.Ingredients);
            Assert.Equal<int>(2, coffee.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialForAddIce()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.AddIce();            
            Assert.Collection<string>(coffee.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialForLeaveRoomForCream()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.LeaveRoomForCream();
            Assert.Collection<string>(coffee.Special, item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialCombined()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.AddIce();
            coffee.LeaveRoomForCream();

            Assert.Collection<string>(coffee.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            }, item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
        }

        [Theory]
        [InlineData("Special")]
        public void AddingIceShouldNotifyOfPropertyChange(string propertyName)
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.PropertyChanged(coffee, propertyName, () =>
            {
                coffee.AddIce();
            });
        }

        [Theory]
        [InlineData("Special")]
        public void LeavingRoomForIceShouldNotifyOfPropertyChange(string propertyName)
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.PropertyChanged(coffee, propertyName, () =>
            {
                coffee.LeaveRoomForCream();
            });
        }


        [Theory]
        [InlineData("Description")]
        public void ChangingDecafNotifyOfPropertyChange(string propertyName)
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.PropertyChanged(coffee, propertyName, () =>
            {
                coffee.Decaf = false;
            });
        }

        [Theory]
        [InlineData("Description")]
        [InlineData("Price")]
        public void ChangingSizeToSmallShouldNotifyOfPropertyChange(string propertyName)
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.PropertyChanged(coffee, propertyName, () =>
            {
                coffee.Size = Size.Large;
                coffee.Size = Size.Small;
            });
        }

        [Theory]
        [InlineData("Description")]
        [InlineData("Price")]
        public void ChangingSizeToMediumShouldNotifyOfPropertyChange(string propertyName)
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.PropertyChanged(coffee, propertyName, () =>
            {
                coffee.Size = Size.Medium;
            });
        }

        [Theory]
        [InlineData("Description")]
        [InlineData("Price")]
        public void ChangingSizeToLargeShouldNotifyOfPropertyChange(string propertyName)
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.PropertyChanged(coffee, propertyName, () =>
            {
                coffee.Size = Size.Large;
            });
        }
    }
}
