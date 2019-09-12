/*  PterodactylWings
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {
        /// <Summary>
        /// This is a get/set method
        /// that takes will either set
        /// or return the current price
        /// </Summary>
        public double Price { get; set; }

        /// <Summary>
        /// This is a get/set method
        /// that takes will either set
        /// or return the current calories
        /// </Summary>
        public uint Calories { get; set; }

        /// <summary>
        /// This is a list of all the ingredients
        /// that are in the food.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        /// <summary>
        /// This is the constructor.
        /// It sets the price and calories
        /// for the food
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
