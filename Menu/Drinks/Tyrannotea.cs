/*  Tyrannotea
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is used to show all the detials of
    /// the Tyrannotea option on the menu. Tyrannotea
    /// inherits basic drink features and qualities from Drink
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
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
                        if (sweet)
                        {
                            Calories = 16;
                        }
                        else
                        {
                            Calories = 8;
                        }
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
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
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
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
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                }
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
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Holds whether the bun
        /// is being held or not
        /// </summary>
        public void AddLemon()
        {
            this.lemon = true;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns the name of the order
        /// </summary>
        /// <returns>Name of the order</returns>
        public override string ToString()
        {
            if (Size == Size.Small)
            {
                if (Sweet)
                {
                    return "Small Sweet Tyrannotea";
                }
                else
                {
                    return "Small Tyrannotea";
                }
            }
            else if (Size == Size.Medium)
            {
                if (Sweet)
                {
                    return "Medium Sweet Tyrannotea";
                }
                else
                {
                    return "Medium Tyrannotea";
                }
            }
            else
            {
                if (Sweet)
                {
                    return "Large Sweet Tyrannotea";
                }
                else
                {
                    return "Large Tyrannotea";
                }
            }
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
                if (lemon)
                {
                    lis.Add("Add Lemon");
                }
                return lis.ToArray();
            }

        }
    }
}
