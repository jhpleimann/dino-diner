﻿/*  Water
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is the water class it inherits basic
    /// qualities about a drink from Drink. It also is used
    /// for the basic water option on the menu.
    /// </summary>
    public class Water : Drink, IMenuItem
    {
        private Size size;
        private bool sweet = false;
        private bool lemon = false;
        /// <summary>
        /// This is a list of all the ingredients
        /// that are in the food.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (lemon) ingredients.Add("Lemon");
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
                Price = 0.10;
                Calories = 0;
            }
        }
        /// <summary>
        /// Gets and sets the Lemon
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
            }
        }

        /// <summary>
        /// Holds whether the bun
        /// is being held or not
        /// </summary>
        public void AddLemon()
        {
            this.lemon = true;
        }
        /// <summary>
        /// This is the constructor.
        /// It sets the price and calories
        /// for the food
        /// </summary>
        public Water()
        {
            Calories = 0;
            Price = 0.10;
        }

        /// <summary>
        /// Returns the name of the order
        /// </summary>
        /// <returns>Name of the order</returns>
        public override string ToString()
        {
            if (Size == Size.Small)
            {
                return "Small Water";
            }
            else if (Size == Size.Medium)
            {
                return "Medium Water";
            }
            else
            {
                return "Large Water";
            }
        }
    }
}
