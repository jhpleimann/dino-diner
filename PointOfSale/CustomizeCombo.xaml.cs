/*  CustomizeCombo
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
using DinoDiner.Menu;
using System.ComponentModel;
using System.Collections.Specialized;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// The side object
        /// </summary>
        private CretaceousCombo combo;
        /// <summary>
        /// Initializes the compenents
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
        }

        /// <summary>
        /// Initializes the compenents
        /// </summary>
        public CustomizeCombo(CretaceousCombo cBo)
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
            this.combo = cBo;
        }

        /// <summary>
        /// Makes the order large.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeLarge(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                combo.Size = DinoDiner.Menu.Size.Large;
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Make the order medium.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeMedium(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                combo.Size = DinoDiner.Menu.Size.Medium;
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Makes the order small.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeSmall(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                combo.Size = DinoDiner.Menu.Size.Small;
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Goes to the select drink page.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }

        /// <summary>
        /// Goes to the SideSelection page.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }
        public void SelectEntree(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeCustomization(combo));
        }

        /// <summary>
        /// Used when a menu option is changed
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The args argument</param>x
        public void OnCurrentChanged(object sender, EventArgs args)//DependencyPropertyChangedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {

            }
        }
    }
}
