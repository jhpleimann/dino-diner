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
                //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
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
                //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
            this.drink = drink;
            updateDrink();
        }

        /// Initializes the compenents
        /// </summary>
        /// <param name="drink">The drink object</param>
        public DrinkSelection(CretaceousCombo combo)
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
                //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
            this.combo = combo;
            updateComboDrink();
        }
        
        /// <summary>
        /// Updates the buttons when a combo is imported
        /// </summary>
        public void updateComboDrink()
        {
            if (combo.Drink is Sodasaurus soda)
            {
                buttonFlavor.IsEnabled = true;
                buttonDecaf.IsEnabled = false;
                buttonLemon.IsEnabled = false;
                buttonSweet.IsEnabled = false;
                buttonIce.IsEnabled = false;
                buttonCream.IsEnabled = false;
            }
            else if (combo.Drink is Tyrannotea tea)
            {
                buttonLemon.IsEnabled = false;
                buttonSweet.IsEnabled = true;
                buttonDecaf.IsEnabled = false;
                buttonFlavor.IsEnabled = false;
                buttonIce.IsEnabled = false;
                buttonCream.IsEnabled = false;
            }
            else if (combo.Drink is Water water)
            {
                buttonFlavor.IsEnabled = false;
                buttonDecaf.IsEnabled = false;
                buttonLemon.IsEnabled = true;
                buttonSweet.IsEnabled = false;
                buttonIce.IsEnabled = true;
                buttonCream.IsEnabled = false;
            }
            else if (combo.Drink is JurrasicJava java)
            {
                buttonFlavor.IsEnabled = false;
                buttonDecaf.IsEnabled = true;
                buttonLemon.IsEnabled = false;
                buttonSweet.IsEnabled = false;
                buttonIce.IsEnabled = false;
                buttonCream.IsEnabled = true;
            }
        }

        /// <summary>
        /// Updates the buttons when a drink is added
        /// </summary>
        public void updateDrink()
        {
            if(drink is Sodasaurus soda)
            {
                buttonFlavor.IsEnabled = true;
                buttonDecaf.IsEnabled = false;
                buttonLemon.IsEnabled = false;
                buttonSweet.IsEnabled = false;
                buttonIce.IsEnabled = false;
                buttonCream.IsEnabled = false;
            }
            else if(drink is Tyrannotea tea)
            {
                buttonLemon.IsEnabled = false;
                buttonSweet.IsEnabled = true;
                buttonDecaf.IsEnabled = false;
                buttonFlavor.IsEnabled = false;
                buttonIce.IsEnabled = false;
                buttonCream.IsEnabled = false;
            }
            else if(drink is Water water)
            {
                buttonFlavor.IsEnabled = false;
                buttonDecaf.IsEnabled = false;
                buttonLemon.IsEnabled = true;
                buttonSweet.IsEnabled = false;
                buttonIce.IsEnabled = true;
                buttonCream.IsEnabled = false;
            }
            else if(drink is JurrasicJava java)
            {
                buttonFlavor.IsEnabled = false;
                buttonDecaf.IsEnabled = true;
                buttonLemon.IsEnabled = false;
                buttonSweet.IsEnabled = false;
                buttonIce.IsEnabled = false;
                buttonCream.IsEnabled = true;
            }
        }

        /// <summary>
        /// The drink object.
        /// </summary>
        Drink drink;

        /// <summary>
        /// The combo object.
        /// </summary>
        CretaceousCombo combo;

        /// <summary>
        /// Goes to the SelectFlavor page.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectFlavor(object sender, RoutedEventArgs args)
        {
            if(drink != null)
            {
                NavigationService.Navigate(new FlavorSelection((Sodasaurus)drink));
            }
            else if(combo != null)
            {
                combo.Drink = combo.Drink;
                NavigationService.Navigate(new FlavorSelection(combo));
            }
            
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
                if (drink != null)
                {
                    if (drink is Tyrannotea tea)
                    {
                        if (tea.Sweet == false)
                        {
                            tea.Sweet = true;
                        }
                        else
                        {
                            tea.Sweet = false;
                        }
                    }
                }
                else if(combo != null)
                {
                    if (combo.Drink is Tyrannotea tea)
                    {
                        if (tea.Sweet == false)
                        {
                            tea.Sweet = true;
                        }
                        else
                        {
                            tea.Sweet = false;
                        }
                    }
                    
                    //order.Add(drink);//new Fryceritops());
                }//CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
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
                if (drink != null)
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
                else if (combo != null)
                {
                    if (combo.Drink is Water water)
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

                    //order.Add(drink);//new Fryceritops());
                }//CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
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

                if (drink != null)
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
                else if (combo != null)
                {
                    if (combo.Drink is Water water)
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

                    //order.Add(drink);//new Fryceritops());
                }//CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
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
                if (drink != null)
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
                else if (combo != null)
                {
                    if (combo.Drink is JurrasicJava java)
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

                    //order.Add(drink);//new Fryceritops());
                }//CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
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
                if(drink != null)
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
                else if (combo != null)
                {
                    if (combo.Drink is JurrasicJava java)
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

                    //order.Add(drink);//new Fryceritops());
                }//CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
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
                if (combo == null)
                {
                    drink = new Sodasaurus();
                    order.Add(drink);
                }
                else
                {
                    drink = new Sodasaurus();
                    combo.Drink = drink;
                    //order.Add(drink);//new Fryceritops());
                }//CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
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
                if (combo == null)
                {
                    drink = new Tyrannotea();
                    order.Add(drink);
                }
                else
                {
                    drink = new Tyrannotea();
                    combo.Drink = drink;
                    //order.Add(drink);//new Fryceritops());
                }//CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
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
                    if (combo == null)
                    {
                        drink = new Water();
                        order.Add(drink);//new Fryceritops());
                    }
                    else
                    {
                        drink = new Water();
                        combo.Drink = drink;
                        //order.Add(drink);//new Fryceritops());
                    }//CollectionViewSource.GetDefaultView(order.Items).MoveCur
                     //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
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
                if (combo == null)
                {
                    drink = new JurrasicJava();
                    order.Add(drink);//new Fryceritops());
                }
                else
                {
                    drink = new JurrasicJava();
                    combo.Drink = drink;
                    //order.Add(drink);//new Fryceritops());
                }//CollectionViewSou
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        /// <summary>
        /// Makes the order large.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeLarge(object sender, RoutedEventArgs args)
        {
            if (drink != null)
            {
                drink.Size = DinoDiner.Menu.Size.Large;
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else if (combo != null)
            {
                combo.Drink.Size = DinoDiner.Menu.Size.Large;
                combo.Drink = combo.Drink;
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Make the order medium.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeMedium(object sender, RoutedEventArgs args)
        {
            if (drink != null)
            {
                drink.Size = DinoDiner.Menu.Size.Medium;
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else if (combo != null)
            {
                combo.Drink.Size = DinoDiner.Menu.Size.Medium;
                combo.Drink = combo.Drink;
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Makes the order small.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeSmall(object sender, RoutedEventArgs args)
        {
            if (drink != null)
            {
                drink.Size = DinoDiner.Menu.Size.Small;
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else if (combo != null)
            {
                combo.Drink.Size = DinoDiner.Menu.Size.Small;
                combo.Drink = combo.Drink;
                NavigationService.Navigate(new CustomizeCombo(combo));
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
            }
        }
    }
}
