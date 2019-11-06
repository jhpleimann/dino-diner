/*  FlavorSelection
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Sodasaurus soda;

        private CretaceousCombo combo;
        /// <summary>
        /// Initializes the compenents
        /// </summary>
        public FlavorSelection()
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
        /// <param name="soda">The soda object</param>
        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            if(DataContext is Order order)
            {
                //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
            this.soda = soda;

        }

        /// <summary>
        /// Initializes the compenents
        /// </summary>
        /// <param name="soda">The soda object</param>
        public FlavorSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
            this.combo = combo;

        }

        /// <summary>
        /// Makes the drink the flavor of cherry.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeCherry(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                    if (soda != null)
                    {
                        soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Cherry;
                        NavigationService.Navigate(new DrinkSelection(soda));
                    }
                    else if (combo != null)
                    {
                    if (combo.Drink is Sodasaurus so)
                    {
                        so.Flavor = DinoDiner.Menu.SodasaurusFlavor.Cherry;
                        NavigationService.Navigate(new DrinkSelection(combo));
                    }
                }
            }
        }

        /// <summary>
        /// Makes the drink the flavor of chocolate.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeChocolate(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                     if (soda != null)
                    {
                        soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Chocolate;
                        NavigationService.Navigate(new DrinkSelection(soda));
                    }
                    else if (combo != null)
                    {
                    if (combo.Drink is Sodasaurus so)
                    {
                        so.Flavor = DinoDiner.Menu.SodasaurusFlavor.Chocolate;
                        NavigationService.Navigate(new DrinkSelection(combo));
                    }
                }
            }
        }

        /// <summary>
        /// Makes the drink the flavor of cola.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeCola(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {

                    if (soda != null)
                    {
                        soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Cola;
                        NavigationService.Navigate(new DrinkSelection(soda));
                    }
                    else if (combo != null)
                    {
                    if (combo.Drink is Sodasaurus so)
                    {
                        so.Flavor = DinoDiner.Menu.SodasaurusFlavor.Cola;
                        NavigationService.Navigate(new DrinkSelection(combo));
                    }
                }
            }
        }

        /// <summary>
        /// Makes the drink the flavor of lime.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeLime(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                    if (soda != null)
                    {
                        soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Lime;
                        NavigationService.Navigate(new DrinkSelection(soda));
                    }
                    else if (combo != null) { 
                    if (combo.Drink is Sodasaurus so)
                    {
                        so.Flavor = DinoDiner.Menu.SodasaurusFlavor.Lime;
                        NavigationService.Navigate(new DrinkSelection(combo));
                    }
                }
            }
        }

        /// <summary>
        /// Makes the drink the flavor of orange.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeOrange(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                    if (soda != null)
                    {
                        soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Orange;
                        NavigationService.Navigate(new DrinkSelection(soda));
                    }
                    else if (combo != null)
                    {
                    if (combo.Drink is Sodasaurus so)
                    {
                        so.Flavor = DinoDiner.Menu.SodasaurusFlavor.Orange;
                        NavigationService.Navigate(new DrinkSelection(combo));
                    }
                }
            }
        }

        /// <summary>
        /// Makes the drink the flavor of root beer.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeRootBeer(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                    if (soda != null)
                    {
                        soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.RootBeer;
                        NavigationService.Navigate(new DrinkSelection(soda));
                    }
                    else if (combo != null)
                    {
                    if (combo.Drink is Sodasaurus so)
                    {
                        so.Flavor = DinoDiner.Menu.SodasaurusFlavor.RootBeer;
                        NavigationService.Navigate(new DrinkSelection(combo));
                    }
                }
            }
        }

        /// <summary>
        /// Makes the drink the flavor of vanilla.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeVanilla(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                    if (soda != null)
                    {
                        soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Vanilla;
                        NavigationService.Navigate(new DrinkSelection(soda));
                    }
                    else if (combo != null)
                    {
                    if (combo.Drink is Sodasaurus so)
                    {
                        so.Flavor = DinoDiner.Menu.SodasaurusFlavor.Vanilla;
                        NavigationService.Navigate(new DrinkSelection(combo));
                    }
                }
            }
        }

        /// <summary>
        /// Used when a menu option is changed
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The args argument</param>
        public void OnCurrentChanged(object sender, EventArgs args)//DependencyPropertyChangedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                /*//if (//CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    //Set radio to side.Size property
                    //Disable selected menu side
                }
                else
                {
                    //AddFryceritops.IsEnabled = true;//Use previous soelction.
                } */
            }
        }
    }
}
