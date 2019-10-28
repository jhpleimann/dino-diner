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
using DinoDiner.Menu;
using System.ComponentModel;
using System.Collections.Specialized;

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
            buttonIce.IsEnabled = false;
            buttonCream.IsEnabled = false;
            if (DataContext is Order order)
            {
                CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
        }

        /// <summary>
        /// Initializes the compenents
        /// </summary>
        /// <param name="drink">The drink object</param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            buttonDecaf.IsEnabled = false;
            buttonFlavor.IsEnabled = false;
            buttonLemon.IsEnabled = false;
            buttonSweet.IsEnabled = false;
            buttonIce.IsEnabled = false;
            buttonCream.IsEnabled = false;
            if (DataContext is Order order)
            {
                CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }

        }

        /// <summary>
        /// The drink object.
        /// </summary>
        Drink drink;

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
        /// Modifies the sweet page.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectSweet(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is Tyrannotea tea)
                    {
                        if(tea.Sweet == false)
                        {
                            tea.Sweet = true;
                        }
                        else
                        {
                            tea.Sweet = false;
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Modifies the lemon option.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectLemon(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is Water water)
                    {
                        if (water.Lemon == false)
                        {
                            water.Lemon = true;
                        }
                        else
                        {
                            water.Lemon = false;
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Modifies the ice option.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectIce(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is Water water)
                    {
                        if (water.Ice == false)
                        {
                            water.Ice = true;
                        }
                        else
                        {
                            water.Ice = false;
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Modifies the decaf option.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectDecaf(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is JurrasicJava java)
                    {
                        if (java.Decaf == false)
                        {
                            java.Decaf = true;
                        }
                        else
                        {
                            java.Decaf = false;
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Modifies the cream option.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectCream(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is JurrasicJava java)
                    {
                        if (java.RoomForCream == false)
                        {
                            java.RoomForCream = true;
                        }
                        else
                        {
                            java.RoomForCream = false;
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Goes to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
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
            buttonIce.IsEnabled = false;
            buttonCream.IsEnabled = false;
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Items.Add(drink);//new Fryceritops());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
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
            buttonIce.IsEnabled = false;
            buttonCream.IsEnabled = false;
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Items.Add(drink);//new Fryceritops());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
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
            buttonIce.IsEnabled = true;
            buttonCream.IsEnabled = false;
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Items.Add(drink);//new Fryceritops());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
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
            buttonIce.IsEnabled = false;
            buttonCream.IsEnabled = true;
            if (DataContext is Order order)
            {
                drink = new JurrasicJava();
                order.Items.Add(drink);//new Fryceritops());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        /// <summary>
        /// Makes the order large.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeLarge(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Size = DinoDiner.Menu.Size.Large;
                }
            }
        }

        /// <summary>
        /// Make the order medium.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Size = DinoDiner.Menu.Size.Medium;
                }
            }
        }

        /// <summary>
        /// Makes the order small.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Size = DinoDiner.Menu.Size.Small;
                }
            }
        }

        /// <summary>
        /// Used when a menu option is changed
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The args argument</param>
        public void OnCurrentChanged(object sender, EventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    //Set radio to side.Size property
                    //Disable selected menu side
                }
                else
                {
                    //AddFryceritops.IsEnabled = true;
                }
            }
        }
    }
}
