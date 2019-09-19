/*  Brontowurst
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This represents the Brontowurst, a food Entree on the menu
    /// </summary>
    public class Brontowurst : Entree
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// This is a list of all the ingredients
        /// that are in the food.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// This is the constructor.
        /// It sets the price and calories
        /// for the food
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Holds whether the bun
        /// is being held or not
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Holds whether the peppers
        /// is being held or not
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Holds whether the onion
        /// is being held or not
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
