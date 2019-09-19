/*  PterodactylWings
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This represents the PterodactylWings, a food Entree on the menu
    /// </summary>
    public class PterodactylWings : Entree
    {

        /// <summary>
        /// This is a list of all the ingredients
        /// that are in the food.
        /// </summary>
        public override List<string> Ingredients
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
