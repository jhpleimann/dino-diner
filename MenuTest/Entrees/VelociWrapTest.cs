using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialForHoldCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.Collection<string>(vw.Special, item =>
            {
                Assert.Equal("Hold Cheese", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialForHoldDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.Collection<string>(vw.Special, item =>
            {
                Assert.Equal("Hold Dressing", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialForHoldLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.Collection<string>(vw.Special, item =>
            {
                Assert.Equal("Hold Lettuce", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialCombined()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            vw.HoldDressing();
            vw.HoldLettuce();

            Assert.Collection<string>(vw.Special, item =>
            {
                Assert.Equal("Hold Dressing", item);
            }, item =>
            {
                Assert.Equal("Hold Lettuce", item);
            }, item =>
            {
                Assert.Equal("Hold Cheese", item);
            });
        }
        [Theory]
        [InlineData("Special")]
        public void HoldingDressingShouldNotifyOfPropertyChange(string propertyName)
        {
             VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, propertyName, () =>
            {
                vw.HoldDressing();
            });
        }

        [Theory]
        [InlineData("Special")]
        public void HoldingLettuceShouldNotifyOfPropertyChange(string propertyName)
        {
             VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, propertyName, () =>
            {
                vw.HoldLettuce();
            });
        }

        [Theory]
        [InlineData("Special")]
        public void HoldingCheeseShouldNotifyOfPropertyChange(string propertyName)
        {
             VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, propertyName, () =>
            {
                vw.HoldCheese();
            });
        }
    }
}
