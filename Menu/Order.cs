using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Collections.Specialized;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class used to do custom orders.
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        /// <summary>
        /// The Order constructor
        /// </summary>
        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            this.Items.CollectionChanged += this.OnCollectionChanged;
            SalesTaxRate = 0.15;
        }

        /// <summary>
        /// Used to tell if a property was changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies that a certain property changed.
        /// </summary>
        /// <param name="propertyName">Name of the property changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Notfify that the collection was changed
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The args object</param>
        public void OnCollectionChanged(Object sender, NotifyCollectionChangedEventArgs args)
        {

            NotifyOfPropertyChanged("SubtotalCost");
        }

        /// <summary>//
        /// The items added to the order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

        /// <summary>
        /// Calculates the total price from the prices of all order items.
        /// </summary>
        public double SubtotalCost {
            get
            {
                double cost = 0;
                foreach(IOrderItem a in Items)
                {
                    cost += a.Price;
                }
                if(cost < 0)
                {
                    return 0;
                }
                return cost;
            }
        }

        /// <summary>
        /// Calculates the total price from the prices of all order items.
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// Calculates the total price from the prices of all order items.
        /// </summary>
        public double SalesTaxCost { 
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        /// <summary>
        /// Calculates the total price from the prices of all order items.
        /// </summary>
        public double TotalCost {
            get
            {
                return SalesTaxCost + SubtotalCost;
            }
        }

    }
}
