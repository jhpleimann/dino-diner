using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo: IMenuItem
    {
        // Backing Variables
        private Size size;


        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side { get; set; } = new Fryceritops();

        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink { get; set; } = new Sodasaurus();

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }
        /// <summary>
        /// Returns the name of the order
        /// </summary>
        /// <returns>Name of the order</returns>
        public override string ToString()
        {
            if (Entree.ToString().Equals("Brontowurst"))
            {
                return "Brontowurst Combo";
            }
            else if (Entree.ToString().Equals("Dino-Nuggets"))
            {
                return "Dino-Nuggets Combo";
            }
            else if (Entree.ToString().Equals("Prehistoric PB&J"))
            {
                return "Prehistoric PB&J Combo";
            }
            else if (Entree.ToString().Equals("Pterodactyl Wings"))
            {
                return "Pterodactyl Wings Combo";
            }
            else if (Entree.ToString().Equals("Steakosaurus Burger"))
            {
                return "Steakosaurus Burger Combo";
            }
            else if (Entree.ToString().Equals("T-Rex King Burger"))
            {
                return "T-Rex King Burger Combo";
            }
            else
            {
                return "Veloci-Wrap Combo";
            }
        }

        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
        }
    }
}
