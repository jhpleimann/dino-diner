/*  CretaceousCombo
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo: IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        // Backing Variables
        private Size size;
        private Entree entree;
        private Side side = new Fryceritops();
        private Drink drink = new Sodasaurus();

        /// <summary>
        /// Used to tell if a property was changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies that a certain property changed.
        /// </summary>
        /// <param name="propertyName">Name of the property changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree {
            get
            {
                return entree;
            }
            set
            {
                entree = value;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side { 
            get
            {
                return side;    
            }set
            {
                side = value;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
            }
        }

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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
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
        /// Gets the description of the order
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
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

        /// <summary>
        /// Gets the special instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> lis = new List<string>();
                lis.AddRange(Entree.Special);
                lis.Add(Side.Description);
                lis.AddRange(Side.Special);
                lis.Add(Drink.Description);
                lis.AddRange(Drink.Special);
                return lis.ToArray();
            }
            //SideOrDrinkChange do event Listener
        }
    }
}
