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
        /// The menu Menu
        /// </summary>
        Menu menu;

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
        }
    }
}