/*  Sodasaurus
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// This represents the sdifferent odasaurus flavors available.
    /// </summary>
    public enum SodaSaurusFlavor
    {
        Cola,
        Orange,
        Vanilla,
        Chocolate,
        RootBeer,
        Cherry,
        Lime
    }

    /// <summary>
    /// This is used to show all the detials of
    /// the Sodasaurus option on the menu. Sodasaurus
    /// inherits basic drink features and qualities from Drink.
    /// and also uses the Flavor enum to provide the different flavors
    /// the drink is available in.
    /// </summary>
    public class SodaSaurus : Drink
    {
        private Size size;
        /// <summary>
        /// This is a list of all the flavors available
        /// </summary>
        public SodaSaurusFlavor Flavor { get; set; }

        /// <summary>
        /// This is a list of all the ingredients
        /// that are in the food.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// This is the size of the order.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
        }
        /// <summary>
        /// This is the constructor.
        /// It sets the price and calories
        /// for the food
        /// </summary>
        public SodaSaurus()
        {
            Calories = 112;
            Price = 1.50;
        }
    }
}
