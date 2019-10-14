/*  DrinkSelection
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Initializes the compenents
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            buttonDecaf.IsEnabled = false;
            buttonFlavor.IsEnabled = false;
            buttonLemon.IsEnabled = false;
            buttonSweet.IsEnabled = false;
        }

        /// <summary>
        /// Goes to the SelectFlavor page.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Enables the flavor button.
        /// Disables the decaf button.
        /// Disables the lemon button.
        /// Disables the sweet button.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectSoda(object sender, RoutedEventArgs args)
        {
            buttonFlavor.IsEnabled = true;
            buttonDecaf.IsEnabled = false;
            buttonLemon.IsEnabled = false;
            buttonSweet.IsEnabled = false;
        }

        /// <summary>
        /// Enables the sweet button.
        /// Disables the lemon button.
        /// Disables the decaf button.
        /// Disables the flavor button.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectTea(object sender, RoutedEventArgs args)
        {
            buttonLemon.IsEnabled = false;
            buttonSweet.IsEnabled = true;
            buttonDecaf.IsEnabled = false;
            buttonFlavor.IsEnabled = false;
        }

        /// <summary>
        /// Enables the sweet button.
        /// Disables the flavor button.
        /// Disables the decaf button.
        /// Disables the lemon button.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectWater(object sender, RoutedEventArgs args)
        {
            buttonFlavor.IsEnabled = false;
            buttonDecaf.IsEnabled = false;
            buttonLemon.IsEnabled = true;
            buttonSweet.IsEnabled = false;
        }

        /// <summary>
        /// Enables the decaf button.
        /// Disables the flavor button.
        /// Disables the lemon button.
        /// Disables the sweet button.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectJava(object sender, RoutedEventArgs args)
        {
            buttonFlavor.IsEnabled = false;
            buttonDecaf.IsEnabled = true;
            buttonLemon.IsEnabled = false;
            buttonSweet.IsEnabled = false;
        }
    }
}
