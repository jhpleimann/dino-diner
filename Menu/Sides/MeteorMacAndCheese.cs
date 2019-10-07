/*  MeteorMacAndCheese
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This represents the MeteorMacAndCheese, a food Side option on the menu
    /// </summary>
    public class MeteorMacAndCheese : Side, IMenuItem
    {
        private Size size;

        /// <summary>
        /// This is a list of all the ingredients
        /// that are in the food.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Macaroni Noodles" };
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausage");
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
                        Price = 0.99;
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
        }

        /// <summary>
        /// Returns the name of the order
        /// </summary>
        /// <returns>Name of the order</returns>
        public override string ToString()
        {
            if (Size == Size.Small)
            {
                return "Small Meteor Mac and Cheese";
            }
            else if (Size == Size.Medium)
            {
                return "Medium Meteor Mac and Cheese";
            }
            else
            {
                return "Large Meteor Mac and Cheese";
            }
        }

        /// <summary>
        /// This is the constructor.
        /// It sets the price and calories
        /// for the food
        /// </summary>
        public MeteorMacAndCheese()
        {
            Calories = 420;
            Price = 0.99;
        }
    }
}
