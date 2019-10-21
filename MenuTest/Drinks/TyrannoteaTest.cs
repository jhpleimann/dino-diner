using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        //The correct default calories
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        //The correct default price
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        //The correct default ice
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        //The correct default sweet
        [Fact]
        public void ShouldHaveCorrectDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }

        //The correct default lemon
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }
        //The correct default size
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        //correct calories after setting small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }


        //The correct price after setting small
        [Fact]
        public void ShouldUseCorrectPriceForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal(0.99, tea.Price);
        }
        //The correct calories after setting medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        //The correct price after setting medium
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Size = Size.Medium;
            Assert.Equal(1.49, tea.Price);
        }

        //The correct calories after setting large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        //The correct price after setting large
        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Large;
            Assert.Equal(1.99, tea.Price);
        }

        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldHaveCorrectIceAfterSettingHoldingIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        //That invoking AddLemon() results in the Lemon property being true
        [Fact]
        public void ShouldHaveCorrectIceAfterSettingAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        //correct calories after setting sweet and small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSweetAndToSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(16, tea.Calories);
        }

        //The correct calories after setting sweet and medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSweetAndToMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Large;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
        }

        //The correct calories after setting sweet and large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSweetAndToLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Medium;
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }

        //correct calories after setting sweet to true then false and small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterChangingSweetAndSettingToSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        //The correct calories after setting sweet to true then false and medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterChanginhSweetAndSettingToMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;
            tea.Size = Size.Large;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        //The correct calories after setting sweet to true then false and large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterChangingSweetAndSettingToLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;
            tea.Size = Size.Medium;
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }


        //The correct ingredients
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
            tea.AddLemon();
            Assert.Contains<string>("Lemon", tea.Ingredients);
            Assert.Equal<int>(3, tea.Ingredients.Count);
            tea.Sweet = true;
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            Assert.Equal<int>(4, tea.Ingredients.Count);
        }


        [Fact]
        public void ShouldHaveCorrectSpecialForHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Collection<string>(tea.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialForAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialCombined()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            tea.AddLemon();

            Assert.Collection<string>(tea.Special, item =>
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
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, propertyName, () =>
            {
                tea.HoldIce();
            });
        }

        [Theory]
        [InlineData("Special")]
        public void AddingLemonShouldNotifyOfPropertyChange(string propertyName)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, propertyName, () =>
            {
                tea.AddLemon();
            });
        }


        [Theory]
        [InlineData("Description")]
        public void ChangingDecadNotifyOfPropertyChange(string propertyName)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, propertyName, () =>
            {
                tea.Sweet = false;
            });
        }

        [Theory]
        [InlineData("Description")]
        [InlineData("Price")]
        public void ChangingToSizeSmallShouldNotifyOfPropertyChange(string propertyName)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, propertyName, () =>
            {
                tea.Size = Size.Small;
            });
        }

        [Theory]
        [InlineData("Description")]
        [InlineData("Price")]
        public void ChangingToSizeMediumShouldNotifyOfPropertyChange(string propertyName)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, propertyName, () =>
            {
                tea.Size = Size.Medium;
            });
        }

        [Theory]
        [InlineData("Description")]
        [InlineData("Price")]
        public void ChangingToSizeLargeShouldNotifyOfPropertyChange(string propertyName)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, propertyName, () =>
            {
                tea.Size = Size.Large;
            });
        }
    }
}

