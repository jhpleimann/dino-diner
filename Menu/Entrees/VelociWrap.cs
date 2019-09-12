/*  VelociWrap
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

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
                List<string> ingredients = new List<string>() { "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                ingredients.Add("Flour Tortilla");
                return ingredients;
            }
        }

        /// <summary>
        /// This is the constructor.
        /// It sets the price and calories
        /// for the food
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Holds whether the dressing
        /// is being held or not
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Holds whether the lettuce
        /// is being held or not
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Holds whether the cheese
        /// is being held or not
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
