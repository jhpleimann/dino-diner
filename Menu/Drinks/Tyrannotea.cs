/*  Tyrannotea
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// This is used to show all the detials of
    /// the Tyrannotea option on the menu. Tyrannotea
    /// inherits basic drink features and qualities from Drink
    /// </summary>
    public class Tyrannotea : Drink
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
                ingredients.Add("Tea");
                if (lemon) ingredients.Add("Lemon");
                if (sweet) ingredients.Add("Cane Sugar");
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
                        if(sweet)
                        {
                            Calories = 16;
                        }
                        else
                        {
                            Calories = 8;
                        }
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        if (sweet)
                        {
                            Calories = 32;
                        }
                        else
                        {
                            Calories = 16;
                        }
                        break;
                    case Size.Large:
                        Price = 1.99;
                        if (sweet)
                        {
                            Calories = 64;
                        }
                        else
                        {
                            Calories = 32;
                        }
                        break;
                }
            }
        }
        /// <summary>
        /// Gets and sets the Lemon
        /// </summary>
        public bool Lemon {
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
        /// Gets and sets the Sweet
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
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
        public Tyrannotea()
        {
            Calories = 8;
            Price = 0.99;
        }
    }
}
