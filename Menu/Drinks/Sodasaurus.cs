﻿/*  Sodasaurus
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This represents the different sodasaurus flavors available.
    /// </summary>
    public enum SodasaurusFlavor
    {
        Cola,
        Orange,
        Vanilla,
        Chocolate,
        RootBeer,
        Cherry,
        Lime
    }

    /// <summary>
    /// This is used to show all the detials of
    /// the Sodasaurus option on the menu. Sodasaurus
    /// inherits basic drink features and qualities from Drink.
    /// and also uses the Flavor enum to provide the different flavors
    /// the drink is available in.
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        private Size size;
        /// <summary>
        /// This is a list of all the flavors available
        /// </summary>

        private SodasaurusFlavor flavor;

        /// <summary>
        /// The getter and setter for Flavor
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// This is a list of all the ingredients
        /// that are in the food.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
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
                        Price = 1.50;
                        Calories = 112;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
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
                return ("Small " + this.Flavor + " Sodasaurus");
            }
            else if (Size == Size.Medium)
            {
                return ("Medium " + this.Flavor + " Sodasaurus");
            }
            else
            {
                return ("Large " + this.Flavor + " Sodasaurus");
            }
        }

        /// <summary>
        /// This is the constructor.
        /// It sets the price and calories
        /// for the food
        /// </summary>
        public Sodasaurus()
        {
            Calories = 112;
            Price = 1.50;
        }

        /// <summary>
        /// Gets the description of the order
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets the special instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> lis = new List<string>();
                if (!Ice)
                {
                    lis.Add("Hold Ice");
                }
                return lis.ToArray();
            }
        }
    }
}
