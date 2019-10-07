/*  Drink
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This represents the basic Side, all food options on the side will be modeled after this.
    /// </summary>
    public enum Size
    {
        Small,
        Medium,
        Large
    }
    /// <summary>
    /// This represents the basic Drink, all drink options on the menu will be modeled after this.
    /// </summary>
    public abstract class Drink : IMenuItem
    {
        Size size;
        /// <summary>
        /// This represents the basic Drink, all drink options on the menu will be modeled after this.
        /// </summary>
        public Drink()
        {
            size = Size.Small;
            this.Ice = true;
        }

        bool ice = false;
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets and sets the Ice
        /// </summary>
        public virtual bool Ice
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
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// Holds whether the lettuce
        /// is being held or not
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}