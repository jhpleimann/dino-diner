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
        List<IOrderItem> anItems = new List<IOrderItem>();
        /// <summary>
        /// The Order constructor
        /// </summary>
        public Order()
        {
            SalesTaxRate = 0.15;
        }

        /// <summary>
        /// The items setter.
        /// </summary>
        public IOrderItem[] Items { get { return anItems.ToArray(); } }

        /// <summary>
        /// Add an item to the array.
        /// </summary>
        /// <param name="item">The item added</param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnItemPropertyChanged;
            anItems.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Selection"));
        }

        /// <summary>
        /// Notifies of the property change
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The Event args object</param>
        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }


        /// <summary>
        /// Removes an item from the list
        /// </summary>
        /// <param name="item">The item removed</param>
        /// <returns></returns>
        public bool Remove(IOrderItem item)
        {
            bool removed = anItems.Remove(item);
            if(removed)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
            return anItems.Remove(item);
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
