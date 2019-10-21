using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialForHoldBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.Collection<string>(bw.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialForHoldPeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.Collection<string>(bw.Special, item =>
            {
                Assert.Equal("Hold Peppers", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialForHoldOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.Collection<string>(bw.Special, item =>
            {
                Assert.Equal("Hold Onion", item);
            });
        }

        [Fact]
        public void ShouldHaveCorrectSpecialCombined()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            bw.HoldOnion();
            bw.HoldPeppers();

            Assert.Collection<string>(bw.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            }, item =>
            {
                Assert.Equal("Hold Onion", item);
            }, item =>
            {
                Assert.Equal("Hold Peppers", item);
            });
        }

        [Theory]
        [InlineData("Special")]
        public void HoldingBunShouldNotifyOfPropertyChange(string propertyName)
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, propertyName, () =>
            {
                bw.HoldBun();
            });
        }

        [Theory]
        [InlineData("Special")]
        public void HoldingOnioneShouldNotifyOfPropertyChange(string propertyName)
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, propertyName, () =>
            {
                bw.HoldOnion();
            });
        }

        [Theory]
        [InlineData("Special")]
        public void HoldingPeppersShouldNotifyOfPropertyChange(string propertyName)
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, propertyName, () =>
            {
                bw.HoldPeppers();
            });
        }
    }

}
