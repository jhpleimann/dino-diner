﻿/*  DinoNuggets
*   Author: Jack Pleimann
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private uint nuggets = 6;

        /// <Summary>
        /// This is a get/set method
        /// that takes will either set
        /// or return the current price
        /// </Summary>
        public double Price { get; set;}

        /// <Summary>
        /// This is a get/set method
        /// that takes will either set
        /// or return the current calories
        /// </Summary>
        public uint Calories {get; set;}

        /// <summary>
        /// This is a list of all the ingredients
        /// that are in the food.
        /// </summary>
        public List<string> Ingredients
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
    }
}
