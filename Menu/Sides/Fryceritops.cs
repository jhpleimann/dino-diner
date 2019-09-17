﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// 
    /// </summary>
    public class Fryceritops : Side
    {
        private Size size;

        /// <summary>
        /// 
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potatoes" };
                ingredients.Add("Salt");
                ingredients.Add("Vegtable Oil");
                return ingredients;
            }
        }

        /// <summary>
        /// 
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
                switch(size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Fryceritops()
        {
            Calories = 222;
            Price = 0.99;
        }
    }
}