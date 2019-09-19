/*  Side
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
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
    /// This is the abstract class for all Sides.
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

    }
}
