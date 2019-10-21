using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        //The correct default calories
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        //The correct default price
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(0.10, water.Price);
        }

        //The correct default ice
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        //The correct default size
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }

        //correct calories after setting small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }


        //The correct price after setting small
        [Fact]
        public void ShouldUseCorrectPriceForSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal(0.10, water.Price);
        }
        //The correct calories after setting medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToMedium()
        {
            Water water = new Water();
            water.Size = Size.Large;
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        //The correct price after setting medium
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Water water = new Water();
            water.Size = Size.Large;
            water.Size = Size.Medium;
            Assert.Equal(0.10, water.Price);
        }

        //The correct calories after setting large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToLarge()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        //The correct price after setting large
        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Large;
            Assert.Equal(0.10, water.Price);
        }
        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldHaveCorrectIceAfterSettingHoldingIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        //That invoking AddLemon() results in the Lemon property being true
        [Fact]
        public void ShouldHaveCorrectIceAfterSettingAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }


        //The correct ingredients
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Equal<int>(1, water.Ingredients.Count);
            water.AddLemon();
            Assert.Contains<string>("Lemon", water.Ingredients);
            Assert.Equal<int>(2, water.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialForHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.Collection<string>(water.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialForAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Collection<string>(water.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialCombined()
        {
            Water water = new Water();
            water.HoldIce();
            water.AddLemon();

            Assert.Collection<string>(water.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            }, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Theory]
        [InlineData("Special")]
        public void HoldIceShouldNotifyOfPropertyChange(string propertyName)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, propertyName, () =>
            {
                water.HoldIce();
            });
        }

        [Theory]
        [InlineData("Special")]
        public void AddingLemonShouldNotifyOfPropertyChange(string propertyName)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, propertyName, () =>
            {
                water.AddLemon();
            });
        }

        [Theory]
        [InlineData("Description")]
        public void ChangingSizeToSmallShouldNotifyOfPropertyChange(string propertyName)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, propertyName, () =>
            {
                water.Size = Size.Small;
            });
        }

                [Theory]
        [InlineData("Description")]
        public void ChangingSizeToMediumShouldNotifyOfPropertyChange(string propertyName)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, propertyName, () =>
            {
                water.Size = Size.Medium;
            });
        }

        [Theory]
        [InlineData("Description")]
        public void ChangingSizeToShouldNotifyOfPropertyChange(string propertyName)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, propertyName, () =>
            {
                water.Size = Size.Large;
            });
        }
    }
}
