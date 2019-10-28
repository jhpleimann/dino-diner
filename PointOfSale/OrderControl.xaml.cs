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
using System.Collections.Specialized;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public NavigationService NavigationService { get; set; }

        /// <summary>
        /// Initializes the compenents
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            MountItemListener();
        }

        /// <summary>
        /// When a menu optio is selected, used to select the new item and notufy program about the change.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The args argument</param>
        public void OnSelectionChanged(object sender, EventArgs args)
        {
            if(OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
            else if (OrderItems.SelectedItem is Sodasaurus soda)
            {
                NavigationService?.Navigate(new FlavorSelection(soda));
            }
            else if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
        }

        /// <summary>
        /// Used to list for item changes.
        /// </summary>
        private void MountItemListener()
        {
            if(DataContext is Order order)
            {
                order.Items.CollectionChanged += OnCollectionChanged;
            }
        }

        /// <summary>
        /// When data is changed, the mountitemlistener is notified.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The args argument</param>
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            MountItemListener();
        }

        /// <summary>
        /// Used when the collection data is changed.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The args argument</param>
        public void OnCollectionChanged(object sender, EventArgs args)
        {
            //
        }

        /// <summary>
        /// Used to remove an item from the order.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The args argument</param>
        private void OnRemoveOrderItem(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(sender is FrameworkElement element)
                {
                    if(element.DataContext is IOrderItem item)
                    {
                        order.Items.Remove(item);
                    }
                }
            }
        }
    }
}
