/*  JurrasicJava
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
    public class JurrasicJava : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        private Size size;
        private bool ice = false;
        private bool roomForCream = false;
        private bool decaf = false;

        /// <summary>
        /// This is a list of all the ingredients
        /// that are in the food.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                ingredients.Add("Coffee");
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
                        Price = 0.59;
                        Calories = 2;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                }
            }
        }
        /// <summary>
        /// Gets and sets the Ice
        /// </summary>
        public override bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }

        /// <summary>
        /// Gets and sets the RoomForCream
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
            }
        }

        /// <summary>
        /// Gets and sets the Decad
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                NotifyOfPropertyChanged("Description");
            }
        }
        /// <summary>
        /// Holds whether the bun
        /// is being held or not
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.roomForCream = true;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Holds whether the bun
        /// is being held or not
        /// </summary>
        public void AddIce()
        {
            this.ice = true;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This is the constructor.
        /// It sets the price and calories
        /// for the food
        /// </summary>

        public JurrasicJava()
        {
            Calories = 2;
            Price = 0.59;
            this.ice = false;
        }

        /// <summary>
        /// Returns the name of the order
        /// </summary>
        /// <returns>Name of the order</returns>
        public override string ToString()
        {
            if (Size == Size.Small)
            {
                if(Decaf)
                {
                    return "Small Decaf Jurassic Java";
                }
                else
                {
                    return "Small Jurassic Java";
                }
            }
            else if(Size == Size.Medium)
            {
                if (Decaf)
                {
                    return "Medium Decaf Jurassic Java";
                }
                else
                {
                    return "Medium Jurassic Java";
                }
            }
            else
            {
                if (Decaf)
                {
                    return "Large Decaf Jurassic Java";
                }
                else
                {
                    return "Large Jurassic Java";
                }
            }
        }

        /// <summary>
        /// Gets the description of the order
        /// </summary>
        public override string Description { 
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets the special instructions
        /// </summary>
        public override string[] Special { 
            get
            {
                List<string> lis = new List<string>();
                if (ice)
                {
                    lis.Add("Add Ice");
                }
                if (roomForCream)
                {
                    lis.Add("Leave Room For Cream");
                }
                return lis.ToArray();
            }
        }
    }
}
