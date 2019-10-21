using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class CretaceousComboTest
    {

        [Fact]
        public void ShouldHaveCorrectSpecialCombined()
        {
            Entree entree = (Entree)Activator.CreateInstance(typeof(Brontowurst));
            CretaceousCombo combo = new CretaceousCombo(entree);
            combo.Entree = new VelociWrap();
            combo.Side = new MezzorellaSticks();
            combo.Drink = new Water();

            Assert.Collection<string>(combo.Special, item =>
            {
                Assert.Equal("Small Mezzorella Sticks", item);
            }, item =>
            {
                Assert.Equal("Small Water", item);
            });
        }

        [Theory]
        [InlineData(typeof(Brontowurst), "Description")]
        [InlineData(typeof(Brontowurst), "Price")]
        public void ChangingSideShouldNotifyOfPropertyChange(Type type, string propertyName)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.PropertyChanged(combo, propertyName, () =>
            {
                combo.Side = new MezzorellaSticks();
            });
        }

        [Theory]
        [InlineData(typeof(Brontowurst), "Description")]
        [InlineData(typeof(Brontowurst), "Price")]
        public void ChangingEntreeShouldNotifyOfPropertyChange(Type type, string propertyName)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.PropertyChanged(combo, propertyName, () =>
            {
                combo.Entree = new PrehistoricPBJ();
            });
        }

        [Theory]
        [InlineData(typeof(Brontowurst), "Description")]
        [InlineData(typeof(Brontowurst), "Price")]
        public void ChangingDrinkShouldNotifyOfPropertyChange(Type type, string propertyName)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.PropertyChanged(combo, propertyName, () =>
            {
                combo.Drink = new Sodasaurus();
            });
        }
    }
}
