/*  PointOfSale
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// The side object
        /// </summary>
        private CretaceousCombo combo;
        /// <summary>
        /// Initializes the compenents
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
        }

        /// <summary>
        /// Goes to the CustomizeCombo page.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectComboSpecific(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
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
                /*if (//CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
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

        /// <summary>
        /// Adds a brontowurst to the order.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new Brontowurst());
                order.Add(combo);//new Fryceritops());
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeCombo(combo));
            //NOtify event listener
        }

        /// <summary>
        /// Adds a dino nuggets to the order.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new DinoNuggets());
                order.Add(combo);//new Fryceritops());
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeCombo(combo));
            //NOtify event listener
        }

        /// <summary>
        /// Adds a steakosaurus burger to the order.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void AddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(combo);//new Fryceritops());
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeCombo(combo));
            //NOtify event listener
        }

        /// <summary>
        /// Adds a T-Rex King Burger to the order.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new TRexKingBurger());
                order.Add(combo);//new Fryceritops());
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeCombo(combo));
            //NOtify event listener
        }

        /// <summary>
        /// Adds a  to the order.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(combo);//new Fryceritops());
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeCombo(combo));
            //NOtify event listener
        }

        /// <summary>
        /// Adds a pterodactytl wings to the order.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new PterodactylWings());
                order.Add(combo);//new Fryceritops());
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeCombo(combo));
            //NOtify event listener
        }

        /// <summary>
        /// Adds a veloci-wrap to the order.
        /// </summary>
        /// <param name="sender">The Sender Object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new VelociWrap());
                order.Add(combo);//new Fryceritops());
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeCombo(combo));
            //NOtify event listener
        }
    }
}
