using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private uint nuggets = 6;

        public double Price { get; set;
        }
        public uint Calories {get; set;
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {};
                for(int i = 0; i < nuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        public void AddNugget()
        {
            this.nuggets++;
            this.Calories += 59;
            this.Price += .25;
        }
    }
}
