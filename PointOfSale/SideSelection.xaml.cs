/*  SideSelection
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// The side object
        /// </summary>
        private Side side;
        /// <summary>
        /// The combo object
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Initializes the compenents
        /// </summary>
        /// <param name="side">The side object</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            if(DataContext is Order order)
            {
               //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
            this.side = side;
        }

        /// <summary>
        /// Initializes the compenents
        /// </summary>
        /// <param name="combo">The combo object</param>
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
            this.combo = combo;
        }

        /// <summary>
        /// Initializes the compenents
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }

        }

        /// <summary>
        /// Adds a Fryceritops to the order.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (combo == null)
                {
                    side = new Fryceritops();
                    order.Add(side);//new Fryceritops());
                }
                else
                {
                    combo.Side = new Fryceritops();
                    //order.Add(side);//new Fryceritops());
                }
                
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            //NOtify event listener
        }

        /// <summary>
        /// Adds a Meteor Mac and Cheese to the order.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void AddMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    side = new MeteorMacAndCheese();
                    order.Add(side);//new Fryceritops());
                }
                else
                {
                    combo.Side = new MeteorMacAndCheese();
                    //order.Add(side);//new Fryceritops());
                }
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            //NOtify event listener
        }

        /// <summary>
        /// Adds a MezzorellaSticks to the order.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    side = new MezzorellaSticks();
                    order.Add(side);//new Fryceritops());
                }
                else
                {
                    combo.Side = new MezzorellaSticks();
                    //order.Add(side);//new Fryceritops());
                }
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            //NOtify event listener
        }

        /// <summary>
        /// Adds a Triceritots to the order.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    side = new Triceritots();
                    order.Add(side);//new Fryceritops());
                }
                else
                {
                    combo.Side = new Triceritots();
                    //order.Add(side);//new Fryceritops());
                }
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            //NOtify event listener
        }

        /// <summary>
        /// Makes the order large.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void MakeLarge(object sender, RoutedEventArgs args)
        {
            if(side != null)
            {
                side.Size = DinoDiner.Menu.Size.Large;
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else if(combo != null)
            {
                combo.Side.Size = DinoDiner.Menu.Size.Large;
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
            if (side != null)
            {
                side.Size = DinoDiner.Menu.Size.Medium;
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else if (combo != null)
            {
                combo.Side.Size = DinoDiner.Menu.Size.Medium;
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
            if (side != null)
            {
                side.Size = DinoDiner.Menu.Size.Small;
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else if (combo != null)
            {
                combo.Side.Size = DinoDiner.Menu.Size.Small;
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
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
                /*if (//CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                   //Set radio to side.Size property
                   //Disable selected menu side
                }
                else
                {
                    //AddFryceritops.IsEnabled = true;//Use previous soelction.
                }*/
            }
        } 
    }
}
