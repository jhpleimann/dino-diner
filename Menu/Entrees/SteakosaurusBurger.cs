/*  SteakosaurusBurger
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This represents the SteakosaurusBurger, a food Entree on the menu
    /// </summary>
    public class SteakosaurusBurger : Entree, IMenuItem
    {
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;


        /// <summary>
        /// This is a list of all the ingredients
        /// that are in the food.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// This is the constructor.
        /// It sets the price and calories
        /// for the food
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
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
        /// Holds whether the pickle
        /// is being held or not
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Holds whether the ketchup
        /// is being held or not
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Holds whether the mustard
        /// is being held or not
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Returns the name of the order
        /// </summary>
        /// <returns>Name of the order</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
