/*  MainWindow
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes the compenents
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order order = (Order)DataContext;
            if(order != null)
            {
                OrderControl.NavigationService = OrderUI.NavigationService;
                order.Add(new DinoNuggets());
                order.Add(new Sodasaurus());
                Triceritots tots = new Triceritots();
                //tots.Size = DinoDiner.Menu.Size.Large;
                order.Add(tots);
                SteakosaurusBurger sb = new SteakosaurusBurger();
                sb.HoldBun();
                sb.HoldMustard();
                order.Add(sb);
            }
            
        }

        /// <summary>
        /// Used to pass on data from page to page.
        /// </summary>
        private void PassOnDataContext()
        {
            Page page = OrderUI.Content as Page;
            if(page != null)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }

        /// <summary>
        /// When the page is loaded in, passes on the necesarry data.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The args argument</param>
        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassOnDataContext();
        }

        /// <summary>
        /// When data is changed, the data is passed on.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The args argument</param>
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassOnDataContext();
        }
    }
}
