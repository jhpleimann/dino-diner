/*  JurrasicJava
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
    public class JurrasicJava : Drink
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
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
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
            }
        }
        /// <summary>
        /// Holds whether the bun
        /// is being held or not
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.roomForCream = true;
        }
        /// <summary>
        /// Holds whether the bun
        /// is being held or not
        /// </summary>
        public void AddIce()
        {
            this.ice = true;
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
        }
    }
}
