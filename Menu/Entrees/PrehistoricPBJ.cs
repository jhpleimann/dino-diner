/*  PrehistoricPBJ
*   Author: Jack Pleimann
*/
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This represents the PrehistoricPBJ, a food Entree on the menu
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// This is a list of all the ingredients
        /// that are in the food.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// This is the constructor.
        /// It sets the price and calories
        /// for the food
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// <summary>
        /// Holds whether the peanut butter
        /// is being held or not
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }
        /// <summary>
        /// Holds whether the jelly
        /// is being held or not
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
