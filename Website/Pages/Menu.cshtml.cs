/*  Menu
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// Is there a current search out?
        /// </summary>
        public bool curSearch { get; set; }

        /// <summary>
        /// The menu Menu
        /// </summary>
        Menu menu;

        /// <summary>
        /// The minimum price.
        /// </summary>
        [BindProperty]
        public float? minimumPrice { get; set; }

        /// <summary>
        /// The maximum price.
        /// </summary>
        [BindProperty]
        public float? maximumPrice { get; set; }

        /// <summary>
        /// The ingredients that should not be in the food
        /// </summary>
        [BindProperty]
        public List<string> PossibleIngredients { get; set; } = new List<string>();


        /// <summary>
        /// The search value
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// A list of all the available menu categories.
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        /// <summary>
        /// A list of all the available combos
        /// </summary>
        [BindProperty]
        public List<CretaceousCombo> menuListC { get; set; } = new List<CretaceousCombo>();

        /// <summary>
        /// A list of all the available entrees
        /// </summary>
        [BindProperty]
        public List<Entree> menuListE { get; set; } = new List<Entree>();

        /// <summary>
        /// A list of all the available drinks
        /// </summary>
        [BindProperty]
        public List<Drink> menuListD { get; set; } = new List<Drink>();

        /// <summary>
        /// A list of all the available sides
        /// </summary>
        [BindProperty]
        public List<Side> menuListS { get; set; } = new List<Side>();



        /// <summary>
        /// A getter and setter for the method
        /// </summary>
        public Menu Menu { 
            get
            {
                return menu;
            }
        }

        /// <summary>
        /// OnGet a new menu item is created
        /// </summary>
        public void OnGet()
        {
            menu = new Menu();
            curSearch = false;
        }

        /// <summary>
        /// This is what is done to filter the search on post.
        /// </summary>
        public void OnPost()
        {
            menu = new Menu();
            menuListC = new List<CretaceousCombo>();
            menuListE = new List<Entree>();
            menuListS = new List<Side>();
            menuListD = new List<Drink>();
            curSearch = false;
            if ((search == null) && menuCategory.Count == 0)
            {
                curSearch = false;
                foreach (CretaceousCombo men in Menu.AvailableCombos)
                {
                    menuListC.Add(men);
                }
                foreach (Entree men in Menu.AvailableEntrees)
                {
                    menuListE.Add(men);
                }
                foreach (Side men in Menu.AvailableSides)
                {
                    menuListS.Add(men);
                }
                foreach (Drink men in Menu.AvailableDrinks)
                {
                    menuListD.Add(men);
                }
                //Movies = MovieDatabase.Search(search);
                //Movies = MovieDatabase.FilterByMPAA(Movies, mpaa);

            }
            else if (search != null)
            {
                curSearch = true;
                foreach (CretaceousCombo men in Menu.AvailableCombos)
                {
                    if (men.ToString().Contains(search, StringComparison.OrdinalIgnoreCase) && (menuCategory.Count == 0 || menuCategory.Contains("Combo")))
                    {
                        menuListC.Add(men);
                    }
                }
                foreach (Entree men in Menu.AvailableEntrees)
                {
                    if (men.ToString().Contains(search, StringComparison.OrdinalIgnoreCase) && (menuCategory.Count == 0 || menuCategory.Contains("Entree")))
                    {
                        menuListE.Add(men);
                    }
                }
                foreach (Side men in Menu.AvailableSides)
                {
                    if (men.ToString().Contains(search, StringComparison.OrdinalIgnoreCase) && (menuCategory.Count == 0 || menuCategory.Contains("Side")))
                    {
                        menuListS.Add(men);
                    }
                }
                foreach (Drink men in Menu.AvailableDrinks)
                {
                    if (men.ToString().Contains(search, StringComparison.OrdinalIgnoreCase) && (menuCategory.Count == 0 || menuCategory.Contains("Drink")))
                    {
                        menuListD.Add(men);
                    }
                }
            }
            else if(menuCategory.Count > 0)
            {
                if (menuCategory.Contains("Combo"))
                {
                    curSearch = true;
                    foreach (CretaceousCombo men in Menu.AvailableCombos)
                    {
                        menuListC.Add(men);
                    }
                }
                if (menuCategory.Contains("Entree"))
                {
                    curSearch = true;
                    foreach (Entree men in Menu.AvailableEntrees)
                    {
                        menuListE.Add(men);
                    }
                }
                if (menuCategory.Contains("Side"))
                {
                    curSearch = true;
                    foreach (Side men in Menu.AvailableSides)
                    {
                        menuListS.Add(men);
                    }
                }
                if (menuCategory.Contains("Drink"))
                {
                    curSearch = true;
                    foreach (Drink men in Menu.AvailableDrinks)
                    {
                        menuListD.Add(men);
                    }
                }

            }

            if(minimumPrice is float min)
            {
                List<CretaceousCombo> resultC = new List<CretaceousCombo>();
                foreach (CretaceousCombo men in menuListC)
                {
                    if (minimumPrice != null && men.Price >= min)
                    {
                        resultC.Add(men);
                    }
                }
                menuListC = resultC;
                List<Entree> resultE = new List<Entree>();
                foreach (Entree men in menuListE)
                {
                    if (minimumPrice != null && men.Price >= min)
                    {
                        resultE.Add(men);
                    }
                }
                menuListE = resultE;
                List<Side> resultS = new List<Side>();
                foreach (Side men in menuListS)
                {
                    if (minimumPrice != null && men.Price >= min)
                    {
                        resultS.Add(men);
                    }
                }
                menuListS = resultS;
                List<Drink> resultD = new List<Drink>();
                foreach (Drink men in menuListD)
                {
                    if (minimumPrice != null && men.Price >= min)
                    {
                        resultD.Add(men);
                    }
                }
                menuListD = resultD;
            }

            if (maximumPrice is float max)
            {
                List<CretaceousCombo> resultC = new List<CretaceousCombo>();
                foreach (CretaceousCombo men in menuListC)
                {
                    if (maximumPrice != null && men.Price <= max)
                    {
                        resultC.Add(men);
                    }
                }
                menuListC = resultC;
                List<Entree> resultE = new List<Entree>();
                foreach (Entree men in menuListE)
                {
                    if (maximumPrice != null && men.Price <= max)
                    {
                        resultE.Add(men);
                    }
                }
                menuListE = resultE;
                List<Side> resultS = new List<Side>();
                foreach (Side men in menuListS)
                {
                    if (maximumPrice != null && men.Price <= max)
                    {
                        resultS.Add(men);
                    }
                }
                menuListS = resultS;
                List<Drink> resultD = new List<Drink>();
                foreach (Drink men in menuListD)
                {
                    if (maximumPrice != null && men.Price <= max)
                    {
                        resultD.Add(men);
                    }
                }
                menuListD = resultD;
            }

            if(PossibleIngredients.Count > 0)
            {
                foreach (string ing in PossibleIngredients)
                {
                    List<CretaceousCombo> resultC = new List<CretaceousCombo>();
                    foreach (CretaceousCombo men in menuListC)
                    {
                        if(men.Ingredients.Contains(ing) == false)
                        {
                            resultC.Add(men);
                        }
                    }
                    menuListC = resultC;
                    List<Entree> resultE = new List<Entree>();
                    foreach (Entree men in menuListE)
                    {
                        if(men.Ingredients.Contains(ing) == false)
                        {
                            resultE.Add(men);
                        }
                    }
                    menuListE = resultE;
                    List<Side> resultS = new List<Side>();
                    foreach (Side men in menuListS)
                    {
                        if(men.Ingredients.Contains(ing) == false)
                        {
                            resultS.Add(men);
                        }
                    }
                    menuListS = resultS;
                    List<Drink> resultD = new List<Drink>();
                    foreach (Drink men in menuListD)
                    {
                        if(men.Ingredients.Contains(ing) == false)
                        {
                            resultD.Add(men);
                        }
                    }
                    menuListD = resultD;
                }
            }
        }
    }
}