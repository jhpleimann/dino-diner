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
        /// The search value
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public List<CretaceousCombo> menuListC { get; set; } = new List<CretaceousCombo>();

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

        public void OnPost()
        {
            menu = new Menu();
            menuListC = new List<CretaceousCombo>();
            curSearch = false;
            if (search == null && menuCategory.Count == 0)
            {
                curSearch = false;
                //Movies = MovieDatabase.Search(search);
                //Movies = MovieDatabase.FilterByMPAA(Movies, mpaa);

            }
            else if(search != null)
            {
                curSearch = true;
                foreach(CretaceousCombo men in Menu.AvailableCombos)
                { 
                    if (men.ToString().Contains(search, StringComparison.OrdinalIgnoreCase))
                    {
                        menuListC.Add(men);
                    }
                }
            }
            else
            {
                curSearch = true;
            }
        }
    }
}