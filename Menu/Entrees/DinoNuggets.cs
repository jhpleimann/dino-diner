/*  DinoNuggets
*   Author: Jack Pleimann
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This represents the DinoNuggets, a food Entree on the menu
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem
    {
        private uint nuggets = 6;
        
        /// <summary>
        /// This is a list of all the ingredients
        /// that are in the food.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {};
                for(int i = 0; i < nuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// This is the constructor.
        /// It sets the price and calories
        /// for the food
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        /// <summary>
        /// Used to add a nugget
        /// to the order
        /// </summary>
        public void AddNugget()
        {
            this.nuggets++;
            this.Calories += 59;
            this.Price += .25;
        }

        /// <summary>
        /// Returns the name of the order
        /// </summary>
        /// <returns>Name of the order</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
