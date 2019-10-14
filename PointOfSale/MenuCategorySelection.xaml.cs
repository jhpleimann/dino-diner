/*  MenuCategorySelection
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// Initializes the compenents
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Goes to the SelectCombo page.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection());
        }

        /// <summary>
        /// Goes to the SelectEntrees page.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectEntrees(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        /// <summary>
        /// Goes to the SideSelection page.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectSides(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// Goes to the SelectDrinks page.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectDrinks(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
